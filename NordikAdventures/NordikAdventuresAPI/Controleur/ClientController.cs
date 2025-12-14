using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NordikAdventuresAPI.JWT;
using NordikAdventuresAPI.Middleware;
using NordikAdventuresAPI.Modeles;
using NordikAdventuresAPI.Modeles.DTOs;
using NordikAdventuresAPI.Utilitaires;

namespace NordikAdventuresAPI.Controleur
{
    [Produces("application/json")]
    [Route("api/client/")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly BdContexteNordik _bdContexteNordik;
        private readonly INFO_AUTH _infoAuth = new INFO_AUTH();
        public ClientController(BdContexteNordik bdContexteNordik)
        {
            _bdContexteNordik = bdContexteNordik;
        }

        [HttpPost("creer")]
        public IActionResult CreerClient([FromBody] CreerClientDTO infoClient)
        {
            if (_bdContexteNordik.TablesClients.Where(c => c.Courriel == infoClient.courriel).Any())
            {
                return Conflict();
            }

            Clients nouveauClient = new Clients();
            nouveauClient.Nom = infoClient.nom;
            nouveauClient.Tel = infoClient.tel;
            nouveauClient.Mdp = Hacheur.HacheurProfessionel(infoClient.mdp);
            nouveauClient.Courriel = infoClient.courriel;
            nouveauClient.ClientID = "";
            nouveauClient.Type = infoClient.type;

            do
            {
                string matricule = Generateur.GenerateurMatricule16Carac(nouveauClient.Nom);
                if(_bdContexteNordik.TablesClients.Find(matricule) == null)
                {
                    nouveauClient.ClientID = matricule;
                }

            } while (nouveauClient.ClientID == "");

            _bdContexteNordik.TablesClients.Add(nouveauClient);
            _bdContexteNordik.SaveChanges();

            return Ok();
        }

        [JwtAuthorize]
        [HttpGet]
        public IActionResult ObtenirClient()
        {
            string? typeUtilisateur = ControllerContext.HttpContext.Items[_infoAuth.CONTEXTE_TYPE_UTILISATEUR] as string;
            if(typeUtilisateur != _infoAuth.TYPE_CLIENT)
            {
                return Unauthorized();
            }

            Clients? client = ControllerContext.HttpContext.Items[_infoAuth.CONTEXTE_UTILISATEUR] as Clients;
            if(client == null)
            {
                return Unauthorized();
            }

            client.Mdp = "";
            return Ok(client);
        }

        [HttpPost("commande")]
        public IActionResult AjouterCommandeClient([FromBody] CommandeClientDTO commande)
        {
            string? typeUtilisateur = ControllerContext.HttpContext.Items[_infoAuth.CONTEXTE_TYPE_UTILISATEUR] as string;
            if (typeUtilisateur != _infoAuth.TYPE_CLIENT)
            {
                return Unauthorized();
            }

            Clients? client = ControllerContext.HttpContext.Items[_infoAuth.CONTEXTE_UTILISATEUR] as Clients;
            if (client == null)
            {
                return Unauthorized();
            }
            double sousTotal = 0;
            double taxes = 0;
            
            List<Ventes> lesVentes = new List<Ventes>();

            foreach(ProduitQteDTO p in commande.Paniers)
            {
                Produits produit = _bdContexteNordik.TablesProduits.Find(p.SKU);
                sousTotal += produit.PrixVente;
            }
            //Taxes à ajouter dans le future

            FacturesClients facture = new FacturesClients(commande, client.ClientID, sousTotal, taxes);
            _bdContexteNordik.TablesFacturesClients.Add(facture);
            _bdContexteNordik.SaveChanges();

            foreach (ProduitQteDTO p in commande.Paniers)
            {
                Produits produit = _bdContexteNordik.TablesProduits.Find(p.SKU);
                sousTotal += produit.PrixVente;
                lesVentes.Add(new Ventes(p, produit, facture));
            }
            _bdContexteNordik.TablesVentes.AddRange(lesVentes);
            _bdContexteNordik.SaveChanges();

            if (client.Statut == 'P')
                client.Statut = 'A';
            _bdContexteNordik.TablesClients.Update(client);
            _bdContexteNordik.SaveChanges();
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using NordikAdventuresAPI.JWT;
using NordikAdventuresAPI.JWT;
using NordikAdventuresAPI.Middleware;
using NordikAdventuresAPI.Modeles;
using NordikAdventuresAPI.Modeles.DTOs;

namespace NordikAdventuresAPI.Controleur
{
    [Produces("application/json")]
    [Route("api/produit/")]
    [ApiController]
    public class ProduitController : ControllerBase
    {
        private readonly BdContexteNordik _bdContexteNordik;
        private readonly INFO_AUTH _infoAuth = new INFO_AUTH();
        public ProduitController(BdContexteNordik bdContexteNordik)
        {
            _bdContexteNordik = bdContexteNordik;
        }

        [HttpPost("creer/cat")]
        public IActionResult AjouterCategorie([FromBody] CreerCategorieDTO infoCategorie)
        {
            Categories newCat = new Categories(infoCategorie);
            _bdContexteNordik.TablesCategories.Add(newCat);
            _bdContexteNordik.SaveChanges();
            return Ok();
        }

        [HttpPost("creer/four")]
        public IActionResult AjouterFournisseur([FromBody] CreerFournisseurDTO infoFournisseur)
        {
            Fournisseurs newFour = new Fournisseurs(infoFournisseur);
            _bdContexteNordik.TablesFournisseurs.Add(newFour);
            _bdContexteNordik.SaveChanges();
            return Ok();
        }

        [HttpGet("obt/cat")]
        public IActionResult ObtenirCategories()
        {
            List<Categories> newCat = _bdContexteNordik.TablesCategories.ToList();
            List<CategorieDTO> lesCats = new List<CategorieDTO>();

            foreach(Categories c in newCat)
            {
                lesCats.Add(new CategorieDTO(c));
            }
            return Ok(lesCats);
        }

        [HttpGet("obt/four")]
        public IActionResult ObtenirFournisseurs()
        {
            List<Fournisseurs> newFour = _bdContexteNordik.TablesFournisseurs.ToList();
            List<FournisseurDTO> lesFour = new List<FournisseurDTO>();
            foreach (Fournisseurs f in newFour)
            {
                lesFour.Add(new FournisseurDTO(f));
            }
            return Ok(lesFour);
        }

        [HttpPost("creer")]
        public IActionResult CreerProduit([FromBody] CreerProduitDTO infoProduit)
        {
            Produits nouveauProduit = new Produits(infoProduit);
            _bdContexteNordik.TablesProduits.Add(nouveauProduit);
            Stocks nouveauStocks = new Stocks(infoProduit);
            _bdContexteNordik.TablesStocks.Add(nouveauStocks);
            _bdContexteNordik.SaveChanges();
            return Ok();
        }

        [JwtAuthorize]
        [HttpGet("client")]
        public IActionResult ObtenirProduitsPourClient()
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

            List<Produits> lesProduits = _bdContexteNordik.TablesProduits.ToList();
            List<ProduitsPourClientDTO> lesProduitsPourClient = new List<ProduitsPourClientDTO>();
            foreach(Produits p in lesProduits)
            {
                lesProduitsPourClient.Add(new ProduitsPourClientDTO(p, _bdContexteNordik));
            }
            return Ok(lesProduitsPourClient);
        }
    }
}

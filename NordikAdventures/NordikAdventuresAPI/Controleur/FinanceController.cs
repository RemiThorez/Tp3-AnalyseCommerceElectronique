using Microsoft.AspNetCore.Mvc;
using NordikAdventuresAPI.JWT;
using NordikAdventuresAPI.Middleware;
using NordikAdventuresAPI.Modeles;
using NordikAdventuresAPI.Modeles.DTOs;
using NordikAdventuresAPI.Utilitaires;

namespace NordikAdventuresAPI.Controleur
{
    [Produces("application/json")]
    [Route("api/finance/")]
    [ApiController]
    public class FinanceController : ControllerBase
    {
        private readonly BdContexteNordik _bdContexteNordik;
        private readonly INFO_AUTH _infoAuth = new INFO_AUTH();
        public FinanceController(BdContexteNordik bdContexteNordik)
        {
            _bdContexteNordik = bdContexteNordik;
        }

        [JwtAuthorize]
        [HttpPut("paiementClient")]
        public IActionResult PayerCommandeClient([FromBody] PaiementClientDTO paiement)
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

            FacturesClients facture = _bdContexteNordik.TablesFacturesClients.Find(paiement.IdFacture);

            if (facture == null)
            {
                return NotFound();
            }

            facture.MontantDu -= paiement.Montant;
            if (facture.MontantDu <= 0)
            {
                facture.MontantDu = 0;
                facture.Statut = "PA";
            }

            _bdContexteNordik.TablesFacturesClients.Update(facture);
            _bdContexteNordik.SaveChanges();

            return Ok();
        }

        [JwtAuthorize]
        [HttpGet("factsclient")]
        public IActionResult ObtenirFacturesClient()
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

            List<FacturesClients> factures = _bdContexteNordik.TablesFacturesClients.Where(f => f.IdClient == client.ClientID).ToList();
            List<FactureDTO> facturesEnvoyer = new List<FactureDTO>();
            foreach (FacturesClients f in factures)
            {
                facturesEnvoyer.Add(new FactureDTO(f));
            }
            return Ok(facturesEnvoyer);
        }
    }
}

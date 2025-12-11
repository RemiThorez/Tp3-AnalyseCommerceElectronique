using Microsoft.AspNetCore.Mvc;

namespace NordikAdventuresAPI.Controleur
{
    [Produces("application/json")]
    [Route("api/produit/")]
    [ApiController]
    public class ProduitController : ControllerBase
    {
        [HttpPost("creer")]
        public IActionResult CreerProduit()
        {
            throw new NotImplementedException();
        }

        [HttpGet()]
        public IActionResult ObtenirProduits()
        {
            throw new NotImplementedException();
        }
    }
}

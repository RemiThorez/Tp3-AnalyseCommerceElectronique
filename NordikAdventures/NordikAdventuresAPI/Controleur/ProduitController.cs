using Microsoft.AspNetCore.Mvc;

namespace NordikAdventuresAPI.Controleur
{
    [Produces("application/json")]
    [Route("api/produit/")]
    [ApiController]
    public class ProduitController : ControllerBase
    {
        public IActionResult CreerProduit()
        {
            throw new NotImplementedException();
        }

        public IActionResult ObtenirProduits()
        {
            throw new NotImplementedException();
        }
    }
}

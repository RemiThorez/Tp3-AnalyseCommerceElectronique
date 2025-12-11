using Microsoft.AspNetCore.Mvc;

namespace NordikAdventuresAPI.Controleur
{
    [Produces("application/json")]
    [Route("api/auth/")]
    [ApiController]
    public class AuthentificationController : ControllerBase
    {
        public IActionResult ConnexionEmploye()
        {
            throw new NotImplementedException();
        }

        public IActionResult ConnexionClient()
        {
            throw new NotImplementedException();
        }
    }
}

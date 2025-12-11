using Microsoft.AspNetCore.Mvc;

namespace NordikAdventuresAPI.Controleur
{
    [Produces("application/json")]
    [Route("api/client/")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [HttpPost("creer")]
        public IActionResult CreerClient()
        {
            throw new NotImplementedException();
        }
    }
}

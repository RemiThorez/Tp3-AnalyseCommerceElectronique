using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NordikAdventuresAPI.JWT;
using NordikAdventuresAPI.Modeles;
using NordikAdventuresAPI.Modeles.DTOs;
using NordikAdventuresAPI.Utilitaires;

namespace NordikAdventuresAPI.Controleur
{
    [Produces("application/json")]
    [Route("api/auth/")]
    [ApiController]
    public class AuthentificationController : ControllerBase
    {
        private readonly BdContexteNordik _bdContexteNordik;
        private readonly Authentification _auth;
        public AuthentificationController(BdContexteNordik bdContexteNordik, IOptions<ConfigApp> config)
        {
            _bdContexteNordik = bdContexteNordik;
            _auth = new Authentification(_bdContexteNordik, config.Value);
        }

        [HttpPost("employe")]
        public IActionResult ConnexionEmploye([FromBody] ConnexionDTO infoConn)
        {
            Employes? employe = _bdContexteNordik.TablesEmployes.Where(e => e.Courriel == infoConn.courriel && e.Mdp == Hacheur.HacheurProfessionel(infoConn.mdp)).First();
            if (employe == null)
            {
                return Unauthorized();
            }
            return Ok(_auth.GenerationJetonJWTEmploye(employe));
        }

        [HttpPost("client")]
        public IActionResult ConnexionClient([FromBody] ConnexionDTO infoConn)
        {
            Clients? client = _bdContexteNordik.TablesClients.Where(c => c.Courriel == infoConn.courriel && c.Mdp == Hacheur.HacheurProfessionel(infoConn.mdp)).First();
            if (client == null)
            {
                return Unauthorized();
            }
            return Ok(_auth.GenerationJetonJWTClient(client));
        }
    }
}

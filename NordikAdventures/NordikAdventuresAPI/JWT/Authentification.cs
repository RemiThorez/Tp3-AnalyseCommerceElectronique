using Microsoft.IdentityModel.Tokens;
using NordikAdventuresAPI.Modeles;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NordikAdventuresAPI.JWT
{
    /// <summary>
    /// Contient toutes les méthodes concernant l'autorisation
    /// </summary>
    public class Authentification
    {
        private BdContexteNordik _bd;
        private ConfigApp _configApp;
        private const string TYPE_CLIENT = "client";
        private const string TYPE_EMPLOYE = "employe";
        private const string TYPE_IDENTIFIANT = "qui";
        private const string ID = "id";

        /// <summary>
        /// Le constructeur de la classe autorisation
        /// </summary>
        /// <param name="bd">Donne accès à la bd</param>
        public Authentification(BdContexteNordik bd, ConfigApp configApp)
        {
            _bd = bd;
            _configApp = configApp;
        }
        /// <summary>
        /// Permet la génération de jeton
        /// </summary>
        /// <param name="utilisateur">Afin de mettre l'id de l'utilisateur dans le jeton</param>
        /// <returns>Une jeton</returns>
        public string GenerationJetonJWTClient(Clients client)
        {
            var maitreJeton = new JwtSecurityTokenHandler();
            // Récupération de notre chaine secrète pour générer les jetons
            var cle = Encoding.ASCII.GetBytes(_configApp.Secret);

            // Création du générateur de jetons
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                // On ajoute le id de l'usager au token
                Subject = new ClaimsIdentity(new[] { new Claim(ID, client.ClientID.ToString()), new Claim(TYPE_IDENTIFIANT, TYPE_CLIENT) }),
                // Valide pour 1 jour (on peut changer pour plus ou moins)
                Expires = DateTime.UtcNow.AddDays(1),

                // On signe le token
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(cle), SecurityAlgorithms.HmacSha256Signature)
            };
            // On crée le token
            var jeton = maitreJeton.CreateToken(tokenDescriptor);

            // On génère et retourne la clé représentant le token.
            return maitreJeton.WriteToken(jeton);
        }

        public string GenerationJetonJWTEmploye(Employes employe)
        {
            var maitreJeton = new JwtSecurityTokenHandler();
            // Récupération de notre chaine secrète pour générer les jetons
            var cle = Encoding.ASCII.GetBytes(_configApp.Secret);

            // Création du générateur de jetons
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                // On ajoute le id de l'usager au token
                Subject = new ClaimsIdentity(new[] { new Claim(ID, employe.Id.ToString()),new Claim(TYPE_IDENTIFIANT, TYPE_EMPLOYE) }),
                // Valide pour 1 jour (on peut changer pour plus ou moins)
                Expires = DateTime.UtcNow.AddDays(1),

                // On signe le token
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(cle), SecurityAlgorithms.HmacSha256Signature)
            };
            // On crée le token
            var jeton = maitreJeton.CreateToken(tokenDescriptor);

            // On génère et retourne la clé représentant le token.
            return maitreJeton.WriteToken(jeton);
        }

        /// <summary>
        /// Permet de valider le jeton
        /// </summary>
        /// <param name="context"></param>
        /// <param name="token">Le jeton</param>
        /// <returns>Rien, ne fait que mettre dans le contexte l'utilisateur qui est identifié dans le jeton</returns>
        public async Task ValidateTokenAsync(HttpContext context, string token)
        {
            try
            {
                var maitreJeton = new JwtSecurityTokenHandler();
                var cle = Encoding.ASCII.GetBytes(_configApp.Secret);
                maitreJeton.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(cle),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtJeton = (JwtSecurityToken)validatedToken;

                // On récupère le UserId du token (en supposant qu'on l'a ajouté à la création)
                string idUtilisateur = jwtJeton.Claims.First(x => x.Type == ID).Value;
                string typeUtilisateur = jwtJeton.Claims.First(x => x.Type == TYPE_IDENTIFIANT).Value;
                if (typeUtilisateur == TYPE_EMPLOYE)
                {
                    // On récupère les infos de l'usager de la BD.
                    // REMARQUE: on doit avoir accès à la BD si on veut récupérer l'usager ici.
                    context.Items["Utilisateur"] = await _bd.TablesEmployes.FindAsync(idUtilisateur);
                }
                else if (typeUtilisateur == TYPE_CLIENT)
                {
                    // On récupère les infos de l'usager de la BD.
                    // REMARQUE: on doit avoir accès à la BD si on veut récupérer l'usager ici.
                    context.Items["Utilisateur"] = await _bd.TablesClients.FindAsync(idUtilisateur);
                }
            }
            catch
            {

            }
        }
    }
}

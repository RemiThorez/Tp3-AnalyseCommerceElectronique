using System.Security.Cryptography;
using System.Text;

namespace NordikAdventuresAPI.Utilitaires
{
    public static class Hacheur
    {
        /// <summary>
        /// La méthode <c>HacheurProffessionel</c> sert à haché le mot de passe, 
        /// c'est ça seul fonction, il ne rajoute pas de sel. Le code vient d'un des labs de piratage que j'ai fait au Cégep, je le réutilise depuis maintenant 5 ans !.
        /// </summary>
        /// <param name="mdpNonHacher">Le mot de passe à hacher</param>
        /// <returns>Retourne la string du mot de passe étant maintenant hacher.</returns>
        static public string HacheurProfessionel(string mdpNonHacher)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hachisParmentier = sha256.ComputeHash(Encoding.UTF8.GetBytes(mdpNonHacher));

                StringBuilder reconstructeurDeHachisParmentier = new StringBuilder();
                foreach (byte b in hachisParmentier)
                {
                    reconstructeurDeHachisParmentier.Append(b.ToString("x2"));
                }

                return reconstructeurDeHachisParmentier.ToString();
            }
        }
    }
}

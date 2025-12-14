using System.ComponentModel.DataAnnotations;

namespace NordikAdventuresAPI.Modeles.DTOs
{
    public class CreerClientDTO
    {
        public string mdp { get; set; }
        public string courriel { get; set; }
        public string nom { get; set; }
        public string tel { get; set; }

        //Particulier (pa) || entreprise (en)
        public string type { get; set; }
    }
}

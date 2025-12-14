using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventures.Modeles.DTOs
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

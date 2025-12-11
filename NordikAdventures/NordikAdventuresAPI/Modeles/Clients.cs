using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class Clients
    {
        public string ClientID { get; set; }
        public string Mdp {  get; set; }
        public string Courriel { get; set; }
        public string Nom { get; set; }
        public string Tel { get; set; }
        public string Type { get; set; }
        public char Statut { get; set; }
        public int Satisfaction { get; set; }
    }
}

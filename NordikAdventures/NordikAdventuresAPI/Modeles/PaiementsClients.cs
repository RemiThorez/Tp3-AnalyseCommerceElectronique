using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class PaiementsClients
    {
        public int Id { get; set; }
        public string IdClient { get; set; }
        public int IdFacture { get; set; }
        public double montantPayer { get; set; }
        public DateTime date { get; set; }
    }
}

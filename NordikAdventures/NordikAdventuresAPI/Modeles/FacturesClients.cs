using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class FacturesClients
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string IdClient { get; set; }
        public double SousTotal { get; set; }
        public double Taxes { get; set; }
        public double MontantDu { get; set; }
        public string Statut { get; set; }
        public DateTime DateLimitePaiement { get; set; }
    }
}

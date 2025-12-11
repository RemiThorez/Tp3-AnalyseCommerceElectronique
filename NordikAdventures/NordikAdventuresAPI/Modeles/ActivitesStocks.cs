using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class ActivitesStocks
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public int Qte { get; set; }
        public string Raison { get; set; }
        public DateTime Date { get; set; }
    }
}

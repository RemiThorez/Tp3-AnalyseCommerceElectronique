using System;
using System.Collections.Generic;


using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventures.Modeles
{
    public class Stocks
    {
        
        
        public string SKU { get; set; }
        
        public int Qte { get; set; }
        
        public int QteReserve { get; set; }
        
        public int SeuilReaprovisionnement { get; set; }
        
        public int SeuilMinimun { get; set; }
        
        public int DelaiLivraison { get; set; }
        
        public string Entrepot { get; set; }
        
        public DateTime dateEntree { get; set; }

    }
}

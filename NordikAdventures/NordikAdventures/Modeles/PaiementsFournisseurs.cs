using System;
using System.Collections.Generic;


using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventures.Modeles
{
    public class PaiementsFournisseurs
    {
        
        
        public int Id { get; set; }
        
        public DateTime date { get; set; }
        
        public int IdCommande { get; set; }
        
        public double Paiement { get; set; }

    }
}

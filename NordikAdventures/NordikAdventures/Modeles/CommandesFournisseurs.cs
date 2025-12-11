using System;
using System.Collections.Generic;


using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventures.Modeles
{
    public class CommandesFournisseurs
    {
        
        
        public int Id { get; set; }
        
        public DateTime Date { get; set; }
        
        public int IdFournisseur { get; set; }
        
        public bool Valider { get; set; }
        
        public string Statut { get; set; }
        
        public DateTime DateLimitePaiements { get; set; }
        
        public double MontantDu { get; set; }

    }
}

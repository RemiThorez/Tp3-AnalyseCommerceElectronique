using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventures.Modeles.DTOs
{
    public class PaiementClientDTO
    {
        public PaiementClientDTO() { }
        public PaiementClientDTO(int idFacture, double montant) 
        {
            IdFacture = idFacture;
            Montant = montant;
        }

        public int IdFacture { get; set; }
        public double Montant { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventures.Modeles.DTOs
{
    public class ProduitQteDTO
    {
        public ProduitQteDTO() { }

        public ProduitQteDTO(Paniers panier)
        {
            SKU = panier.LeProduits.SKU;
            Qte = panier.Qte;
        }
        public string SKU { get; set; }
        public int Qte { get; set; }
    }
}

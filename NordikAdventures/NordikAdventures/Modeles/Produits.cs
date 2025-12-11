using System;
using System.Collections.Generic;


using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventures.Modeles
{
    public class Produits
    {
        
        
        public string SKU { get; set; }
        
        public string CodeFournisseur { get; set; }
        
        public string NomProduit{ get; set; }
        
        public bool Statut {  get; set; }
        
        public float Poids { get; set; }
        
        public double CoutAchat { get; set; }
        
        public double PrixVente { get; set; }
        
        public int IdFournisseur { get; set; }
        
        public int IdCategorie { get; set; }

    }
}

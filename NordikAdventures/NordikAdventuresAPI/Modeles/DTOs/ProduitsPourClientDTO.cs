using System.ComponentModel.DataAnnotations;

namespace NordikAdventuresAPI.Modeles.DTOs
{
    public class ProduitsPourClientDTO
    {
        public ProduitsPourClientDTO(Produits prod, BdContexteNordik bd)
        {
            Stocks stock = bd.TablesStocks.Where(s => s.SKU == prod.SKU).FirstOrDefault();

            SKU = prod.SKU;
            CodeFournisseur = prod.CodeFournisseur;
            NomProduit = prod.NomProduit;
            Statut = prod.Statut;
            Poids = prod.Poids;
            CoutAchat = prod.CoutAchat;
            PrixVente = prod.PrixVente;
            QteDisponible = stock.Qte - stock.QteReserve;
            LeFournisseur = new FournisseurDTO(bd.TablesFournisseurs.Find(prod.IdFournisseur));
            LaCategorie = new CategorieDTO(bd.TablesCategories.Find(prod.IdCategorie));
        }
        public string SKU { get; set; }
        public string CodeFournisseur { get; set; }
        public string NomProduit { get; set; }
        public bool Statut { get; set; }
        public float Poids { get; set; }
        public double CoutAchat { get; set; }
        public double PrixVente { get; set; }
        public int QteDisponible { get; set; }
        public FournisseurDTO LeFournisseur { get; set; }
        public CategorieDTO LaCategorie { get; set; }
    }
}

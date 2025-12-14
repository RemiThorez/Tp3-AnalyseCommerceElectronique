using System.ComponentModel.DataAnnotations;

namespace NordikAdventuresAPI.Modeles.DTOs
{
    public class CreerProduitDTO
    {
        public string SKU { get; set; }
        public string CodeFournisseur { get; set; }
        public string NomProduit { get; set; }
        public bool Statut { get; set; }
        public float Poids { get; set; }
        public double CoutAchat { get; set; }
        public double PrixVente { get; set; }
        public int IdFournisseur { get; set; }
        public int IdCategorie { get; set; }
        public int Qte { get; set; }
        public int QteReserve { get; set; }
        public int SeuilReaprovisionnement { get; set; }
        public int SeuilMinimun { get; set; }
        public int DelaiLivraison { get; set; }
        public string Entrepot { get; set; }
    }
}

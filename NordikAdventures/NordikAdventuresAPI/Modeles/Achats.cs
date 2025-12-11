using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NordikAdventuresAPI.Modeles
{
    public class Achats
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public int Qte { get; set; }
        [Required]
        public double CoutHistorique { get; set; }
        [Required]
        public int IdCommandeFournisseur { get; set; }

        [ForeignKey("IdCommandeFournisseur")]
        [Required]
        public CommandesFournisseurs CommandeFournisseur {  get; set; }

        [ForeignKey("SKU")]
        [Required]
        public Produits LeProduit { get; set; }
    }
}
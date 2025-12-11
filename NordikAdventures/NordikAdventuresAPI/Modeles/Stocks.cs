using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class Stocks
    {
        [Key]
        [Required]
        public string SKU { get; set; }
        [Required]
        public int Qte { get; set; }
        [Required]
        public int QteReserve { get; set; }
        [Required]
        public int SeuilReaprovisionnement { get; set; }
        [Required]
        public int SeuilMinimun { get; set; }
        [Required]
        public int DelaiLivraison { get; set; }
        [Required]
        public string Entrepot { get; set; }
        [Required]
        public DateTime dateEntree { get; set; }

        [ForeignKey("SKU")]
        [Required]
        public Produits LeProduit { get; set; }
    }
}

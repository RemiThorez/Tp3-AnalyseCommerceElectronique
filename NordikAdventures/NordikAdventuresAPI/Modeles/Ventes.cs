using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class Ventes
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public int Qte { get; set; }
        [Required]
        public double PrixVenteHistorique { get; set; }
        [Required]
        public int IdFacture { get; set; }

        [ForeignKey("IdFacture")]
        [Required]
        public FacturesClients LaFactureClient { get; set; }

        [ForeignKey("SKU")]
        [Required]
        public Produits LeProduit { get; set; }
    }
}

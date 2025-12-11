using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class PaiementsClients
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string IdClient { get; set; }
        [Required]
        public int IdFacture { get; set; }
        [Required]
        public double montantPayer { get; set; }
        [Required]
        public DateTime date { get; set; }

        [ForeignKey("IdClient")]
        [Required]
        public Clients LeClient { get; set; }

        [ForeignKey("IdFacture")]
        [Required]
        public FacturesClients LaFactureClient { get; set; }
    }
}

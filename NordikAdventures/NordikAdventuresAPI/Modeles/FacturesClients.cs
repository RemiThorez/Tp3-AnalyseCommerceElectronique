using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class FacturesClients
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string IdClient { get; set; }
        [Required]
        public double SousTotal { get; set; }
        [Required]
        public double Taxes { get; set; }
        [Required]
        public double MontantDu { get; set; }
        [Required]
        public string Statut { get; set; }
        [Required]
        public DateTime DateLimitePaiement { get; set; }

        [ForeignKey("IdClient")]
        [Required]
        public Clients LeClient { get; set; }

        public ICollection<PaiementsClients> LesPaiementsClient { get; set; } = new List<PaiementsClients>();
        public ICollection<Ventes> LesVentes { get; set; } = new List<Ventes>();
    }
}

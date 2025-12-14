using NordikAdventuresAPI.Modeles.DTOs;
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
        public FacturesClients() { }

        public FacturesClients(CommandeClientDTO commande, string idClient, double sousTotal, double taxes)
        {
            Date = DateTime.Now;
            IdClient = idClient;
            SousTotal = sousTotal;
            Taxes = taxes;
            MontantDu = sousTotal+taxes;
            DateLimitePaiement = DateTime.Now.AddDays(7);
            Satisfaction = commande.Satisfaction;
            Statut = "PR";
        }

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
        // PR pour partiel, PA pour payée et RT pour retard
        [Required]
        public string Statut { get; set; }
        [Required]
        public int Satisfaction { get; set; }
        [Required]
        public DateTime DateLimitePaiement { get; set; }

        [ForeignKey("IdClient")]
        [Required]
        public Clients LeClient { get; set; }

        public ICollection<PaiementsClients> LesPaiementsClient { get; set; } = new List<PaiementsClients>();
        public ICollection<Ventes> LesVentes { get; set; } = new List<Ventes>();
    }
}

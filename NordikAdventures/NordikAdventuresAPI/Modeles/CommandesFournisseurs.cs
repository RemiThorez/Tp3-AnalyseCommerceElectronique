using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class CommandesFournisseurs
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int IdFournisseur { get; set; }
        [Required]
        public bool Valider { get; set; }
        [Required]
        public string Statut { get; set; }
        [Required]
        public DateTime DateLimitePaiements { get; set; }
        [Required]
        public double MontantDu { get; set; }

        [ForeignKey("IdFournisseur")]
        [Required]
        public Fournisseurs Fournisseur { get; set; }

        public ICollection<Achats> LesAchats { get; set; } = new List<Achats>();
        public ICollection<PaiementsFournisseurs> LesPaiementsFournisseur { get; set; } = new List<PaiementsFournisseurs>();
    }
}

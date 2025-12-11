using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class PaiementsFournisseurs
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]
        public int IdCommande { get; set; }
        [Required]
        public double Paiement { get; set; }

        [ForeignKey("IdCommande")]
        [Required]
        public CommandesFournisseurs LesCommandesFournisseurs{ get; set; }
    }
}

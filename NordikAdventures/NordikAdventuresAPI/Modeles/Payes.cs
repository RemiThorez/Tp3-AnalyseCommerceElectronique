using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class Payes
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string IdEmploye { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public double Paye { get; set; }

        [ForeignKey("IdEmploye")]
        [Required]
        public Employes LEmploye { get; set; }
    }
}

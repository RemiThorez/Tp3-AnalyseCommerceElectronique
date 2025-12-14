using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class ParamFisc
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int Nom { get; set; }
        [Required]
        public float TauxTaxe { get; set; }
    }
}

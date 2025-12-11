using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class Categories
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string NomCategorie { get; set; }

        public ICollection<Produits> LesProduits { get; set; } = new List<Produits>();
    }
}

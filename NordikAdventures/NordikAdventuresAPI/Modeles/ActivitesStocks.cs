using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class ActivitesStocks
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public int Qte { get; set; }
        [Required]
        public string Raison { get; set; }
        [Required]
        public DateTime Date { get; set; }

        [ForeignKey("SKU")]
        [Required]
        public Produits LeProduit { get; set; }
    }
}

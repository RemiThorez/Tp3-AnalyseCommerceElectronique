using Microsoft.AspNetCore.Routing.Constraints;
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
    public class Stocks
    {
        public Stocks() { } 
        public Stocks(CreerProduitDTO infoProduit) 
        {
            SKU = infoProduit.SKU;
            Qte = infoProduit.Qte;
            QteReserve = infoProduit.QteReserve;
            SeuilReaprovisionnement = infoProduit.SeuilReaprovisionnement;
            SeuilMinimun = infoProduit.SeuilMinimun;
            DelaiLivraison = infoProduit.DelaiLivraison;
            Entrepot = infoProduit.Entrepot;
            dateEntree = DateTime.Now;
        }

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public int Qte { get; set; }
        [Required]
        public int QteReserve { get; set; }
        [Required]
        public int SeuilReaprovisionnement { get; set; }
        [Required]
        public int SeuilMinimun { get; set; }
        [Required]
        public int DelaiLivraison { get; set; }
        [Required]
        public string Entrepot { get; set; }
        [Required]
        public DateTime dateEntree { get; set; }

        [ForeignKey("SKU")]
        [Required]
        public Produits LeProduit { get; set; }
    }
}

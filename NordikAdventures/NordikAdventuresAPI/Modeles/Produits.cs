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
    public class Produits
    {
        Produits() { }
        public Produits(CreerProduitDTO infoProduit)
        {
            SKU = infoProduit.SKU;
            CodeFournisseur = infoProduit.CodeFournisseur;
            NomProduit = infoProduit.NomProduit;
            Statut = infoProduit.Statut;
            Poids = infoProduit.Poids;
            CoutAchat = infoProduit.CoutAchat;
            PrixVente = infoProduit.PrixVente;
            IdFournisseur = infoProduit.IdFournisseur;
            IdCategorie = infoProduit.IdCategorie;
        }

        [Key]
        [Required]
        public string SKU { get; set; }
        [Required]
        public string CodeFournisseur { get; set; }
        [Required]
        public string NomProduit{ get; set; }
        [Required]
        public bool Statut {  get; set; }
        [Required]
        public float Poids { get; set; }
        [Required]
        public double CoutAchat { get; set; }
        [Required]
        public double PrixVente { get; set; }
        [Required]
        public int IdFournisseur { get; set; }
        [Required]
        public int IdCategorie { get; set; }

        [ForeignKey("IdFournisseur")]
        [Required]
        public Fournisseurs LeFounisseur { get; set; }

        [ForeignKey("IdCategorie")]
        [Required]
        public Categories LaCategorie { get; set; }

        public ICollection<Achats> LesAchats { get; set; } = new List<Achats>();
        public ICollection<ActivitesStocks> MouvementsStocks { get; set; } = new List<ActivitesStocks>();
        public ICollection<Ventes> LesVentes { get; set; } = new List<Ventes>();
        public Stocks LeStocks { get; set; } = new Stocks();
    }
}

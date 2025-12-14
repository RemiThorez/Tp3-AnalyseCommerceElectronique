using NordikAdventuresAPI.Modeles.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class Fournisseurs
    {
        public Fournisseurs() { }
        public Fournisseurs(CreerFournisseurDTO newFour) 
        {
            Nom = newFour.Nom;
            RistourneFournisseur = newFour.RistourneFournisseur;
        }

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public float RistourneFournisseur { get; set; }

        public ICollection<CommandesFournisseurs> LesCommandesAuxFournisseur { get; set; } = new List<CommandesFournisseurs>();
        public ICollection<Produits> LesProduits { get; set; } = new List<Produits>();
    }
}

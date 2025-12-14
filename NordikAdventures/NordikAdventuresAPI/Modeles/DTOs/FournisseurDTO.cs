using System.ComponentModel.DataAnnotations;

namespace NordikAdventuresAPI.Modeles.DTOs
{
    public class FournisseurDTO
    {
        public FournisseurDTO(Fournisseurs four) 
        {
            Id = four.Id;
            Nom = four.Nom;
            RistourneFournisseur = four.RistourneFournisseur;
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public float RistourneFournisseur { get; set; }
    }
}

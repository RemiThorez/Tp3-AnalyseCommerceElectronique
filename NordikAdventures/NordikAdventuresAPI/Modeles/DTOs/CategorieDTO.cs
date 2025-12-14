using System.ComponentModel.DataAnnotations;

namespace NordikAdventuresAPI.Modeles.DTOs
{
    public class CategorieDTO
    {
        public CategorieDTO(Categories cat) 
        {
            Id = cat.Id;
            NomCategorie = cat.NomCategorie;
        }
        public int Id { get; set; }
        public string NomCategorie { get; set; }
    }
}

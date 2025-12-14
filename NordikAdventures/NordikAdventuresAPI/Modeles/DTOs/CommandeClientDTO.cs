namespace NordikAdventuresAPI.Modeles.DTOs
{
    public class CommandeClientDTO
    {
        public List<ProduitQteDTO> Paniers { get; set; }
        public int Satisfaction { get; set; }
    }
}

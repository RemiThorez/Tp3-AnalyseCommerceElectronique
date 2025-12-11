


namespace NordikAdventures.Modeles
{
    public class Achats
    {
        
        public int Id { get; set; }
        
        public string SKU { get; set; }
        
        public int Qte { get; set; }
        
        public double CoutHistorique { get; set; }
        
        public int IdCommandeFournisseur { get; set; }
    }
}
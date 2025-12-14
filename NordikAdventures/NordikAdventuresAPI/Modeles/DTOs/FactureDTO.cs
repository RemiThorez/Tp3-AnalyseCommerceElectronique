namespace NordikAdventuresAPI.Modeles.DTOs
{
    public class FactureDTO
    {
        public FactureDTO() { }
        public FactureDTO(FacturesClients facture)
        {
            Id = facture.Id;
            Date = facture.Date;
            IdClient = facture.IdClient;
            SousTotal = facture.SousTotal;
            Taxes = facture.Taxes;
            MontantDu = facture.MontantDu;
            Statut = facture.Statut;
            Satisfaction = facture.Satisfaction;
            DateLimitePaiement = facture.DateLimitePaiement;
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string IdClient { get; set; }
        public double SousTotal { get; set; }
        public double Taxes { get; set; }
        public double MontantDu { get; set; }
        // PR pour partiel, PA pour payée et RT pour retard
        public string Statut { get; set; }
        public int Satisfaction { get; set; }
        public DateTime DateLimitePaiement { get; set; }
    }
}

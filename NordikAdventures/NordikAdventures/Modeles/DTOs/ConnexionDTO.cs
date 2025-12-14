namespace NordikAdventures.Modeles.DTOs
{
    public class ConnexionDTO
    {
        public ConnexionDTO(string courriel, string mdp)
        {
            this.courriel = courriel;
            this.mdp = mdp;
        }

        public string courriel { get; set; }
        public string mdp { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class Clients
    {
        [Key]
        [Required]
        public string ClientID { get; set; }
        [Required]
        public string Mdp {  get; set; }
        [Required]
        public string Courriel { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Tel { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public char Statut { get; set; }
        [Required]
        public int Satisfaction { get; set; }

        public ICollection<ActivitesClients> LesActivitesDuClient { get; set; } = new List<ActivitesClients>();
        public ICollection<FacturesClients> LesFacturesClient { get; set; } = new List<FacturesClients>();
        public ICollection<PaiementsClients> LesPaiementsClient { get; set; } = new List<PaiementsClients>();
    }
}

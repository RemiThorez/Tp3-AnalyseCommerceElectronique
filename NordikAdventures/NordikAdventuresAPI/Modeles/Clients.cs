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

        //Particulier (pa) || entreprise (en)
        [Required]
        public string Type { get; set; }
        //Actif(A), inactif(I), prospect(P), Fidèle(F)
        [Required]
        public char Statut { get; set; } = 'P';
        [Required]
        public int Satisfaction { get; set; } = -1;

        public ICollection<ActivitesClients> LesActivitesDuClient { get; set; } = new List<ActivitesClients>();
        public ICollection<FacturesClients> LesFacturesClient { get; set; } = new List<FacturesClients>();
    }
}

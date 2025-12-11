using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class Employes
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        public bool AccesProduits { get; set; }
        [Required]
        public bool AccesFinances { get; set; }
        [Required]
        public bool AccesClient { get; set; }
        [Required]
        public bool Admin { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Mdp { get; set; }
        [Required]
        public string Tel { get; set; }
        [Required]
        public string Courriel { get; set; }

        public ICollection<ActivitesClients> LesActivitesDuClient { get; set; } = new List<ActivitesClients>();
        public ICollection<Payes> LesPayesDEmploye { get; set; } = new List<Payes>();

    }
}

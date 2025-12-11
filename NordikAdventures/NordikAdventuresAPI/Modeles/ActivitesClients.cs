using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class ActivitesClients
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string IdClient { get; set; }
        [Required]
        public string IdEmploye { get; set; }

        [ForeignKey("IdClient")]
        [Required]
        public Clients LeClient { get; set; }

        [ForeignKey("IdEmploye")]
        [Required]
        public Employes LEmploye { get; set; }
    }
}

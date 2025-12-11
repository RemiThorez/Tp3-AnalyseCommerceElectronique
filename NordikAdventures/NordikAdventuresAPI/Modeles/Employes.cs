using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventuresAPI.Modeles
{
    public class Employes
    {
        public string Id { get; set; }
        public bool AccesProduits { get; set; }
        public bool AccesFinances { get; set; }
        public bool AccesClient { get; set; }
        public string Nom { get; set; }
        public string Mdp { get; set; }
        public string Tel { get; set; }
        public string Courriel { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordikAdventures.Modeles
{
    public class Clients
    {
        public string ClientID { get; set; } = "";
        
        public string Mdp {  get; set; } = "";

        public string Courriel { get; set; } = "";

        public string Nom { get; set; } = "";

        public string Tel { get; set; } = "";
        //Particulier (pa) || entreprise (en)
        public string Type { get; set; } = "";
        //Actif(A), inactif(I), prospect(P), Fidèle(F)
        public char Statut { get; set; } = ' ';

        public int Satisfaction { get; set; } = -1;

        public string Jeton { get; set; } = "";

        public BindingList<Paniers> Paniers { get; set; } = new BindingList<Paniers>();

    }
}

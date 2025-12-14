using NordikAdventures.Modeles;
using NordikAdventures.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NordikAdventures.InterfaceUtilisateur.Client
{
    public partial class PageCPaiements : Form
    {
        private Clients _client;
        private Form _parent;
        private PageCAccueilClient _accueil;
        private Produits _produit;
        private List<FacturesClients> _lesFactures = new List<FacturesClients>();
        private bool nePasAfficherParent = false;
        public PageCPaiements(PageCAccueilClient accueil, Clients client)
        {
           
            _client = client;
            _accueil = accueil;
            _parent = accueil;
            rafraichirFactures();
            InitializeComponent();
        }

        public PageCPaiements(Form parent, PageCAccueilClient accueil, Clients client)
        {
            _client = client;
            _accueil = accueil;
            _parent = parent;
            rafraichirFactures();
            InitializeComponent();
        }

        public async void rafraichirFactures()
        {
            ServicesFinances servicesFinances = new ServicesFinances();
            _lesFactures = await servicesFinances.ObtenirFacturesClient(_client.Jeton);

            foreach(FacturesClients f in _lesFactures)
            {
                CartePaiement carte = new CartePaiement(this,_client,f);
                carte.Margin = new Padding(10);

                list_factClient.Controls.Add(carte);
            }
        }

        private void fermeture(object sender, FormClosingEventArgs e)
        {
            if (!nePasAfficherParent)
            {
                _parent.Visible = true;
            }
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_profil_Click(object sender, EventArgs e)
        {
            nePasAfficherParent = true;
            _accueil.Visible = true;
            this.Close();
        }
    }
}

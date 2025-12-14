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
    public partial class PageCPanier : Form
    {
        private Clients _client;
        private Form _parent;
        private PageCAccueilClient _accueil;
        private bool nePasAfficherParent = false;
        private BindingSource _panier;
        public PageCPanier(PageCAccueilClient accueil, Clients client, BindingSource panier)
        {
            _client = client;
            _accueil = accueil;
            _parent = accueil;
            _panier = panier;
            InitializeComponent();
            list_produits.DataSource = _panier;
            double prix = 0;
            foreach(Paniers p in _client.Paniers)
            {
                prix += p.LeProduits.PrixVente * p.Qte;
            }

            //Gerer les taxes
            l_total.Text = $"Total: {prix}$";
            l_taxes.Text = $"Taxes: {prix}$";
            l_soustotal.Text = $"Sous-total: {prix}$";
        }

        public PageCPanier(Form parent, PageCAccueilClient accueil, Clients client, BindingSource panier)
        {
            _client = client;
            _accueil = accueil;
            _parent = parent;
            _panier = panier;
            InitializeComponent();
            list_produits.DataSource = _panier;
            double prix = 0;
            foreach (Paniers p in _client.Paniers)
            {
                prix += p.LeProduits.PrixVente * p.Qte;
            }

            //Gerer les taxes
            l_total.Text = $"Total: {prix}$";
            l_taxes.Text = $"Taxes: {prix}$";
            l_soustotal.Text = $"Sous-total: {prix}$";
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

        private async void btn_confirmer_Click(object sender, EventArgs e)
        {
            ServicesClient servicesClient = new ServicesClient();
            if(await servicesClient.ConfirmerCommandeClient(_client.Jeton, _client))
            {
                _client.Paniers.Clear();
                this.Close();
            }
        }
    }
}

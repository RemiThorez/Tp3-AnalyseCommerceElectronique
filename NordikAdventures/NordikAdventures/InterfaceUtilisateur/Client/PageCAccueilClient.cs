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
    public partial class PageCAccueilClient : Form
    {
        private readonly Form _parent;
        private Clients _client;
        private bool nePasAfficherParent = false;
        private BindingSource _panier = new BindingSource();
        public PageCAccueilClient(Form parent, Clients client)
        {
            this._parent = parent;
            this._client = client;
            _panier.DataSource = _client.Paniers;
            InitializeComponent();

            txt_nom.Text = client.Nom;
            list_produits.DataSource = _panier;
        }

        private void fermeture(object sender, FormClosingEventArgs e)
        {
            if (!nePasAfficherParent)
            {
                _parent.Visible = true;
            }
        }

        private void btn_deco_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btn_produit_Click(object sender, EventArgs e)
        {
            ServicesProduits servicesProd = new ServicesProduits();
            List<Produits> lesProduits = await servicesProd.ObtenirProduits(_client.Jeton);
            Form frmProduit = new PageCDesProduits(this, this, _client, lesProduits, _panier);
            frmProduit.Visible = true;
            this.Visible = false;
        }

        private void btn_panier_Click(object sender, EventArgs e)
        {
            Form frmPaniers = new PageCPanier(this, _client, _panier);
            frmPaniers.Visible = true;
            this.Visible = false;
        }

        private void btn_paiement_Click(object sender, EventArgs e)
        {
            Form frmPaiement = new PageCPaiements(this, _client);
            frmPaiement.Visible = true;
            this.Visible = false;
        }
    }
}

using NordikAdventures.InterfaceUtilisateur.Client;
using NordikAdventures.Modeles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NordikAdventures.InterfaceUtilisateur
{
    public partial class PageCDesProduits : Form
    {
        private Clients _client;
        private Form _parent;
        private PageCAccueilClient _accueil;
        private List<Produits> _produits;
        private bool nePasAfficherParent = false;
        private BindingSource _panier;
        public PageCDesProduits(Form parent, PageCAccueilClient accueil, Clients clients, List<Produits> produits, BindingSource panier)
        {
            _parent = parent;
            _accueil = accueil;
            _client = clients;
            _produits = produits;
            _panier = panier;
            InitializeComponent();
            
            list_produits.DataSource = _panier;
            ChargerProduits();
        }

        private void ChargerProduits()
        {
            pan_produits.Controls.Clear();

            foreach (Produits p in _produits)
            {
                CarteProduit carte = new CarteProduit(this, _accueil, _client, p,_panier);
                carte.Margin = new Padding(10);

                pan_produits.Controls.Add(carte);
            }
        }

        private void fermeture(object sender, FormClosingEventArgs e)
        {
            if (!nePasAfficherParent)
            {
                _parent.Visible = true;
            }
        }

        private void btn_profil_Click(object sender, EventArgs e)
        {
            nePasAfficherParent = true;
            _accueil.Visible = true;
            this.Close();
        }

        private void btn_panier_Click(object sender, EventArgs e)
        {
            Form frmPanier = new PageCPanier(this, _accueil, _client, _panier);
            frmPanier.Visible = true;
            this.Visible = false;
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

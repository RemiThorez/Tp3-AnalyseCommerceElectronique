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
    public partial class PageCProduitDetail : Form
    {
        private Clients _client;
        private Form _parent;
        private PageCAccueilClient _accueil;
        private Produits _produit;
        private bool nePasAfficherParent = false;
        BindingSource _panier;
        public PageCProduitDetail(Form parent, PageCAccueilClient acceuil, Clients client, Produits produit, BindingSource panier)
        {
            _parent = parent;
            _client = client;
            _produit = produit;
            _accueil = acceuil;
            _panier = panier;
            InitializeComponent();
            list_produits.DataSource = _panier;
            l_nom.Text = _produit.NomProduit;
            l_SKU.Text = _produit.SKU;
            l_fournisseur.Text = _produit.LeFournisseur.Nom;
            l_categorie.Text = _produit.LaCategorie.NomCategorie;
            l_prixVente.Text = _produit.PrixVente.ToString();
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

        private void btn_supprimerPanier_Click(object sender, EventArgs e)
        {
            BindingList<Paniers> panierASuppr = new BindingList<Paniers>();

            foreach (Paniers p in _client.Paniers)
            {
                if (p.LeProduits.SKU == _produit.SKU)
                    panierASuppr.Add(p);
            }

            foreach(Paniers p in panierASuppr)
            {
                _client.Paniers.Remove(p);
            }
        }

        private void btn_ajoutProd_Click(object sender, EventArgs e)
        {
            bool existe = false;
            foreach (Paniers p in _client.Paniers)
            {
                if (p.LeProduits.SKU == _produit.SKU)
                {
                    p.Qte += (int)nb_qteAcheter.Value;
                    if(p.Qte > _produit.QteDisponible)
                        p.Qte = _produit.QteDisponible;
                    existe = true;
                }
            }
            if(!existe)
            {
                _client.Paniers.Add(new Paniers(_produit, (int) nb_qteAcheter.Value));
            }
        }

        private void btn_retraitProd_Click(object sender, EventArgs e)
        {
            BindingList<Paniers> panierASuppr = new BindingList<Paniers>();
            foreach (Paniers p in _client.Paniers)
            {
                if (p.LeProduits.SKU == _produit.SKU)
                {
                    p.Qte -= (int)nb_qteAcheter.Value;
                    if(p.Qte <= 0)
                        panierASuppr.Add(p);
                }
            }

            foreach (Paniers p in panierASuppr)
            {
                _client.Paniers.Remove(p);
            }
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

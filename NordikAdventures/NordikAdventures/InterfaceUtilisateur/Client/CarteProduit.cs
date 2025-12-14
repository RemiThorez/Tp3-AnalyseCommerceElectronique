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

namespace NordikAdventures.InterfaceUtilisateur.Client
{
    public partial class CarteProduit : UserControl
    {
        private Produits _produit;
        private Clients _client;
        private PageCDesProduits _parent;
        private PageCAccueilClient _accueil;
        private BindingSource _panier;

        public CarteProduit(PageCDesProduits parent, PageCAccueilClient accueil,Clients clients, Produits produit, BindingSource panier)
        {
            _parent = parent;
            _accueil = accueil;
            _client = clients;
            _produit = produit;
            _panier = panier;
            InitializeComponent();
            l_nom.Text = _produit.NomProduit;
            l_cat.Text = _produit.LaCategorie.NomCategorie;
            l_fournisseur.Text = "Fournisseur: "+_produit.LeFournisseur.Nom;
            l_SKU.Text = "SKU: "+_produit.SKU;
            l_prix.Text = "Le prix: " +_produit.PrixVente.ToString()+"$";
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            bool existe = false;
            foreach (Paniers p in _client.Paniers)
            {
                if (p.LeProduits.SKU == _produit.SKU)
                {
                    p.Qte++;
                    if (p.Qte > _produit.QteDisponible)
                        p.Qte = _produit.QteDisponible;
                    existe = true;
                }
            }
            if (!existe)
            {
                _client.Paniers.Add(new Paniers(_produit, 1));
            }
        }

        private void btn_retirer_Click(object sender, EventArgs e)
        {
            BindingList<Paniers> panierASuppr = new BindingList<Paniers>();
            foreach (Paniers p in _client.Paniers)
            {
                if (p.LeProduits.SKU == _produit.SKU)
                {
                    p.Qte--;
                    if (p.Qte <= 0)
                        panierASuppr.Add(p);
                }
            }

            foreach (Paniers p in panierASuppr)
            {
                _client.Paniers.Remove(p);
            }

        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            Form frmDetailProd = new PageCProduitDetail(_parent, _accueil,_client, _produit, _panier);
            frmDetailProd.Visible = true;
            _parent.Visible = false;
        }
    }
}

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
    public partial class CartePaiement : UserControl
    {
        private Clients _client;
        private PageCPaiements _parent;
        private FacturesClients _facture;

        public CartePaiement(PageCPaiements parent, Clients client, FacturesClients facture)
        {
            _facture = facture;
            _parent = parent;
            _client = client;
            InitializeComponent();

            if(_facture.MontantDu <= 0)
            {
                btn_payer.Enabled = false;
            }

            l_total.Text = $"Total: {_facture.SousTotal + _facture.Taxes}$";
            l_taxes.Text = $"Taxes: {_facture.Taxes}$";
            l_soustotal.Text = $"Sous-total: {_facture.SousTotal}$";
            l_idCommande.Text = $"Commande{_facture.Id.ToString()}";
            l_datelimite.Text = $"Date limite: {_facture.DateLimitePaiement.ToString()}";
            L_montantDu.Text = $"Montant dù:{_facture.MontantDu}";
        }

        private async void btn_payer_Click(object sender, EventArgs e)
        {
            ServicesFinances servicesFinances = new ServicesFinances();

            if(await servicesFinances.PayerCommandeClient(_client.Jeton, _facture.Id, _facture.MontantDu))
            {
                MessageBox.Show("Paiement réussi !");
                _parent.Close();
            }
            else
            {
                MessageBox.Show("Paiement échoué!");
            }
        }
    }
}

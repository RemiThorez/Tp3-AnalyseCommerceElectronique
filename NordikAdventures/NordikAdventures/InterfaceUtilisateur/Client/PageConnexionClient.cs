using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NordikAdventures.InterfaceUtilisateur.Client;
using NordikAdventures.Modeles;
using NordikAdventures.Services;
using NordikAdventures.Utilitaires;

namespace NordikAdventures.InterfaceUtilisateur
{
    public partial class PageConnexionClient : Form
    {
        private readonly Form _parent;
        private bool nePasAfficherParent = false;
        public PageConnexionClient(Form parent)
        {
            _parent = parent;
            InitializeComponent();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            _parent.Visible = true;
            this.Close();
        }

        private async void btn_confirmer_Click(object sender, EventArgs e)
        {
            ServicesAuth servicesAuth = new ServicesAuth();
            msg_erreur.Text = "";
            string jeton = await servicesAuth.ConnexionClient(txt_courriel.Text, txt_mdp.Text);

            if (jeton == "")
            {
                msg_erreur.Text = "Identifiants de connexion invalide !";
            }
            else
            {
                ServicesClient servicesClient = new ServicesClient();
                Clients client = await servicesClient.OtenirClient(jeton);

                if (client.ClientID == "")
                {
                    client = await servicesClient.OtenirClient(jeton);
                    if(client.ClientID == "")
                    {
                        client.Nom = "ERREUR_OBTENTION_CLIENT";
                    }
                }
                client.Jeton = jeton;
                Form pageAccueilClient = new PageCAccueilClient(_parent, client);
                pageAccueilClient.Visible = true;
                nePasAfficherParent = true;
                this.Close();
            }
        }

        private void btn_inscri_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form pageInscription = new PageCInscription(this);
            pageInscription.Visible = true;
        }

        private void fermeture(object sender, FormClosingEventArgs e)
        {
            if (!nePasAfficherParent)
            {
                _parent.Visible = true;
            }
        }
    }
}

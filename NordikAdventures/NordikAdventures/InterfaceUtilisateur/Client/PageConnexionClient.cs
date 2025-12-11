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


using NordikAdventures.Utilitaires;

namespace NordikAdventures.InterfaceUtilisateur
{
    public partial class PageConnexionClient : Form
    {
        private readonly Form _parent;
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

        private void btn_confirmer_Click(object sender, EventArgs e)
        {
            msg_erreur.Text = "";
            Clients client = Authentification.ValiderAuthentificationClient(txt_courriel.Text, txt_mdp.Text);

            if (client == null)
            {
                msg_erreur.Text = "Identifiants de connexion invalide !";
            }
            else
            {
                Form pageAccueilClient = new PageCAccueilClient(_parent, client);
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
            _parent.Visible = true;
        }
    }
}

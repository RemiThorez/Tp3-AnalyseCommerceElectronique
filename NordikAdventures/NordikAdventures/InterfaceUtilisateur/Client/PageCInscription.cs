using NordikAdventures.Utilitaires;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NordikAdventures.InterfaceUtilisateur.Client
{
    public partial class PageCInscription : Form
    {
        private readonly Form _parent;
        public PageCInscription(Form parent)
        {
            this._parent = parent;
            InitializeComponent();
        }

        private void fermeture(object sender, FormClosingEventArgs e)
        {
            _parent.Visible = true;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            _parent.Visible = true;
            this.Close();
        }

        private void btn_confirmer_Click(object sender, EventArgs e)
        {
            bool formulaireOk = true;
            msg_erreur.Text = "";
            if (!ValidateurChamps.ValiderChampsCommun(txt_nom.Text))
            {
                formulaireOk = false;
                msg_erreur.Text += "Le nom ne doit pas être vide !\n";
            }

            if (!ValidateurChamps.ValiderCourriel(txt_courriel.Text))
            {
                formulaireOk = false;
                msg_erreur.Text += "Courriel invalide!\n";
            }

            if (txt_mdp.Text != txt_mdp_conf.Text)
            {
                formulaireOk = false;
                msg_erreur.Text += "Les mots de passe ne sont pas pareil !\n";
            }

            if(!ValidateurChamps.ValiderTel(txt_tel.Text))
            {
                formulaireOk = false;
                msg_erreur.Text += "Numéro de téléphone invalide !";
            }

            if (formulaireOk)
            {
                // Envoyer à la base de données et l'ajouter
                // Attendre succès
                // Si succès message de succès et retour à la page d'accueil
                // Si échec afficher message d'échec
            }
        }
    }
}

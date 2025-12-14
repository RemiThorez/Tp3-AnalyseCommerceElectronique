using NordikAdventures.Modeles.DTOs;
using NordikAdventures.Services;
using NordikAdventures.Utilitaires;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NordikAdventures.InterfaceUtilisateur.Client
{
    public partial class PageCInscription : Form
    {
        private readonly Form _parent;
        private bool nePasAfficherParent = false;
        public PageCInscription(Form parent)
        {
            this._parent = parent;
            InitializeComponent();
        }

        private void fermeture(object sender, FormClosingEventArgs e)
        {
            if(!nePasAfficherParent)
            {
                _parent.Visible = true;
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            _parent.Visible = true;
            this.Close();
        }

        private async void btn_confirmer_Click(object sender, EventArgs e)
        {
            bool formulaireOk = true;
            msg_erreur.Text = "";

            if (cb_typeClient.SelectedItem == null)
            {
                formulaireOk = false;
                msg_erreur.Text += "Vous devez choisir un type de client !\n";
            }

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

            if (!ValidateurChamps.ValiderChampsCommun(txt_mdp.Text))
            {
                formulaireOk = false;
                msg_erreur.Text += "Le mot de passe ne doit pas être vide!\n";
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
                CreerClientDTO client = new CreerClientDTO();
                client.tel= txt_tel.Text;
                client.mdp= txt_mdp.Text;
                client.courriel= txt_courriel.Text;
                client.type = cb_typeClient.SelectedItem.ToString();
                client.nom = txt_nom.Text;

                ServicesClient servicesClient = new ServicesClient();

                bool reussi = await servicesClient.CreerClient(client);

                if (reussi)
                {
                    MessageBox.Show("Création du comtpe avec le courriel: " + client.courriel + " réussi !");
                    if(_parent.GetType() ==  typeof(PageConnexionClient))
                    {
                        _parent.Visible = true;
                        this.Close();
                    }
                    else
                    {
                        Form pageConnexion = new PageConnexionClient(_parent);
                        pageConnexion.Visible = true;
                        nePasAfficherParent = true;
                        this.Close();
                    }
                }
            }
        }
    }
}

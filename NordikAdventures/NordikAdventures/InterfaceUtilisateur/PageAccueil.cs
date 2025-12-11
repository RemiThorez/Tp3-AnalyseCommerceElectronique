using NordikAdventures.InterfaceUtilisateur.Client;
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
    public partial class PageAccueil : Form
    {
        public PageAccueil()
        {
            InitializeComponent();
        }

        private void btn_connEmpoye_Click(object sender, EventArgs e)
        {

        }

        private void btn_connClient_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form pageConnClient = new PageConnexionClient(this);
            pageConnClient.Visible = true;
        }

        private void btn_inscriClient_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form pageInsciClient = new PageCInscription(this);
            pageInsciClient.Visible = true;
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

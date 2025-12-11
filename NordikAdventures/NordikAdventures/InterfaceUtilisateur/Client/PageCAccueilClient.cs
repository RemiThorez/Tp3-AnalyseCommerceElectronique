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
    public partial class PageCAccueilClient : Form
    {
        private readonly Form _parent;
        private Clients _client;
        public PageCAccueilClient(Form parent, Clients client)
        {
            this._parent = parent;
            this._client = client;
            InitializeComponent();
        }
    }
}

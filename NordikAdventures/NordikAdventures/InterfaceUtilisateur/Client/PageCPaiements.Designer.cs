namespace NordikAdventures.InterfaceUtilisateur.Client
{
    partial class PageCPaiements
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_profil = new System.Windows.Forms.Button();
            this.btn_retour = new System.Windows.Forms.Button();
            this.list_factClient = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btn_profil
            // 
            this.btn_profil.Location = new System.Drawing.Point(12, 12);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Size = new System.Drawing.Size(72, 23);
            this.btn_profil.TabIndex = 18;
            this.btn_profil.Text = "Profil client";
            this.btn_profil.UseVisualStyleBackColor = true;
            this.btn_profil.Click += new System.EventHandler(this.btn_profil_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(668, 12);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(65, 23);
            this.btn_retour.TabIndex = 17;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // list_factClient
            // 
            this.list_factClient.Location = new System.Drawing.Point(13, 42);
            this.list_factClient.Name = "list_factClient";
            this.list_factClient.Size = new System.Drawing.Size(720, 415);
            this.list_factClient.TabIndex = 19;
            // 
            // PageCPaiements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 469);
            this.Controls.Add(this.list_factClient);
            this.Controls.Add(this.btn_profil);
            this.Controls.Add(this.btn_retour);
            this.Name = "PageCPaiements";
            this.Text = "Facture du client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fermeture);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_profil;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.FlowLayoutPanel list_factClient;
    }
}
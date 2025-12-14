namespace NordikAdventures.InterfaceUtilisateur
{
    partial class PageCDesProduits
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
            this.list_produits = new System.Windows.Forms.ListBox();
            this.btn_panier = new System.Windows.Forms.Button();
            this.pan_produits = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_profil
            // 
            this.btn_profil.Location = new System.Drawing.Point(12, 12);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Size = new System.Drawing.Size(75, 23);
            this.btn_profil.TabIndex = 1;
            this.btn_profil.Text = "Profil client";
            this.btn_profil.UseVisualStyleBackColor = true;
            this.btn_profil.Click += new System.EventHandler(this.btn_profil_Click);
            // 
            // list_produits
            // 
            this.list_produits.FormattingEnabled = true;
            this.list_produits.Location = new System.Drawing.Point(668, 81);
            this.list_produits.Name = "list_produits";
            this.list_produits.Size = new System.Drawing.Size(120, 355);
            this.list_produits.TabIndex = 8;
            // 
            // btn_panier
            // 
            this.btn_panier.Location = new System.Drawing.Point(668, 52);
            this.btn_panier.Name = "btn_panier";
            this.btn_panier.Size = new System.Drawing.Size(120, 23);
            this.btn_panier.TabIndex = 7;
            this.btn_panier.Text = "Panier";
            this.btn_panier.UseVisualStyleBackColor = true;
            this.btn_panier.Click += new System.EventHandler(this.btn_panier_Click);
            // 
            // pan_produits
            // 
            this.pan_produits.AutoScroll = true;
            this.pan_produits.Location = new System.Drawing.Point(12, 52);
            this.pan_produits.Name = "pan_produits";
            this.pan_produits.Size = new System.Drawing.Size(650, 386);
            this.pan_produits.TabIndex = 9;
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(713, 12);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(75, 23);
            this.btn_retour.TabIndex = 10;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // PageCDesProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.pan_produits);
            this.Controls.Add(this.list_produits);
            this.Controls.Add(this.btn_panier);
            this.Controls.Add(this.btn_profil);
            this.Name = "PageCDesProduits";
            this.Text = "Page des produits";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fermeture);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_profil;
        private System.Windows.Forms.ListBox list_produits;
        private System.Windows.Forms.Button btn_panier;
        private System.Windows.Forms.FlowLayoutPanel pan_produits;
        private System.Windows.Forms.Button btn_retour;
    }
}
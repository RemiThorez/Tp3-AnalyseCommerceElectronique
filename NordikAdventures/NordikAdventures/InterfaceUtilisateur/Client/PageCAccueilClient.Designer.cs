namespace NordikAdventures.InterfaceUtilisateur.Client
{
    partial class PageCAccueilClient
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
            this.btn_deco = new System.Windows.Forms.Button();
            this.txt_nom = new System.Windows.Forms.Label();
            this.btn_produit = new System.Windows.Forms.Button();
            this.btn_panier = new System.Windows.Forms.Button();
            this.list_produits = new System.Windows.Forms.ListBox();
            this.btn_paiement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_deco
            // 
            this.btn_deco.Location = new System.Drawing.Point(204, 12);
            this.btn_deco.Name = "btn_deco";
            this.btn_deco.Size = new System.Drawing.Size(81, 23);
            this.btn_deco.TabIndex = 0;
            this.btn_deco.Text = "Déconnexion";
            this.btn_deco.UseVisualStyleBackColor = true;
            this.btn_deco.Click += new System.EventHandler(this.btn_deco_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.AutoSize = true;
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nom.Location = new System.Drawing.Point(12, 12);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(0, 20);
            this.txt_nom.TabIndex = 1;
            // 
            // btn_produit
            // 
            this.btn_produit.Location = new System.Drawing.Point(15, 80);
            this.btn_produit.Name = "btn_produit";
            this.btn_produit.Size = new System.Drawing.Size(144, 124);
            this.btn_produit.TabIndex = 2;
            this.btn_produit.Text = "Voir les produits";
            this.btn_produit.UseVisualStyleBackColor = true;
            this.btn_produit.Click += new System.EventHandler(this.btn_produit_Click);
            // 
            // btn_panier
            // 
            this.btn_panier.Location = new System.Drawing.Point(165, 80);
            this.btn_panier.Name = "btn_panier";
            this.btn_panier.Size = new System.Drawing.Size(120, 23);
            this.btn_panier.TabIndex = 3;
            this.btn_panier.Text = "Panier";
            this.btn_panier.UseVisualStyleBackColor = true;
            this.btn_panier.Click += new System.EventHandler(this.btn_panier_Click);
            // 
            // list_produits
            // 
            this.list_produits.FormattingEnabled = true;
            this.list_produits.Location = new System.Drawing.Point(165, 109);
            this.list_produits.Name = "list_produits";
            this.list_produits.Size = new System.Drawing.Size(120, 95);
            this.list_produits.TabIndex = 4;
            // 
            // btn_paiement
            // 
            this.btn_paiement.Location = new System.Drawing.Point(165, 51);
            this.btn_paiement.Name = "btn_paiement";
            this.btn_paiement.Size = new System.Drawing.Size(120, 23);
            this.btn_paiement.TabIndex = 5;
            this.btn_paiement.Text = "Paiements";
            this.btn_paiement.UseVisualStyleBackColor = true;
            this.btn_paiement.Click += new System.EventHandler(this.btn_paiement_Click);
            // 
            // PageCAccueilClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 223);
            this.Controls.Add(this.btn_paiement);
            this.Controls.Add(this.list_produits);
            this.Controls.Add(this.btn_panier);
            this.Controls.Add(this.btn_produit);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.btn_deco);
            this.Name = "PageCAccueilClient";
            this.Text = "Page d\'accueil client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fermeture);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_deco;
        private System.Windows.Forms.Label txt_nom;
        private System.Windows.Forms.Button btn_produit;
        private System.Windows.Forms.Button btn_panier;
        private System.Windows.Forms.ListBox list_produits;
        private System.Windows.Forms.Button btn_paiement;
    }
}
namespace NordikAdventures.InterfaceUtilisateur
{
    partial class PageCProduitDetail
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l_nom = new System.Windows.Forms.Label();
            this.l_SKU = new System.Windows.Forms.Label();
            this.l_categorie = new System.Windows.Forms.Label();
            this.l_fournisseur = new System.Windows.Forms.Label();
            this.btn_ajoutProd = new System.Windows.Forms.Button();
            this.btn_retraitProd = new System.Windows.Forms.Button();
            this.nb_qteAcheter = new System.Windows.Forms.NumericUpDown();
            this.l_prixVente = new System.Windows.Forms.Label();
            this.btn_supprimerPanier = new System.Windows.Forms.Button();
            this.btn_retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_qteAcheter)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_profil
            // 
            this.btn_profil.Location = new System.Drawing.Point(12, 12);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Size = new System.Drawing.Size(75, 23);
            this.btn_profil.TabIndex = 0;
            this.btn_profil.Text = "Profil client";
            this.btn_profil.UseVisualStyleBackColor = true;
            this.btn_profil.Click += new System.EventHandler(this.btn_profil_Click);
            // 
            // list_produits
            // 
            this.list_produits.FormattingEnabled = true;
            this.list_produits.Location = new System.Drawing.Point(290, 95);
            this.list_produits.Name = "list_produits";
            this.list_produits.Size = new System.Drawing.Size(120, 134);
            this.list_produits.TabIndex = 6;
            // 
            // btn_panier
            // 
            this.btn_panier.Location = new System.Drawing.Point(290, 66);
            this.btn_panier.Name = "btn_panier";
            this.btn_panier.Size = new System.Drawing.Size(120, 23);
            this.btn_panier.TabIndex = 5;
            this.btn_panier.Text = "Panier";
            this.btn_panier.UseVisualStyleBackColor = true;
            this.btn_panier.Click += new System.EventHandler(this.btn_panier_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 115);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // l_nom
            // 
            this.l_nom.AutoSize = true;
            this.l_nom.Location = new System.Drawing.Point(157, 66);
            this.l_nom.Name = "l_nom";
            this.l_nom.Size = new System.Drawing.Size(27, 13);
            this.l_nom.TabIndex = 8;
            this.l_nom.Text = "nom";
            // 
            // l_SKU
            // 
            this.l_SKU.AutoSize = true;
            this.l_SKU.Location = new System.Drawing.Point(157, 95);
            this.l_SKU.Name = "l_SKU";
            this.l_SKU.Size = new System.Drawing.Size(29, 13);
            this.l_SKU.TabIndex = 9;
            this.l_SKU.Text = "SKU";
            // 
            // l_categorie
            // 
            this.l_categorie.AutoSize = true;
            this.l_categorie.Location = new System.Drawing.Point(159, 124);
            this.l_categorie.Name = "l_categorie";
            this.l_categorie.Size = new System.Drawing.Size(51, 13);
            this.l_categorie.TabIndex = 10;
            this.l_categorie.Text = "categorie";
            // 
            // l_fournisseur
            // 
            this.l_fournisseur.AutoSize = true;
            this.l_fournisseur.Location = new System.Drawing.Point(159, 146);
            this.l_fournisseur.Name = "l_fournisseur";
            this.l_fournisseur.Size = new System.Drawing.Size(58, 13);
            this.l_fournisseur.TabIndex = 11;
            this.l_fournisseur.Text = "fournisseur";
            // 
            // btn_ajoutProd
            // 
            this.btn_ajoutProd.Location = new System.Drawing.Point(12, 188);
            this.btn_ajoutProd.Name = "btn_ajoutProd";
            this.btn_ajoutProd.Size = new System.Drawing.Size(99, 23);
            this.btn_ajoutProd.TabIndex = 12;
            this.btn_ajoutProd.Text = "Ajouter au panier";
            this.btn_ajoutProd.UseVisualStyleBackColor = true;
            this.btn_ajoutProd.Click += new System.EventHandler(this.btn_ajoutProd_Click);
            // 
            // btn_retraitProd
            // 
            this.btn_retraitProd.Location = new System.Drawing.Point(112, 188);
            this.btn_retraitProd.Name = "btn_retraitProd";
            this.btn_retraitProd.Size = new System.Drawing.Size(98, 23);
            this.btn_retraitProd.TabIndex = 13;
            this.btn_retraitProd.Text = "Retirer du panier";
            this.btn_retraitProd.UseVisualStyleBackColor = true;
            this.btn_retraitProd.Click += new System.EventHandler(this.btn_retraitProd_Click);
            // 
            // nb_qteAcheter
            // 
            this.nb_qteAcheter.Location = new System.Drawing.Point(12, 217);
            this.nb_qteAcheter.Name = "nb_qteAcheter";
            this.nb_qteAcheter.Size = new System.Drawing.Size(196, 20);
            this.nb_qteAcheter.TabIndex = 15;
            // 
            // l_prixVente
            // 
            this.l_prixVente.AutoSize = true;
            this.l_prixVente.Location = new System.Drawing.Point(159, 168);
            this.l_prixVente.Name = "l_prixVente";
            this.l_prixVente.Size = new System.Drawing.Size(51, 13);
            this.l_prixVente.TabIndex = 16;
            this.l_prixVente.Text = "prixVente";
            // 
            // btn_supprimerPanier
            // 
            this.btn_supprimerPanier.Location = new System.Drawing.Point(216, 188);
            this.btn_supprimerPanier.Name = "btn_supprimerPanier";
            this.btn_supprimerPanier.Size = new System.Drawing.Size(68, 49);
            this.btn_supprimerPanier.TabIndex = 17;
            this.btn_supprimerPanier.Text = "Supprimer du panier";
            this.btn_supprimerPanier.UseVisualStyleBackColor = true;
            this.btn_supprimerPanier.Click += new System.EventHandler(this.btn_supprimerPanier_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(335, 12);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(75, 23);
            this.btn_retour.TabIndex = 18;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // PageCProduitDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 245);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.btn_supprimerPanier);
            this.Controls.Add(this.l_prixVente);
            this.Controls.Add(this.nb_qteAcheter);
            this.Controls.Add(this.btn_retraitProd);
            this.Controls.Add(this.btn_ajoutProd);
            this.Controls.Add(this.l_fournisseur);
            this.Controls.Add(this.l_categorie);
            this.Controls.Add(this.l_SKU);
            this.Controls.Add(this.l_nom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.list_produits);
            this.Controls.Add(this.btn_panier);
            this.Controls.Add(this.btn_profil);
            this.Name = "PageCProduitDetail";
            this.Text = "Page détails d\'un produit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fermeture);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_qteAcheter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_profil;
        private System.Windows.Forms.ListBox list_produits;
        private System.Windows.Forms.Button btn_panier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_nom;
        private System.Windows.Forms.Label l_SKU;
        private System.Windows.Forms.Label l_categorie;
        private System.Windows.Forms.Label l_fournisseur;
        private System.Windows.Forms.Button btn_ajoutProd;
        private System.Windows.Forms.Button btn_retraitProd;
        private System.Windows.Forms.NumericUpDown nb_qteAcheter;
        private System.Windows.Forms.Label l_prixVente;
        private System.Windows.Forms.Button btn_supprimerPanier;
        private System.Windows.Forms.Button btn_retour;
    }
}
namespace NordikAdventures.InterfaceUtilisateur.Client
{
    partial class PageCPanier
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
            this.list_produits = new System.Windows.Forms.ListBox();
            this.btn_retour = new System.Windows.Forms.Button();
            this.l_soustotal = new System.Windows.Forms.Label();
            this.l_taxes = new System.Windows.Forms.Label();
            this.l_total = new System.Windows.Forms.Label();
            this.btn_confirmer = new System.Windows.Forms.Button();
            this.btn_profil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_produits
            // 
            this.list_produits.FormattingEnabled = true;
            this.list_produits.Location = new System.Drawing.Point(143, 44);
            this.list_produits.Name = "list_produits";
            this.list_produits.Size = new System.Drawing.Size(120, 108);
            this.list_produits.TabIndex = 10;
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(198, 12);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(65, 23);
            this.btn_retour.TabIndex = 11;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // l_soustotal
            // 
            this.l_soustotal.AutoSize = true;
            this.l_soustotal.Location = new System.Drawing.Point(12, 57);
            this.l_soustotal.Name = "l_soustotal";
            this.l_soustotal.Size = new System.Drawing.Size(49, 13);
            this.l_soustotal.TabIndex = 12;
            this.l_soustotal.Text = "soustotal";
            // 
            // l_taxes
            // 
            this.l_taxes.AutoSize = true;
            this.l_taxes.Location = new System.Drawing.Point(12, 79);
            this.l_taxes.Name = "l_taxes";
            this.l_taxes.Size = new System.Drawing.Size(32, 13);
            this.l_taxes.TabIndex = 13;
            this.l_taxes.Text = "taxes";
            // 
            // l_total
            // 
            this.l_total.AutoSize = true;
            this.l_total.Location = new System.Drawing.Point(12, 101);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(27, 13);
            this.l_total.TabIndex = 14;
            this.l_total.Text = "total";
            // 
            // btn_confirmer
            // 
            this.btn_confirmer.Location = new System.Drawing.Point(12, 129);
            this.btn_confirmer.Name = "btn_confirmer";
            this.btn_confirmer.Size = new System.Drawing.Size(125, 23);
            this.btn_confirmer.TabIndex = 15;
            this.btn_confirmer.Text = "Confirmer";
            this.btn_confirmer.UseVisualStyleBackColor = true;
            this.btn_confirmer.Click += new System.EventHandler(this.btn_confirmer_Click);
            // 
            // btn_profil
            // 
            this.btn_profil.Location = new System.Drawing.Point(15, 12);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Size = new System.Drawing.Size(72, 23);
            this.btn_profil.TabIndex = 16;
            this.btn_profil.Text = "Profil client";
            this.btn_profil.UseVisualStyleBackColor = true;
            this.btn_profil.Click += new System.EventHandler(this.btn_profil_Click);
            // 
            // PageCPanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 161);
            this.Controls.Add(this.btn_profil);
            this.Controls.Add(this.btn_confirmer);
            this.Controls.Add(this.l_total);
            this.Controls.Add(this.l_taxes);
            this.Controls.Add(this.l_soustotal);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.list_produits);
            this.Name = "PageCPanier";
            this.Text = "Page confirmation panier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fermeture);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_produits;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.Label l_soustotal;
        private System.Windows.Forms.Label l_taxes;
        private System.Windows.Forms.Label l_total;
        private System.Windows.Forms.Button btn_confirmer;
        private System.Windows.Forms.Button btn_profil;
    }
}
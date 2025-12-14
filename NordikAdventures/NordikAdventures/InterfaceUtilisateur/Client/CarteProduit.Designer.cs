namespace NordikAdventures.InterfaceUtilisateur.Client
{
    partial class CarteProduit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_nom = new System.Windows.Forms.Label();
            this.l_cat = new System.Windows.Forms.Label();
            this.l_fournisseur = new System.Windows.Forms.Label();
            this.l_SKU = new System.Windows.Forms.Label();
            this.l_prix = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_retirer = new System.Windows.Forms.Button();
            this.btn_detail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_nom
            // 
            this.l_nom.AutoSize = true;
            this.l_nom.Location = new System.Drawing.Point(4, 4);
            this.l_nom.Name = "l_nom";
            this.l_nom.Size = new System.Drawing.Size(35, 13);
            this.l_nom.TabIndex = 0;
            this.l_nom.Text = "l_nom";
            // 
            // l_cat
            // 
            this.l_cat.AutoSize = true;
            this.l_cat.Location = new System.Drawing.Point(124, 4);
            this.l_cat.Name = "l_cat";
            this.l_cat.Size = new System.Drawing.Size(30, 13);
            this.l_cat.TabIndex = 1;
            this.l_cat.Text = "l_cat";
            // 
            // l_fournisseur
            // 
            this.l_fournisseur.AutoSize = true;
            this.l_fournisseur.Location = new System.Drawing.Point(4, 17);
            this.l_fournisseur.Name = "l_fournisseur";
            this.l_fournisseur.Size = new System.Drawing.Size(66, 13);
            this.l_fournisseur.TabIndex = 2;
            this.l_fournisseur.Text = "l_fournisseur";
            // 
            // l_SKU
            // 
            this.l_SKU.AutoSize = true;
            this.l_SKU.Location = new System.Drawing.Point(4, 43);
            this.l_SKU.Name = "l_SKU";
            this.l_SKU.Size = new System.Drawing.Size(37, 13);
            this.l_SKU.TabIndex = 3;
            this.l_SKU.Text = "l_SKU";
            // 
            // l_prix
            // 
            this.l_prix.AutoSize = true;
            this.l_prix.Location = new System.Drawing.Point(4, 67);
            this.l_prix.Name = "l_prix";
            this.l_prix.Size = new System.Drawing.Size(31, 13);
            this.l_prix.TabIndex = 4;
            this.l_prix.Text = "l_prix";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(3, 83);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 5;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_retirer
            // 
            this.btn_retirer.Location = new System.Drawing.Point(84, 83);
            this.btn_retirer.Name = "btn_retirer";
            this.btn_retirer.Size = new System.Drawing.Size(75, 23);
            this.btn_retirer.TabIndex = 6;
            this.btn_retirer.Text = "Retirer";
            this.btn_retirer.UseVisualStyleBackColor = true;
            this.btn_retirer.Click += new System.EventHandler(this.btn_retirer_Click);
            // 
            // btn_detail
            // 
            this.btn_detail.Location = new System.Drawing.Point(165, 83);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(75, 23);
            this.btn_detail.TabIndex = 7;
            this.btn_detail.Text = "Détails";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // CarteProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.btn_retirer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.l_prix);
            this.Controls.Add(this.l_SKU);
            this.Controls.Add(this.l_fournisseur);
            this.Controls.Add(this.l_cat);
            this.Controls.Add(this.l_nom);
            this.Name = "CarteProduit";
            this.Size = new System.Drawing.Size(245, 107);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_nom;
        private System.Windows.Forms.Label l_cat;
        private System.Windows.Forms.Label l_fournisseur;
        private System.Windows.Forms.Label l_SKU;
        private System.Windows.Forms.Label l_prix;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_retirer;
        private System.Windows.Forms.Button btn_detail;
    }
}

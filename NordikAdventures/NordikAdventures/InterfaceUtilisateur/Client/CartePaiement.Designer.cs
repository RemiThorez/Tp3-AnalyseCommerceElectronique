namespace NordikAdventures.InterfaceUtilisateur.Client
{
    partial class CartePaiement
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
            this.l_total = new System.Windows.Forms.Label();
            this.l_taxes = new System.Windows.Forms.Label();
            this.l_soustotal = new System.Windows.Forms.Label();
            this.l_idCommande = new System.Windows.Forms.Label();
            this.L_montantDu = new System.Windows.Forms.Label();
            this.btn_payer = new System.Windows.Forms.Button();
            this.l_datelimite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_total
            // 
            this.l_total.AutoSize = true;
            this.l_total.Location = new System.Drawing.Point(123, 53);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(27, 13);
            this.l_total.TabIndex = 17;
            this.l_total.Text = "total";
            // 
            // l_taxes
            // 
            this.l_taxes.AutoSize = true;
            this.l_taxes.Location = new System.Drawing.Point(123, 31);
            this.l_taxes.Name = "l_taxes";
            this.l_taxes.Size = new System.Drawing.Size(32, 13);
            this.l_taxes.TabIndex = 16;
            this.l_taxes.Text = "taxes";
            // 
            // l_soustotal
            // 
            this.l_soustotal.AutoSize = true;
            this.l_soustotal.Location = new System.Drawing.Point(123, 9);
            this.l_soustotal.Name = "l_soustotal";
            this.l_soustotal.Size = new System.Drawing.Size(49, 13);
            this.l_soustotal.TabIndex = 15;
            this.l_soustotal.Text = "soustotal";
            // 
            // l_idCommande
            // 
            this.l_idCommande.AutoSize = true;
            this.l_idCommande.Location = new System.Drawing.Point(3, 9);
            this.l_idCommande.Name = "l_idCommande";
            this.l_idCommande.Size = new System.Drawing.Size(99, 13);
            this.l_idCommande.TabIndex = 18;
            this.l_idCommande.Text = "Numéro commande";
            // 
            // L_montantDu
            // 
            this.L_montantDu.AutoSize = true;
            this.L_montantDu.Location = new System.Drawing.Point(3, 53);
            this.L_montantDu.Name = "L_montantDu";
            this.L_montantDu.Size = new System.Drawing.Size(61, 13);
            this.L_montantDu.TabIndex = 19;
            this.L_montantDu.Text = "Montant dù";
            // 
            // btn_payer
            // 
            this.btn_payer.Location = new System.Drawing.Point(6, 69);
            this.btn_payer.Name = "btn_payer";
            this.btn_payer.Size = new System.Drawing.Size(96, 23);
            this.btn_payer.TabIndex = 20;
            this.btn_payer.Text = "Payer";
            this.btn_payer.UseVisualStyleBackColor = true;
            this.btn_payer.Click += new System.EventHandler(this.btn_payer_Click);
            // 
            // l_datelimite
            // 
            this.l_datelimite.AutoSize = true;
            this.l_datelimite.Location = new System.Drawing.Point(123, 74);
            this.l_datelimite.Name = "l_datelimite";
            this.l_datelimite.Size = new System.Drawing.Size(51, 13);
            this.l_datelimite.TabIndex = 21;
            this.l_datelimite.Text = "datelimite";
            // 
            // CartePaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.l_datelimite);
            this.Controls.Add(this.btn_payer);
            this.Controls.Add(this.L_montantDu);
            this.Controls.Add(this.l_idCommande);
            this.Controls.Add(this.l_total);
            this.Controls.Add(this.l_taxes);
            this.Controls.Add(this.l_soustotal);
            this.Name = "CartePaiement";
            this.Size = new System.Drawing.Size(324, 95);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_total;
        private System.Windows.Forms.Label l_taxes;
        private System.Windows.Forms.Label l_soustotal;
        private System.Windows.Forms.Label l_idCommande;
        private System.Windows.Forms.Label L_montantDu;
        private System.Windows.Forms.Button btn_payer;
        private System.Windows.Forms.Label l_datelimite;
    }
}

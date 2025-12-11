namespace NordikAdventures.InterfaceUtilisateur
{
    partial class PageConnexionClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_inscri = new System.Windows.Forms.Button();
            this.btn_confirmer = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.txt_courriel = new System.Windows.Forms.TextBox();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msg_erreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Courriel:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe:*";
            // 
            // btn_inscri
            // 
            this.btn_inscri.Location = new System.Drawing.Point(44, 198);
            this.btn_inscri.Name = "btn_inscri";
            this.btn_inscri.Size = new System.Drawing.Size(224, 23);
            this.btn_inscri.TabIndex = 3;
            this.btn_inscri.Text = "Inscription";
            this.btn_inscri.UseVisualStyleBackColor = true;
            this.btn_inscri.Click += new System.EventHandler(this.btn_inscri_Click);
            // 
            // btn_confirmer
            // 
            this.btn_confirmer.Location = new System.Drawing.Point(44, 256);
            this.btn_confirmer.Name = "btn_confirmer";
            this.btn_confirmer.Size = new System.Drawing.Size(224, 23);
            this.btn_confirmer.TabIndex = 14;
            this.btn_confirmer.Text = "Confirmer";
            this.btn_confirmer.UseVisualStyleBackColor = true;
            this.btn_confirmer.Click += new System.EventHandler(this.btn_confirmer_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(44, 227);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(224, 23);
            this.btn_annuler.TabIndex = 13;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // txt_courriel
            // 
            this.txt_courriel.Location = new System.Drawing.Point(44, 86);
            this.txt_courriel.Name = "txt_courriel";
            this.txt_courriel.Size = new System.Drawing.Size(224, 20);
            this.txt_courriel.TabIndex = 15;
            // 
            // txt_mdp
            // 
            this.txt_mdp.Location = new System.Drawing.Point(44, 143);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.PasswordChar = '*';
            this.txt_mdp.Size = new System.Drawing.Size(224, 20);
            this.txt_mdp.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(85, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Connexion";
            // 
            // msg_erreur
            // 
            this.msg_erreur.AutoSize = true;
            this.msg_erreur.ForeColor = System.Drawing.Color.Red;
            this.msg_erreur.Location = new System.Drawing.Point(41, 166);
            this.msg_erreur.Name = "msg_erreur";
            this.msg_erreur.Size = new System.Drawing.Size(0, 13);
            this.msg_erreur.TabIndex = 18;
            // 
            // PageConnexionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 307);
            this.Controls.Add(this.msg_erreur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.txt_courriel);
            this.Controls.Add(this.btn_confirmer);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_inscri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PageConnexionClient";
            this.Text = "Connexion client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fermeture);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_inscri;
        private System.Windows.Forms.Button btn_confirmer;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.TextBox txt_courriel;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label msg_erreur;
    }
}
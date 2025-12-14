namespace NordikAdventures.InterfaceUtilisateur.Client
{
    partial class PageCInscription
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
            this.btn_annuler = new System.Windows.Forms.Button();
            this.txt_mdp_conf = new System.Windows.Forms.TextBox();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_courriel = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_confirmer = new System.Windows.Forms.Button();
            this.msg_erreur = new System.Windows.Forms.Label();
            this.cb_typeClient = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(25, 304);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(224, 23);
            this.btn_annuler.TabIndex = 0;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // txt_mdp_conf
            // 
            this.txt_mdp_conf.Location = new System.Drawing.Point(91, 171);
            this.txt_mdp_conf.MaxLength = 64;
            this.txt_mdp_conf.Name = "txt_mdp_conf";
            this.txt_mdp_conf.PasswordChar = '*';
            this.txt_mdp_conf.Size = new System.Drawing.Size(158, 20);
            this.txt_mdp_conf.TabIndex = 1;
            // 
            // txt_mdp
            // 
            this.txt_mdp.Location = new System.Drawing.Point(91, 145);
            this.txt_mdp.MaxLength = 64;
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.PasswordChar = '*';
            this.txt_mdp.Size = new System.Drawing.Size(158, 20);
            this.txt_mdp.TabIndex = 2;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(91, 119);
            this.txt_tel.MaxLength = 12;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(158, 20);
            this.txt_tel.TabIndex = 3;
            // 
            // txt_courriel
            // 
            this.txt_courriel.Location = new System.Drawing.Point(91, 93);
            this.txt_courriel.MaxLength = 64;
            this.txt_courriel.Name = "txt_courriel";
            this.txt_courriel.Size = new System.Drawing.Size(158, 20);
            this.txt_courriel.TabIndex = 4;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(91, 67);
            this.txt_nom.MaxLength = 45;
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(158, 20);
            this.txt_nom.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Courriel:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Téléphone:*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mdp:*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mdp:*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "Inscription Client";
            // 
            // btn_confirmer
            // 
            this.btn_confirmer.Location = new System.Drawing.Point(25, 333);
            this.btn_confirmer.Name = "btn_confirmer";
            this.btn_confirmer.Size = new System.Drawing.Size(224, 23);
            this.btn_confirmer.TabIndex = 12;
            this.btn_confirmer.Text = "Confirmer";
            this.btn_confirmer.UseVisualStyleBackColor = true;
            this.btn_confirmer.Click += new System.EventHandler(this.btn_confirmer_Click);
            // 
            // msg_erreur
            // 
            this.msg_erreur.AutoSize = true;
            this.msg_erreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.msg_erreur.ForeColor = System.Drawing.Color.Red;
            this.msg_erreur.Location = new System.Drawing.Point(22, 225);
            this.msg_erreur.Name = "msg_erreur";
            this.msg_erreur.Size = new System.Drawing.Size(0, 13);
            this.msg_erreur.TabIndex = 13;
            // 
            // cb_typeClient
            // 
            this.cb_typeClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typeClient.FormattingEnabled = true;
            this.cb_typeClient.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cb_typeClient.Items.AddRange(new object[] {
            "Particulier",
            "Entreprise"});
            this.cb_typeClient.Location = new System.Drawing.Point(28, 197);
            this.cb_typeClient.Name = "cb_typeClient";
            this.cb_typeClient.Size = new System.Drawing.Size(221, 21);
            this.cb_typeClient.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "*";
            // 
            // PageCInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 367);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_typeClient);
            this.Controls.Add(this.msg_erreur);
            this.Controls.Add(this.btn_confirmer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_courriel);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.txt_mdp_conf);
            this.Controls.Add(this.btn_annuler);
            this.Name = "PageCInscription";
            this.Text = "Page d\'inscription du client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fermeture);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.TextBox txt_mdp_conf;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_courriel;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_confirmer;
        private System.Windows.Forms.Label msg_erreur;
        private System.Windows.Forms.ComboBox cb_typeClient;
        private System.Windows.Forms.Label label7;
    }
}
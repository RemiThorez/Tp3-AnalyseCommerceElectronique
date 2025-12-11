namespace NordikAdventures.InterfaceUtilisateur
{
    partial class PageAccueil
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
            this.btn_connClient = new System.Windows.Forms.Button();
            this.btn_inscriClient = new System.Windows.Forms.Button();
            this.btn_connEmpoye = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_connClient
            // 
            this.btn_connClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_connClient.Location = new System.Drawing.Point(235, 92);
            this.btn_connClient.Name = "btn_connClient";
            this.btn_connClient.Size = new System.Drawing.Size(107, 55);
            this.btn_connClient.TabIndex = 0;
            this.btn_connClient.Text = "Connexion Client";
            this.btn_connClient.UseVisualStyleBackColor = true;
            this.btn_connClient.Click += new System.EventHandler(this.btn_connClient_Click);
            // 
            // btn_inscriClient
            // 
            this.btn_inscriClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_inscriClient.Location = new System.Drawing.Point(235, 153);
            this.btn_inscriClient.Name = "btn_inscriClient";
            this.btn_inscriClient.Size = new System.Drawing.Size(107, 43);
            this.btn_inscriClient.TabIndex = 1;
            this.btn_inscriClient.Text = "Inscription Client";
            this.btn_inscriClient.UseVisualStyleBackColor = true;
            this.btn_inscriClient.Click += new System.EventHandler(this.btn_inscriClient_Click);
            // 
            // btn_connEmpoye
            // 
            this.btn_connEmpoye.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_connEmpoye.Location = new System.Drawing.Point(16, 102);
            this.btn_connEmpoye.Name = "btn_connEmpoye";
            this.btn_connEmpoye.Size = new System.Drawing.Size(132, 67);
            this.btn_connEmpoye.TabIndex = 2;
            this.btn_connEmpoye.Text = "Connexion Employé";
            this.btn_connEmpoye.UseVisualStyleBackColor = true;
            this.btn_connEmpoye.Click += new System.EventHandler(this.btn_connEmpoye_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nordik Adventures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Espace Employés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(231, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Espace Clients";
            // 
            // btn_quitter
            // 
            this.btn_quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_quitter.Location = new System.Drawing.Point(12, 266);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(360, 23);
            this.btn_quitter.TabIndex = 6;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // PageAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 301);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_connEmpoye);
            this.Controls.Add(this.btn_inscriClient);
            this.Controls.Add(this.btn_connClient);
            this.Name = "PageAccueil";
            this.Text = "Bienvenue chez Nordik Adventures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connClient;
        private System.Windows.Forms.Button btn_inscriClient;
        private System.Windows.Forms.Button btn_connEmpoye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_quitter;
    }
}
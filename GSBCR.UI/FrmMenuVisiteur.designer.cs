namespace GSBCR.UI
{
    partial class FrmMenuVisiteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuVisiteur));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mesRapportsEnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesRapportsValidésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesMedicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesPraticiensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesDonnéesPersonnellesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierConsulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerMonMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maRégionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportsNonConsultésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionÉquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauVisiteurDéléguéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion rapports de visite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(445, 351);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(188, 33);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesRapportsEnCoursToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.mesDonnéesPersonnellesToolStripMenuItem,
            this.maRégionToolStripMenuItem,
            this.monSecteurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mesRapportsEnCoursToolStripMenuItem
            // 
            this.mesRapportsEnCoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.mesRapportsEnCoursToolStripMenuItem.Name = "mesRapportsEnCoursToolStripMenuItem";
            this.mesRapportsEnCoursToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.mesRapportsEnCoursToolStripMenuItem.Text = "Mes rapports en cours";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.modifierToolStripMenuItem.Text = "Modifier / Consulter";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesRapportsValidésToolStripMenuItem,
            this.lesMedicamentsToolStripMenuItem,
            this.lesPraticiensToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // mesRapportsValidésToolStripMenuItem
            // 
            this.mesRapportsValidésToolStripMenuItem.Name = "mesRapportsValidésToolStripMenuItem";
            this.mesRapportsValidésToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.mesRapportsValidésToolStripMenuItem.Text = "Mes rapports validés";
            // 
            // lesMedicamentsToolStripMenuItem
            // 
            this.lesMedicamentsToolStripMenuItem.Name = "lesMedicamentsToolStripMenuItem";
            this.lesMedicamentsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.lesMedicamentsToolStripMenuItem.Text = "Les medicaments";
            this.lesMedicamentsToolStripMenuItem.Click += new System.EventHandler(this.lesMedicamentsToolStripMenuItem_Click);
            // 
            // lesPraticiensToolStripMenuItem
            // 
            this.lesPraticiensToolStripMenuItem.Name = "lesPraticiensToolStripMenuItem";
            this.lesPraticiensToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.lesPraticiensToolStripMenuItem.Text = "Les praticiens";
            this.lesPraticiensToolStripMenuItem.Click += new System.EventHandler(this.lesPraticiensToolStripMenuItem_Click);
            // 
            // mesDonnéesPersonnellesToolStripMenuItem
            // 
            this.mesDonnéesPersonnellesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierConsulterToolStripMenuItem,
            this.changerMonMotDePasseToolStripMenuItem});
            this.mesDonnéesPersonnellesToolStripMenuItem.Name = "mesDonnéesPersonnellesToolStripMenuItem";
            this.mesDonnéesPersonnellesToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.mesDonnéesPersonnellesToolStripMenuItem.Text = "Mes données personnelles";
            // 
            // modifierConsulterToolStripMenuItem
            // 
            this.modifierConsulterToolStripMenuItem.Name = "modifierConsulterToolStripMenuItem";
            this.modifierConsulterToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.modifierConsulterToolStripMenuItem.Text = "Modifier / Consulter";
            this.modifierConsulterToolStripMenuItem.Click += new System.EventHandler(this.modifierConsulterToolStripMenuItem_Click);
            // 
            // changerMonMotDePasseToolStripMenuItem
            // 
            this.changerMonMotDePasseToolStripMenuItem.Name = "changerMonMotDePasseToolStripMenuItem";
            this.changerMonMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.changerMonMotDePasseToolStripMenuItem.Text = "Changer mon mot de passe";
            this.changerMonMotDePasseToolStripMenuItem.Click += new System.EventHandler(this.changerMonMotDePasseToolStripMenuItem_Click_1);
            // 
            // maRégionToolStripMenuItem
            // 
            this.maRégionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportsNonConsultésToolStripMenuItem,
            this.listeDesVisiteursToolStripMenuItem,
            this.rToolStripMenuItem});
            this.maRégionToolStripMenuItem.Enabled = false;
            this.maRégionToolStripMenuItem.Name = "maRégionToolStripMenuItem";
            this.maRégionToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.maRégionToolStripMenuItem.Text = "Ma région";
            this.maRégionToolStripMenuItem.Visible = false;
            // 
            // rapportsNonConsultésToolStripMenuItem
            // 
            this.rapportsNonConsultésToolStripMenuItem.Name = "rapportsNonConsultésToolStripMenuItem";
            this.rapportsNonConsultésToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.rapportsNonConsultésToolStripMenuItem.Text = "Nouveaux rapports région";
            // 
            // listeDesVisiteursToolStripMenuItem
            // 
            this.listeDesVisiteursToolStripMenuItem.Name = "listeDesVisiteursToolStripMenuItem";
            this.listeDesVisiteursToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.listeDesVisiteursToolStripMenuItem.Text = "Liste des visiteurs région";
            this.listeDesVisiteursToolStripMenuItem.Click += new System.EventHandler(this.listeDesVisiteursToolStripMenuItem_Click);
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.rToolStripMenuItem.Text = "Rapports archivés région";
            // 
            // monSecteurToolStripMenuItem
            // 
            this.monSecteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionÉquipeToolStripMenuItem,
            this.statistiquesSecteurToolStripMenuItem,
            this.nouveauVisiteurDéléguéToolStripMenuItem});
            this.monSecteurToolStripMenuItem.Enabled = false;
            this.monSecteurToolStripMenuItem.Name = "monSecteurToolStripMenuItem";
            this.monSecteurToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.monSecteurToolStripMenuItem.Text = "Mon secteur";
            this.monSecteurToolStripMenuItem.Visible = false;
            // 
            // gestionÉquipeToolStripMenuItem
            // 
            this.gestionÉquipeToolStripMenuItem.Name = "gestionÉquipeToolStripMenuItem";
            this.gestionÉquipeToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.gestionÉquipeToolStripMenuItem.Text = "Gestion équipe";
            // 
            // statistiquesSecteurToolStripMenuItem
            // 
            this.statistiquesSecteurToolStripMenuItem.Name = "statistiquesSecteurToolStripMenuItem";
            this.statistiquesSecteurToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.statistiquesSecteurToolStripMenuItem.Text = "Statistiques secteur";
            // 
            // nouveauVisiteurDéléguéToolStripMenuItem
            // 
            this.nouveauVisiteurDéléguéToolStripMenuItem.Name = "nouveauVisiteurDéléguéToolStripMenuItem";
            this.nouveauVisiteurDéléguéToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.nouveauVisiteurDéléguéToolStripMenuItem.Text = "Nouveau visiteur / délégué";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 227);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(279, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 9;
            // 
            // FrmMenuVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuVisiteur";
            this.Text = "FrmMenuVisiteur";
            this.Load += new System.EventHandler(this.FrmMenuVisiteur_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mesRapportsEnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesRapportsValidésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesMedicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesPraticiensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesDonnéesPersonnellesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierConsulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerMonMotDePasseToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem maRégionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportsNonConsultésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesVisiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionÉquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauVisiteurDéléguéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
    }
}
namespace GSBCR.UI
{
    partial class FrmConsulterPraticien
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
            this.components = new System.ComponentModel.Container();
            this.lbTitre = new System.Windows.Forms.Label();
            this.lbPraticien = new System.Windows.Forms.Label();
            this.cbxPraticien = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.bsPraticien = new System.Windows.Forms.BindingSource(this.components);
            this.ucPraticien1 = new GSBCR.UC.UCPraticien();
            this.btnVoirRapport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(259, 9);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(263, 42);
            this.lbTitre.TabIndex = 0;
            this.lbTitre.Text = "Les praticiens";
            // 
            // lbPraticien
            // 
            this.lbPraticien.AutoSize = true;
            this.lbPraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPraticien.Location = new System.Drawing.Point(45, 123);
            this.lbPraticien.Name = "lbPraticien";
            this.lbPraticien.Size = new System.Drawing.Size(89, 20);
            this.lbPraticien.TabIndex = 1;
            this.lbPraticien.Text = "Praticien :";
            // 
            // cbxPraticien
            // 
            this.cbxPraticien.FormattingEnabled = true;
            this.cbxPraticien.Location = new System.Drawing.Point(167, 122);
            this.cbxPraticien.Name = "cbxPraticien";
            this.cbxPraticien.Size = new System.Drawing.Size(121, 21);
            this.cbxPraticien.TabIndex = 2;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(323, 120);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(581, 600);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(141, 28);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // ucPraticien1
            // 
            this.ucPraticien1.LePraticien = null;
            this.ucPraticien1.Location = new System.Drawing.Point(49, 158);
            this.ucPraticien1.Name = "ucPraticien1";
            this.ucPraticien1.Size = new System.Drawing.Size(622, 425);
            this.ucPraticien1.TabIndex = 5;
            // 
            // btnVoirRapport
            // 
            this.btnVoirRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirRapport.Location = new System.Drawing.Point(375, 600);
            this.btnVoirRapport.Name = "btnVoirRapport";
            this.btnVoirRapport.Size = new System.Drawing.Size(174, 28);
            this.btnVoirRapport.TabIndex = 6;
            this.btnVoirRapport.Text = "Voir mes rapports";
            this.btnVoirRapport.UseVisualStyleBackColor = true;
            this.btnVoirRapport.Click += new System.EventHandler(this.btnVoirRapport_Click);
            // 
            // FrmConsulterPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 640);
            this.Controls.Add(this.btnVoirRapport);
            this.Controls.Add(this.ucPraticien1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cbxPraticien);
            this.Controls.Add(this.lbPraticien);
            this.Controls.Add(this.lbTitre);
            this.Name = "FrmConsulterPraticien";
            this.Text = "FrmConsulterPraticien";
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.Label lbPraticien;
        private System.Windows.Forms.ComboBox cbxPraticien;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.BindingSource bsPraticien;
        private UC.UCPraticien ucPraticien1;
        private System.Windows.Forms.Button btnVoirRapport;
    }
}
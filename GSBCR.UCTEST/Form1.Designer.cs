namespace GSBCR.UCTEST
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMedicament = new System.Windows.Forms.ComboBox();
            this.btnQuiter = new System.Windows.Forms.Button();
            this.bsMedoc = new System.Windows.Forms.BindingSource(this.components);
            this.ucMedicament1 = new GSBCR.UC.UCMedicament();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir un medicament :";
            // 
            // cbxMedicament
            // 
            this.cbxMedicament.FormattingEnabled = true;
            this.cbxMedicament.Location = new System.Drawing.Point(298, 26);
            this.cbxMedicament.Name = "cbxMedicament";
            this.cbxMedicament.Size = new System.Drawing.Size(121, 21);
            this.cbxMedicament.TabIndex = 1;
            this.cbxMedicament.SelectedIndexChanged += new System.EventHandler(this.cbxMedicament_SelectedIndexChanged);
            // 
            // btnQuiter
            // 
            this.btnQuiter.Location = new System.Drawing.Point(446, 24);
            this.btnQuiter.Name = "btnQuiter";
            this.btnQuiter.Size = new System.Drawing.Size(75, 23);
            this.btnQuiter.TabIndex = 2;
            this.btnQuiter.Text = "Quitter";
            this.btnQuiter.UseVisualStyleBackColor = true;
            this.btnQuiter.Click += new System.EventHandler(this.btnQuiter_Click);
            // 
            // ucMedicament1
            // 
            this.ucMedicament1.LeMedicament = null;
            this.ucMedicament1.Location = new System.Drawing.Point(156, 64);
            this.ucMedicament1.Name = "ucMedicament1";
            this.ucMedicament1.Size = new System.Drawing.Size(425, 569);
            this.ucMedicament1.TabIndex = 3;
            this.ucMedicament1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 668);
            this.Controls.Add(this.ucMedicament1);
            this.Controls.Add(this.btnQuiter);
            this.Controls.Add(this.cbxMedicament);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMedoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMedicament;
        private System.Windows.Forms.Button btnQuiter;
        private System.Windows.Forms.BindingSource bsMedoc;
        private UC.UCMedicament ucMedicament1;
    }
}


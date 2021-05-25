namespace GSBCR.UI
{
    partial class FrmConsulterMedicament
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
            this.ucMedicament1 = new GSBCR.UC.UCMedicament();
            this.cbxMedicament = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucMedicament1
            // 
            this.ucMedicament1.LeMedicament = null;
            this.ucMedicament1.Location = new System.Drawing.Point(237, 36);
            this.ucMedicament1.Name = "ucMedicament1";
            this.ucMedicament1.Size = new System.Drawing.Size(425, 580);
            this.ucMedicament1.TabIndex = 8;
            // 
            // cbxMedicament
            // 
            this.cbxMedicament.FormattingEnabled = true;
            this.cbxMedicament.Location = new System.Drawing.Point(378, 11);
            this.cbxMedicament.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMedicament.Name = "cbxMedicament";
            this.cbxMedicament.Size = new System.Drawing.Size(92, 21);
            this.cbxMedicament.TabIndex = 7;
            this.cbxMedicament.SelectedIndexChanged += new System.EventHandler(this.cbxMedicament_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Medicament :";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(773, 597);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(115, 31);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmConsulterMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.ucMedicament1);
            this.Controls.Add(this.cbxMedicament);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConsulterMedicament";
            this.Text = "FrmConsulterMedicament";
            this.Load += new System.EventHandler(this.FrmConsulterMedicament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC.UCMedicament ucMedicament1;
        private System.Windows.Forms.ComboBox cbxMedicament;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuitter;
    }
}
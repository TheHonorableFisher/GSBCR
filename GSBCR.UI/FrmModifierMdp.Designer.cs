namespace GSBCR.UI
{
    partial class FrmModifierMdp
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblErreur = new System.Windows.Forms.Label();
            this.txtAncienMdp = new System.Windows.Forms.TextBox();
            this.txtNouveauMdp = new System.Windows.Forms.TextBox();
            this.txtResaisirNouveauMdp = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifier mon mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saisir le mot de passe actuel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saisir le nouveau mot de passe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resaisir le nouveau mot de passe";
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Location = new System.Drawing.Point(46, 355);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(0, 17);
            this.lblErreur.TabIndex = 4;
            // 
            // txtAncienMdp
            // 
            this.txtAncienMdp.Location = new System.Drawing.Point(302, 147);
            this.txtAncienMdp.Name = "txtAncienMdp";
            this.txtAncienMdp.Size = new System.Drawing.Size(166, 22);
            this.txtAncienMdp.TabIndex = 5;
            // 
            // txtNouveauMdp
            // 
            this.txtNouveauMdp.Location = new System.Drawing.Point(302, 211);
            this.txtNouveauMdp.Name = "txtNouveauMdp";
            this.txtNouveauMdp.Size = new System.Drawing.Size(166, 22);
            this.txtNouveauMdp.TabIndex = 6;
            // 
            // txtResaisirNouveauMdp
            // 
            this.txtResaisirNouveauMdp.Location = new System.Drawing.Point(302, 271);
            this.txtResaisirNouveauMdp.Name = "txtResaisirNouveauMdp";
            this.txtResaisirNouveauMdp.Size = new System.Drawing.Size(166, 22);
            this.txtResaisirNouveauMdp.TabIndex = 7;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(587, 204);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(105, 37);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(587, 355);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(105, 41);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmModifierMdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtResaisirNouveauMdp);
            this.Controls.Add(this.txtNouveauMdp);
            this.Controls.Add(this.txtAncienMdp);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmModifierMdp";
            this.Text = "FrmModifierMdp";
            this.Load += new System.EventHandler(this.FrmModifierMdp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.TextBox txtAncienMdp;
        private System.Windows.Forms.TextBox txtNouveauMdp;
        private System.Windows.Forms.TextBox txtResaisirNouveauMdp;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnQuitter;
    }
}
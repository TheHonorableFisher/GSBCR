using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmModiConsDonneesPerso : Form
    {

        public FrmModiConsDonneesPerso(VISITEUR v)
        {
            InitializeComponent();

            txtMatri.Text = v.VIS_MATRICULE;
            txtNom.Text = v.VIS_NOM;
            txtPrenom.Text = v.Vis_PRENOM;

            txtAddr.Text = v.VIS_ADRESSE;
            txtCp.Text = v.VIS_CP;
            txtVille.Text = v.VIS_VILLE;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmModiConsDonneesPerso_Load(object sender, EventArgs e)
        {

        }

        private void Valider_Click(object sender, EventArgs e)
        {
            if (VisiteurManager.updateVisiteur(txtMatri.Text, txtAddr.Text, txtCp.Text, txtVille.Text))
            {
                MessageBox.Show("Mise à jour de vos informations effectué avec succes.", "Mise à Jour des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Un problème est survenue lors de la mise à jour de vos informations", "Mise à Jour des données", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
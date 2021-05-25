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
using GSBCR.UC;

namespace GSBCR.UI
{
    public partial class FrmConsulterPraticien : Form
    {

        List<RAPPORT_VISITE> rapports = null;
        VISITEUR vis = null;
        public FrmConsulterPraticien(VISITEUR v)
        {
            InitializeComponent();

            // Initialisation du visiteur actuelle
            this.vis = v;

            // Initialisation de liste déroulante des praticiens
            List<PRATICIEN> lp = VisiteurManager.ChargerPraticiens();
            bsPraticien.DataSource = lp;
            cbxPraticien.DataSource = bsPraticien;
            cbxPraticien.DisplayMember = "PRA_NOM";
            cbxPraticien.ValueMember = "PRA_NUM";
            cbxPraticien.SelectedIndex = -1;


            this.rapports = VisiteurManager.ChargerRapportVisite(v.VIS_MATRICULE);

            // On cache l'affichage du praticien et du bouton rapport
            ucPraticien1.Visible = false;
            btnVoirRapport.Visible = false;
        }

        public FrmConsulterPraticien(VISITEUR v, int praticienNum)
        {
            InitializeComponent();

            // Initialisation du visiteur actuelle
            this.vis = v;

            // Initialisation de liste déroulante des praticiens
            PRATICIEN lp = VisiteurManager.ChargerLePraticien(praticienNum);
            bsPraticien.DataSource = lp;
            cbxPraticien.DataSource = bsPraticien;
            cbxPraticien.DisplayMember = "PRA_NOM";
            cbxPraticien.ValueMember = "PRA_NUM";
            cbxPraticien.SelectedIndex = -1;


            this.rapports = VisiteurManager.ChargerRapportVisite(v.VIS_MATRICULE);

            // On cache l'affichage du praticien et du bouton rapport
            ucPraticien1.Visible = false;
            btnVoirRapport.Visible = false;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bool isRapport = false;

            // On récupère le praticien choisit dans le formulaire
            PRATICIEN p = (PRATICIEN)(cbxPraticien.SelectedItem);


            // On attribue le praticien pour l'affichage
            ucPraticien1.LePraticien = p;

            // On regarde si le Visiteur à des rapports avec le praticien selectionné
            if(VisiteurManager.ChargerRapportParPraticienEtVisiteur(p.PRA_NUM,this.vis.VIS_MATRICULE).Count != 0)
            {
                isRapport = true;
                this.rapports = VisiteurManager.ChargerRapportParPraticienEtVisiteur(p.PRA_NUM, this.vis.VIS_MATRICULE);
            }
            else
            {
                isRapport = false;
            }

            // On affiche le boutton "voir rapport" si le visiteur possède des rapports avec le praticien renseigner
            if (isRapport)
            {
                btnVoirRapport.Show();
            }
            else
            {
                btnVoirRapport.Hide();
            }

            // On affiche le praticien
            ucPraticien1.Visible = true;
        }

        private void btnVoirRapport_Click(object sender, EventArgs e)
        {
            FrmRapportEnCours frmRapportEnCours = new FrmRapportEnCours(this.vis, this.rapports);
            frmRapportEnCours.ShowDialog();
        }
    }
}

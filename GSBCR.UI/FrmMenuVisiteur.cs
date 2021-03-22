using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmMenuVisiteur : Form
    {
        private VISITEUR leVisiteur;
        private VAFFECTATION leProfil;
        public FrmMenuVisiteur()
        {
            InitializeComponent();
            // chargement du visiteur connecté et de son profil
            try
            {
                //le visiteur doit être passé en paramètre par le menu de connexion
                //Ici initialiser le visiteur en dur
                //visiteur
                leVisiteur = VisiteurManager.ChargerVisiteur("a131", "secret18");
                //délégue
                //leVisiteur = VisiteurManager.ChargerVisiteur("r58", "secret18");
                //responsable
                //leVisiteur = VisiteurManager.ChargerVisiteur("r24", "secret18");
                leProfil = VisiteurManager.ChargerAffectationVisiteur(leVisiteur.VIS_MATRICULE);
                if (leProfil.TRA_ROLE == "Délégué")
                {
                    maRégionToolStripMenuItem.Enabled = true;
                }
                else if (leProfil.TRA_ROLE == "Responsable")
                {
                    monSecteurToolStripMenuItem.Enabled = true;
                    mesRapportsEnCoursToolStripMenuItem.Enabled = false;
                    mesRapportsValidésToolStripMenuItem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
            
        }

        private void FrmMenuVisiteur_Load(object sender, EventArgs e)
        {
            label2.Text = leProfil.TRA_ROLE + " " + leVisiteur.Vis_PRENOM + " " + leVisiteur.VIS_NOM;
            label3.Text = "Region : " + leProfil.REG_CODE;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            r.RAP_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmSaisir f = new FrmSaisir(r, true);
            f.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<RAPPORT_VISITE> lesRapports = null;
            try
            {
                lesRapports = VisiteurManager.ChargerRapportVisiteurEncours(leVisiteur.VIS_MATRICULE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (lesRapports != null && lesRapports.Count != 0)
            {
                FrmRapportEnCours f = new FrmRapportEnCours(leVisiteur, lesRapports);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aucun rapport en cours", "Gestion Rapports de visite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listeDesVisiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

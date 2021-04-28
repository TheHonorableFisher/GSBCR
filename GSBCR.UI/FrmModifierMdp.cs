using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using GSBCR.BLL;
using GSBCR.modele;

namespace GSBCR.UI
{
    public partial class FrmModifierMdp : Form
    {
        private VISITEUR visiteur;
        private Regex regexMdp = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$");
        private readonly String[] lesErreurs = {
            "Erreur : 'Saisir le nouveau mot de passe' et\n 'Resaisir le nouveau mot de passe' ne sont pas identiques !",
            "Erreur : Votre nouveau mot de passe ne peut être identique\n à votre ancien mot de passe !",
            "Erreur : Le champ 'Saisir le mot de passe actuel' est incorrecte !",
            "Erreur : L'un des champ n'est pas pas renseigné !",
            "Erreur : Le mot de passe doit être de minimum 8 caractère,\n et doit contenir 1 majuscule, 1 minuscule et 1 chiffre"
        };
        public FrmModifierMdp(VISITEUR v)
        {
            InitializeComponent();
            visiteur = v;
        }

        
        private void FrmModifierMdp_Load(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtAncienMdp.Text == "" || txtNouveauMdp.Text == "" || txtResaisirNouveauMdp.Text == "")
            {
                InitialiserLesChamps();
                AfficheErreur(3);
            }
            else
            {
                if (visiteur.vis_mdp != getMdp(txtAncienMdp.Text))
                {
                    if (txtNouveauMdp.Text == visiteur.vis_mdp)
                    {
                        if (regexMdp.IsMatch(txtNouveauMdp.Text))
                        {
                            if (txtNouveauMdp.Text == txtResaisirNouveauMdp.Text)
                            {
                                if (VisiteurManager.modifierMdp(visiteur.VIS_MATRICULE, txtNouveauMdp.Text))
                                {
                                    MessageBox.Show("Votre mot de passe a été modifié avec succes", "Mise à Jour des données"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("Un problème est survenue lors de la mise à jour de votre mot de passe"
                                        , "Mise à Jour des données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    InitialiserLesChamps();
                                }
                            }
                            else { AfficheErreur(0); }
                        }
                        else { AfficheErreur(4); }
                    }
                    else { AfficheErreur(1); }
                }
                else { AfficheErreur(2); }
            }
        }
        private void InitialiserLesChamps()
        {
            txtAncienMdp.Text = "";
            txtNouveauMdp.Text = "";
            txtResaisirNouveauMdp.Text = "";
        }

        private void AfficheErreur(int Erreur)
        {
            lblErreur.Text = lesErreurs[Erreur];
            lblErreur.Visible = true;
            InitialiserLesChamps();
        }

        private String getMdp(String mdp)
        {
            String a = mdp;

            for (int i = mdp.Length; i < 25; i++) { a += " "; }

            return a;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

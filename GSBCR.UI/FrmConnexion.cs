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
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            VISITEUR vis = new VISITEUR();

            string id = txtID.Text;
            string mdp = txtMDP.Text;

            try
            {
                if(!(txtID.Text == string.Empty))
                {
                    if(!(txtMDP.Text == string.Empty))
                    {
                        if(VisiteurManager.ChargerVisiteur(id,mdp) != null)
                        {
                            vis = VisiteurManager.ChargerVisiteur(id, mdp);

                            this.Hide();
                            FrmMenuVisiteur menu = new FrmMenuVisiteur(vis);
                            menu.ShowDialog();
                        }
                        else
                        {
                            txtErreur.Text = "Erreur, ID ou mot de passe incorrect !";
                        }
                    }
                    else
                    {
                        txtErreur.Text = "Erreur, mot de passe vide";
                    }
                }
                else
                {
                    txtErreur.Text = "Erreur, ID vide";
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

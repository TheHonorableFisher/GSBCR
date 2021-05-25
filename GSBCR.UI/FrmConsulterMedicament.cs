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
    public partial class FrmConsulterMedicament : Form
    {

        private MEDICAMENT leMedocSelect;
        private MEDICAMENT leMedoc;
        private VISITEUR leUtilisateur;

        public FrmConsulterMedicament(VISITEUR leUtilisateur)
        {
            InitializeComponent();
            this.leUtilisateur = leUtilisateur;
        }

        public FrmConsulterMedicament(VISITEUR leUtilisateur, MEDICAMENT leMedoc)
        {
            InitializeComponent();
            this.leUtilisateur = leUtilisateur;
            this.leMedoc = leMedoc;
        }

        private void cbxMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxMedicament.SelectedIndex != -1)
            {
                MEDICAMENT m = (MEDICAMENT)cbxMedicament.SelectedItem;
                this.leMedocSelect = m;
                ucMedicament1.LeMedicament = m;
                ucMedicament1.Visible = true;
            }
        }

        private void FrmConsulterMedicament_Load(object sender, EventArgs e)
        {
            List<MEDICAMENT> listMed = VisiteurManager.ChargerMedicaments();
            cbxMedicament.DataSource = listMed;
            cbxMedicament.DisplayMember = "MED_NOMCOMMERCIAL";
            cbxMedicament.ValueMember = "MED_DEPOTLEGAL";

            if(leMedoc != null)
            {
                cbxMedicament.SelectedValue = leMedoc.MED_DEPOTLEGAL;
                cbxMedicament.Enabled = false;
            }
            else
            {
                cbxMedicament.SelectedIndex = -1;
                ucMedicament1.Visible = false;
                this.leMedoc = null;
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

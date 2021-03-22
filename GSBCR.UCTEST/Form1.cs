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
using GSBCR.UC;
using GSBCR.BLL;

namespace GSBCR.UCTEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bsMedoc.DataSource = VisiteurManager.ChargerMedicaments();
            cbxMedicament.DataSource = bsMedoc;
            cbxMedicament.DisplayMember = "MED_NOMCOMMERCIAL";
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            ucMedicament1.Visible = false;
            cbxMedicament.SelectedIndex = -1;
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMedicament.SelectedIndex != -1)
            {
                MEDICAMENT m = (MEDICAMENT)cbxMedicament.SelectedItem;
                ucMedicament1.LeMedicament = m;
                ucMedicament1.Visible = true;
            }
        }
    }
}

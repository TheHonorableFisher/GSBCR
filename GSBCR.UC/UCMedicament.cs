using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;

namespace GSBCR.UC
{
    public partial class UCMedicament : UserControl
    {

        private MEDICAMENT leMedicament;

        public MEDICAMENT LeMedicament
        {
            get { return leMedicament; }
            set
            {
                leMedicament = value;
                if(leMedicament != null)
                {
                    ucMedicament_actualiser();
                }
            }
        }

        public void ucMedicament_actualiser()
        {
            txtbxDepot.Text = leMedicament.MED_DEPOTLEGAL;
            TxtbxNomComm.Text = leMedicament.MED_NOMCOMMERCIAL;
            TxtbxFam1.Text = leMedicament.FAM_CODE;
            txtbxFam2.Text = leMedicament.LaFamille.FAM_LIBELLE;
            txtbxCompo.Text = leMedicament.MED_CONTREINDIC;
            txtbxContreIndic.Text = leMedicament.MED_CONTREINDIC;
            txtbxEffets.Text = leMedicament.MED_EFFETS;
            txtbxPrixEchan.Text = leMedicament.MED_PRIXECHANTILLON.ToString();
        }

        public UCMedicament()
        {
            InitializeComponent();
        }

    }
}

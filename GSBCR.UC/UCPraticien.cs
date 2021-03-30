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
    public partial class UCPraticien : UserControl
    {

        PRATICIEN lePraticien = null;

        public PRATICIEN LePraticien
        {
            get { return lePraticien; }
            set
            {
                lePraticien = value;
                if (lePraticien != null)
                {
                    ucPracticien_actualiser();
                }
            }
        }

        public void ucPracticien_actualiser()
        {
            txtbxNum.Text = lePraticien.PRA_NUM.ToString();
            txtbxNom.Text = lePraticien.PRA_NOM;
            txtbxPrenom.Text = lePraticien.PRA_PRENOM;
            txtbxVille.Text = lePraticien.PRA_VILLE;
            txtbxAdresse.Text = lePraticien.PRA_ADRESSE;
            txtbxCP.Text = lePraticien.PRA_CP;
            txtbxNoto.Text = lePraticien.PRA_COEFNOTORIETE.ToString();
        }

        public UCPraticien()
        {
            InitializeComponent();
        }

    }
}

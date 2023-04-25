using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _15_BasisOef.MijnForms;

namespace _15_BasisOef
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnIngeven_Click(object sender, EventArgs e)
        {
            // nieuw form aanmaken 
            FrmIngeven nieuweForm = new FrmIngeven();

            // Deze form verbergen 
            Hide();

            // Nieuwe form tonen
            nieuweForm.ShowDialog();

            // Deze form tonen
            Show();
        }

        private void btnTonen_Click(object sender, EventArgs e)
        {
            // nieuw form aanmaken 
            FrmTonen nieuweForm = new FrmTonen();

            // Deze form verbergen 
            Hide();

            // Nieuwe form tonen
            nieuweForm.ShowDialog();

            // Deze form tonen
            Show();
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            // nieuw form aanmaken 
            FrmVerwijderen nieuweForm = new FrmVerwijderen();

            // Deze form verbergen 
            Hide();

            // Nieuwe form tonen
            nieuweForm.ShowDialog();

            // Deze form tonen
            Show();
        }
    }
}

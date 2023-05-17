using _17_ProjSchoolreis.MijnForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _17_ProjSchoolreis.MijnForms;

namespace _17_ProjSchoolreis
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnInvoegen_Click(object sender, EventArgs e)
        {
            // Nieuwe form maken 
            FrmInvoegen nieuweFrm   = new FrmInvoegen();

            // Deze hiden 
            Hide();

            // nieuwe form tonen
            nieuweFrm.ShowDialog();

            // Deze tonen
            Show();
        }

        private void btnTonen_Click(object sender, EventArgs e)
        {
            // Nieuwe form maken 
            FrmTonen nieuweFrm = new FrmTonen();

            // Deze hiden 
            Hide();

            // nieuwe form tonen
            nieuweFrm.ShowDialog();

            // Deze tonen
            Show();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            // Nieuwe form maken 
            FrmVerwijderen nieuweFrm = new FrmVerwijderen();

            // Deze hiden 
            Hide();

            // nieuwe form tonen
            nieuweFrm.ShowDialog();

            // Deze tonen
            Show();
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            // Nieuwe form maken 
            FrmAanpassen nieuweFrm = new FrmAanpassen();

            // Deze hiden 
            Hide();

            // nieuwe form tonen
            nieuweFrm.ShowDialog();

            // Deze tonen
            Show();
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            // sluiten 
            Close();
        }
    }
}

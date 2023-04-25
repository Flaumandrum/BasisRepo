using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_BasisOef
{
    public partial class FrmIngeven : Form
    {
        public FrmIngeven()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Check of de gebruiker iets heeft ingevuld en stuur dit dan door naar de business
        private void btnIngeven_Click(object sender, EventArgs e)
        {
            if(txtZin.Text == "")
            {
                MessageBox.Show("U gaf niets in", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Program.Opslaan(txtZin.Text);
                txtZin.Clear();
            }

        }
    }
}

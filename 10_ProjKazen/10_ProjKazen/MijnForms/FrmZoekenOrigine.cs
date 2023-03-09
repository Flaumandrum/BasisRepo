using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_ProjKazen.MijnForms
{
    public partial class FrmZoekenOrigine : Form
    {
        public FrmZoekenOrigine()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnZoekOrigine_Click(object sender, EventArgs e)
        {
            if(txtOrigine.Text != "")
            {
                txtToonTekst.Text= Program.ZoekOrigine(txtOrigine.Text);
            }
            else
            {
                MessageBox.Show("U moet eerst alle gegevens invullen", "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}

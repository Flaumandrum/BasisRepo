using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_ProjKazen
{
    public partial class FrmZoekMelk : Form
    {
        public FrmZoekMelk()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnZoekMelk_Click(object sender, EventArgs e)
        {
            if (txtMelk.Text != "")
            {
                txtToonTekst.Text = Program.ZoekMelk(txtMelk.Text);
            }
            else
            {
                MessageBox.Show("U moet eerst alle gegevens invullen", "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}

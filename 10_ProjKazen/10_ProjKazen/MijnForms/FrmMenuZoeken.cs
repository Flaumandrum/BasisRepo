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
    public partial class FrmMenuZoeken : Form
    {
        public FrmMenuZoeken()
        {
            InitializeComponent();
        }

        private void btnZoekOrigine_Click(object sender, EventArgs e)
        {
            // Nieuw form aanmaken 
            FrmZoekenOrigine nieuwFrm = new FrmZoekenOrigine();

            // Dit form verbergen
            Hide();

            // Nieuw form tonen 
            nieuwFrm.ShowDialog();

            // Dit form tonen
            Show();
        }

        private void btnZoekMelk_Click(object sender, EventArgs e)
        {
            // Nieuw form aanmaken 
            FrmZoekMelk nieuwFrm = new FrmZoekMelk();

            // Dit form verbergen
            Hide();

            // Nieuw form tonen 
            nieuwFrm.ShowDialog();

            // Dit form tonen
            Show();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_BasisOef.MijnForms
{
    public partial class FrmVerwijderen : Form
    {
        public FrmVerwijderen()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VulCmb()
        {
            List<String> ontvZinnen = Program.StuurLijstDoor();
            cmbKiesZin.Items.Clear();

            foreach(string s in ontvZinnen)
            {
                cmbKiesZin.Items.Add(s);
            }
        }

        private void FrmVerwijderen_Load(object sender, EventArgs e)
        {
            VulCmb();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            // check of iets geselecteerd is
            
            if(cmbKiesZin.SelectedIndex == -1)
            {
                // Indien niet: foutmelding
                MessageBox.Show("U selecteerde niets", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // Indien wel, stuur index door om te verwijderen
                Program.Verwijderen(cmbKiesZin.SelectedIndex);

                // reset de cmb : geselecteerd item, tekst, gegevens
                cmbKiesZin.SelectedIndex = -1;
                cmbKiesZin.Text = "";
                VulCmb();

                // Begeleid de gebruiker 
                MessageBox.Show("De zin is verwijderd", "Item verwijderd", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}

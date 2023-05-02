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
    public partial class FrmAanpassen : Form
    {
        public FrmAanpassen()
        {
            InitializeComponent();
        }

        private void VulCmb()
        {
            List<String> ontvZinnen = Program.StuurLijstDoor();
            cmbKiesZin.Items.Clear();

            foreach (string s in ontvZinnen)
            {
                cmbKiesZin.Items.Add(s);
            }
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            if(txtZin.Text == "")
            {
                MessageBox.Show("U gaf niets in", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // check of iets geselecteerd is

                if (cmbKiesZin.SelectedIndex == -1)
                {
                    // Indien niet: foutmelding
                    MessageBox.Show("U selecteerde niets", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Program.Aanpassen(cmbKiesZin.SelectedIndex, txtZin.Text);

                    //reset
                    txtZin.Text = "";
                    cmbKiesZin.SelectedIndex = -1;
                    cmbKiesZin.Text = "";
                    VulCmb();

                    // Begeleid de gebruiker 
                    MessageBox.Show("De zin is aangepast", "Item Aangepast", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void FrmAanpassen_Load(object sender, EventArgs e)
        {
            VulCmb();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

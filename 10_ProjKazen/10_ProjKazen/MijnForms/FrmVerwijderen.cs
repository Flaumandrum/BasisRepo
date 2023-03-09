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
    public partial class FrmVerwijderen : Form
    {
        public FrmVerwijderen()
        {
            InitializeComponent();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
         
            if (cmbKiesKaas.SelectedIndex != -1)
            {
                Program.Opslaan(null, null, null, cmbKiesKaas.SelectedIndex);

                //reset
                cmbKiesKaas.Text = "";
                cmbKiesKaas.SelectedIndex = -1;
                cmbKiesKaas.Items.Clear();
                VulCmb();
            }
            else
            {
                MessageBox.Show("Er is geen kaas geselecteerd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }

        }

        private void VulCmb()
        {
            Array ontvArray = Program.StuurKazenDoor();

            foreach (string s in ontvArray)
            {
                if (s != null)
                {
                    cmbKiesKaas.Items.Add(s);
                }
                else
                {
                    cmbKiesKaas.Items.Add("leeg");
                }
            }

        }

        private void FrmVerwijderen_Load(object sender, EventArgs e)
        {
            VulCmb();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

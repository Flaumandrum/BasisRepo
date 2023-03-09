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
    public partial class FrmAanpassen : Form
    {
        public FrmAanpassen()
        {
            InitializeComponent();

        }

        private void VulCmb()
        {
            Array ontvArray = Program.StuurKazenDoor();

            foreach(string s in ontvArray)
            {
                if(s != null)
                {
                    cmbKiesKaas.Items.Add(s);
                }
                else
                {
                    cmbKiesKaas.Items.Add("leeg");
                }
            }

        }

        private void FrmAanpassen_Load(object sender, EventArgs e)
        {
            VulCmb();   
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            if (txtNaamKaas.Text != "" && txtOrigine.Text != "" && txtSoortMelk.Text != "")
            {
                int ontvIndex = cmbKiesKaas.SelectedIndex;
                if (ontvIndex != -1)
                {
                    string naam = txtNaamKaas.Text;
                    string origine = txtOrigine.Text;
                    string melk = txtSoortMelk.Text;

                    Program.Opslaan(naam, origine, melk, ontvIndex);

                    MessageBox.Show("Succesvol aangepast", "great succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //reset textboxen
                    txtNaamKaas.Text = "";
                    txtOrigine.Text = "";
                    txtSoortMelk.Text = "";

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
            else
            {
                MessageBox.Show("U moet eerst alle gegevens invullen", "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void cmbKiesKaas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbKiesKaas.SelectedIndex;
            if(index != -1)
            {
                txtNaamKaas.Text=Program.NaamKaas(index);
                txtOrigine.Text = Program.OrigineKaas(index);   
                txtSoortMelk.Text=Program.SoortMelk(index);
            }
           

        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    
}

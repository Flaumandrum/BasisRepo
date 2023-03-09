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
    public partial class FrmToevoegen : Form
    {
        public FrmToevoegen()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if(txtNaamKaas.Text!= "" && txtOrigine.Text != "" && txtSoortMelk.Text != "")
            {
                int ontvIndex=  Program.CheckLegePlaats();
                if( ontvIndex!=-1 )
                {
                    string naam = txtNaamKaas.Text;
                    string origine = txtOrigine.Text;  
                    string melk = txtSoortMelk.Text;

                    Program.Opslaan(naam, origine, melk, ontvIndex);

                    MessageBox.Show("Succesvol toegevoegd", "great succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //reset textboxen
                    txtNaamKaas.Text = "";
                    txtOrigine.Text = "";
                    txtSoortMelk.Text = "";

                    ontvIndex = Program.CheckLegePlaats();
                    if (ontvIndex == -1)
                    {
                        Close();
                    }

                }
                else
                {
                    MessageBox.Show("Er is geen plaats beschikbaar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }

            }
            else
            {
                MessageBox.Show("U moet eerst alle gegevens invullen", "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void FrmToevoegen_Load(object sender, EventArgs e)
        {
            int ontvIndex = Program.CheckLegePlaats();
            if (ontvIndex == -1)
            {
                MessageBox.Show("Geen plaats", "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Close();
            }
        }
    }
}

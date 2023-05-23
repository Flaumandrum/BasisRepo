using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_ProjSchoolreis.MijnForms
{
    public partial class FrmInvoegen : Form
    {
        public FrmInvoegen()
        {
            InitializeComponent();
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            // Foutmeldingen, is alles ingevuld?
            if(txtVoornaam.Text!= "" && TxtAchternaam.Text != "" && cmbScore.SelectedIndex != -1)
            {
                // zet alle gegevens naar variabelen 
                string vn = txtVoornaam.Text;
                string an = TxtAchternaam.Text;
                int score = cmbScore.SelectedIndex + 1;

                // stuur alles door naar de juiste functie
                Program.Invoegen(vn,an, score);

                // Geef de gebruiker een melding
                MessageBox.Show("Toegevoegd", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //reset de values van alle velden
                txtVoornaam.Text = "";
                TxtAchternaam.Text = "";
                cmbScore.Text = "";
                cmbScore.SelectedIndex = -1;

            }
            else
            {
                // toon foutmelding
                MessageBox.Show("U heeft niet alles ingevuld", "Oeps?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}

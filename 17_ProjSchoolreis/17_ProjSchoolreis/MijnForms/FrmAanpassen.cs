using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beoordeling;

namespace _17_ProjSchoolreis.MijnForms
{
    public partial class FrmAanpassen : Form
    {
        public FrmAanpassen()
        {
            InitializeComponent();
        }

        private void FrmAanpassen_Load(object sender, EventArgs e)
        {
            VulCmb();
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            // Foutmeldingen, is alles ingevuld?
            if (txtVoornaam.Text != "" && TxtAchternaam.Text != "" && cmbScore.SelectedIndex != -1 && cmbKies.SelectedIndex!= -1)
            {
                // zet alle gegevens naar variabelen 
                int index = cmbKies.SelectedIndex;
                string vn = txtVoornaam.Text;
                string an = TxtAchternaam.Text;
                int score = cmbScore.SelectedIndex + 1;

                // stuur alles door naar de juiste functie
                Program.Aanpassen(vn, an, score, index);

                // Geef de gebruiker een melding
                MessageBox.Show("Aangepast", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //reset de values van alle velden
                cmbKies.SelectedIndex = -1;
                cmbKies.Text = "";
                VulCmb();
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

        void VulCmb()
        {
            // Reset de cmb
            cmbKies.Items.Clear();

            //Vraag de lijst op van uit de business
            List<EenBeoordeling> ontvLijst = Program.StuurLijstDoor();

            //Overloop de lijst en vul cmb
            foreach(EenBeoordeling b in ontvLijst)
            {
                cmbKies.Items.Add(b.VolledigeNaam());
            }
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

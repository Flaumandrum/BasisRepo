using Beoordeling;
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
    public partial class FrmTonen : Form
    {
        public FrmTonen()
        {
            InitializeComponent();
        }

        private void FrmTonen_Load(object sender, EventArgs e)
        {
            StartView();
            VulCmb();
        }

        private void StartView ()
        {
            cmbKies.Visible = false;
            lblKies.Visible = false;
            rbnAllegegevens.Checked = true;
        }

        private void rbnEnkeleGegevens_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnEnkeleGegevens.Checked == true)
            { 
                cmbKies.Visible=true;
                lblKies.Visible=true;
            }
            else
            {
                StartView();
            }
        }

        void VulCmb()
        {
            // Reset de cmb
            cmbKies.Items.Clear();

            //Vraag de lijst op van uit de business
            List<EenBeoordeling> ontvLijst = Program.StuurLijstDoor();

            //Overloop de lijst en vul cmb
            foreach (EenBeoordeling b in ontvLijst)
            {
                cmbKies.Items.Add(b.VolledigeNaam());
            }
        }

        private void btnTonen_Click(object sender, EventArgs e)
        {
            if(rbnAllegegevens.Checked== true)
            {
                txtToon.Text = Program.ToonAlles();
            }
            else
            {
                if(cmbKies.SelectedIndex != -1)
                {
                    txtToon.Text = Program.ToonEenLeerling(cmbKies.SelectedIndex);
                }
                else
                {
                    // toon foutmelding
                    MessageBox.Show("U heeft geen leerling geselecteerd", "Oeps?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

using _19Klasses_ProjWekker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _20_Projec_Wekker
{
    public partial class FrmAlarmVerwijderen : Form
    {
        public FrmAlarmVerwijderen()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if(cmbKies.SelectedIndex != -1 )
            {
                // Stuur de index door naar de business
                Program.VerwijderenAlarm(cmbKies.SelectedIndex);

                //begeleid de gebruiker
                MessageBox.Show("Item is verwijderd", "Great succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // form resetten
                VulCmb();
                cmbKies.Text = "";
                cmbKies.SelectedIndex = -1;

            }
            else
            {

                //Foutmelding
                MessageBox.Show("U heeft niet alle velden ingevuld", "ERROR, does not compute", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
        }


        // vult de combobox met de gegevens
        private void VulCmb()
        {
            // reset combobox
            cmbKies.Items.Clear();

            // vraag de lijst met alarmen op
            List<Wekker> ontvLijst = Program.StuurLijstDoor();

            //Vul de combobox met de gegevens uit de lijst
            foreach (Wekker w in ontvLijst)
            {
                cmbKies.Items.Add(w.AlleGegevens());
            }


        }

        private void FrmAlarmVerwijderen_Load(object sender, EventArgs e)
        {
            VulCmb();
        }
    }

   
    
}

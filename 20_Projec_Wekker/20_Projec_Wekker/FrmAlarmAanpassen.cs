using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _19Klasses_ProjWekker;

namespace _20_Projec_Wekker
{
    public partial class FrmAlarmAanpassen : Form
    {
        public FrmAlarmAanpassen()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VulCmb ()
        {
            // reset combobox
            cmbKies.Items.Clear();

            // vraag de lijst met alarmen op
            List<Wekker> ontvLijst = Program.StuurLijstDoor();

            //Vul de combobox met de gegevens uit de lijst
            foreach(Wekker w in ontvLijst)
            {
                cmbKies.Items.Add(w.AlleGegevens());
            }


        }

        private void FrmAlarmAanpassen_Load(object sender, EventArgs e)
        {
            VulCmb();
        }

        private void cmbKies_SelectedIndexChanged(object sender, EventArgs e)
        {
            // vraag de lijst met alarmen op
            List<Wekker> ontvLijst = Program.StuurLijstDoor();

            // Neem de gegevens over
            txtDatum.Text = ontvLijst[cmbKies.SelectedIndex].PropInstelling.ToShortDateString();
            txtUur.Text = ontvLijst[cmbKies.SelectedIndex].PropInstelling.Hour.ToString();
            txtMin.Text = ontvLijst[cmbKies.SelectedIndex].PropInstelling.Minute.ToString();
            cbxActief.Checked = ontvLijst[cmbKies.SelectedIndex].PropActief;
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            //check of er gegevens zijn ingevuld
            if (txtDatum.Text != "" && txtUur.Text != "" && txtMin.Text != "" && cmbKies.SelectedIndex!=-1)
            {
                // kijk of de gegevens omzetbaar zijn
                try
                {
                    // zet alles om naar een datum
                    string volledig = $"{txtDatum.Text} {txtUur.Text}:{txtMin.Text}:00";
                    DateTime alarm = DateTime.Parse(volledig);


                    //stuur door naar de business
                    Program.AanpassenAlarm(alarm, cbxActief.Checked, cmbKies.SelectedIndex);

                    //begeleid de gebruiker
                    MessageBox.Show("Alles is gelukt", "Great succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // form resetten
                    txtDatum.Text = "";
                    txtMin.Text = "";
                    txtUur.Text = "";
                    cbxActief.Checked = false;
                    VulCmb();
                    cmbKies.Text = "";
                    cmbKies.SelectedIndex = -1;

                }
                catch
                {
                    MessageBox.Show("U heeft een onjuist gegeven ingevoerd", "ERROR, compter sais no!", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }
            }
            else
            {
                MessageBox.Show("U heeft niet alle velden ingevuld", "ERROR, does not compute", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }
    }
}

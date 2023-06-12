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
    public partial class FrmAlarmInstellen : Form
    {
        public FrmAlarmInstellen()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            //check of er gegevens zijn ingevuld
            if (txtDatum.Text != "" && txtUur.Text != "" && txtMin.Text != "")
            {
                // kijk of de gegevens omzetbaar zijn
                try
                {
                    // zet alles om naar een datum
                    string volledig = $"{txtDatum.Text} {txtUur.Text}:{txtMin.Text}:00"; 
                    DateTime alarm = DateTime.Parse(volledig);

                    //stuur door naar de business
                    Program.InstellenAlarm(alarm);

                    //begeleid de gebruiker
                    MessageBox.Show("Alles is gelukt", "Great succes!", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                    // form resetten
                    txtDatum.Text = "";
                    txtMin.Text = "";
                    txtUur.Text = "";
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

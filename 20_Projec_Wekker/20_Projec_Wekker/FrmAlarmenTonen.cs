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
    public partial class FrmAlarmenTonen : Form
    {

        // velden
        int _getCode = Program.WillekeurigeCode();

        public FrmAlarmenTonen()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAlarmenTonen_Load(object sender, EventArgs e)
        {
            // design goed maken 
            txtToon.Visible = false;

           
            // Toon de code via de textbox
            lblCode.Text += _getCode.ToString();


        }

        private void btnIngeven_Click(object sender, EventArgs e)
        {
            try
            {
                // Check of de code juist ingevuld is
               bool ontvAntwoord =  Program.CheckCode(_getCode, int.Parse(txtCode.Text));
                
                if(ontvAntwoord)
                {
                    // design aanpassen 
                    txtCode.Visible = false;
                    lblCode.Visible = false;
                    txtToon.Visible = true;
                    btnIngeven.Visible = false;

                    txtToon.Text = Program.ToonAlarmen();
                }
                else
                {
                    MessageBox.Show("U heeft een onjuiste code ingegeven", "ERROR, compter sais no!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Close();
                }


            }
            catch
            {
                MessageBox.Show("U heeft een onjuist gegeven ingevoerd", "ERROR, compter sais no!", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
        }
    }
}

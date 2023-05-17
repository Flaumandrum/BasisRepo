using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_ProjDobbelsteen
{
    public partial class Rollen : Form
    {
        public Rollen()
        {
            InitializeComponent();
        }

        private void btnRollen_Click(object sender, EventArgs e)
        {
            // Fout controle
            if(txtAantal.Text != "" && txtOgen.Text != "")
            {
                try
                {
                    Program.RollenDobbelstenen(Byte.Parse(txtOgen.Text), Byte.Parse(txtAantal.Text));
                    txtResultaat.Text = Program.ToonResultaat();


                }
                catch {
                    MessageBox.Show("U gaf geen getal in");
                }
            }
            else
            {
                MessageBox.Show("U moet alles invullen");
            }
        }
    }
}

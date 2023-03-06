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
    public partial class FrmInstellingen : Form
    {
        public FrmInstellingen()
        {
            InitializeComponent();
        }

        private void btnArrayAanpassen_Click(object sender, EventArgs e)
        {
            if(txtArrayAanpassen.Text != "")
            {
                try
                {
                    int grootte = int.Parse(txtArrayAanpassen.Text);

                    Program.GrootteArrayAanpassen(grootte);

                    MessageBox.Show("De grootte werd aangepast", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("U heeft geen getal ingegeven", "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else
            {
                MessageBox.Show("U moet eerst een aantal invullen","FOUT",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}

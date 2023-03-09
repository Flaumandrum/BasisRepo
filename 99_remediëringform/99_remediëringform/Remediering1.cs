using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _99_remediëringform
{
    public partial class Remediering1 : Form
    {
        public Remediering1()
        {
            InitializeComponent();
        }

        private void btnActie_Click(object sender, EventArgs e)
        {
            if(txtnaam.Text != "")
            {
                string naam = txtnaam.Text;

                MessageBox.Show(Program.ZegHallo(naam));
            }
            else
            {
                MessageBox.Show("fout");
            }
            
        }
    }
}

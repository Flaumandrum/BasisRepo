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
    public partial class FrmHuidigeTijd : Form
    {
        public FrmHuidigeTijd()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmHuidigeTijd_Load(object sender, EventArgs e)
        {
            lblTijd.Text = Program.GetHuidigeTijd();
        }
    }
}

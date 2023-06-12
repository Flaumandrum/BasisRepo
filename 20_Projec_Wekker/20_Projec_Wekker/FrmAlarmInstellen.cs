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
            string volledig = $"{txtDatum.Text} + " "+ txtDatum.Text + 
            DateTime alarm = DateTime.Parse();
            alarm;
            alarm.AddMinutes(double.Parse(txtMin.Text));

            MessageBox.Show(alarm.ToString());
        }
    }
}

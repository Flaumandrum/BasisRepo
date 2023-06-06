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
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void btnHuidigeTijd_Click(object sender, EventArgs e)
        {
            // Nieuwe form maken 
            FrmHuidigeTijd nieuweForm = new FrmHuidigeTijd();

            // Hide
            Hide();

            // Nieuwe Tonen
            nieuweForm.ShowDialog();

            // Tonen
            Show();

        }

        private void btnAlarmTonen_Click(object sender, EventArgs e)
        {
            // Nieuwe form maken 
            FrmAlarmenTonen nieuweForm = new FrmAlarmenTonen();

            // Hide
            Hide();

            // Nieuwe Tonen
            nieuweForm.ShowDialog();

            // Tonen
            Show();

        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {

            Close();
            
        }

        private void btnAlarmAanpassen_Click(object sender, EventArgs e)
        {
            // Nieuwe form maken 
            FrmAlarmAanpassen nieuweForm = new FrmAlarmAanpassen();

            // Hide
            Hide();

            // Nieuwe Tonen
            nieuweForm.ShowDialog();

            // Tonen
            Show();

        }

        private void btnAlarmInstellen_Click(object sender, EventArgs e)
        {
            // Nieuwe form maken 
           FrmAlarmInstellen nieuweForm = new FrmAlarmInstellen();

            // Hide
            Hide();

            // Nieuwe Tonen
            nieuweForm.ShowDialog();

            // Tonen
            Show();

        }

        private void btnAlarmVerwijderen_Click(object sender, EventArgs e)
        {
            // Nieuwe form maken 
            FrmAlarmVerwijderen nieuweForm = new FrmAlarmVerwijderen();

            // Hide
            Hide();

            // Nieuwe Tonen
            nieuweForm.ShowDialog();

            // Tonen
            Show();

        }
    }
}

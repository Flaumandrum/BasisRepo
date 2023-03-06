using _10_ProjKazen.MijnForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _10_ProjKazen
{
    public partial class FrmIntro : Form
    {
        public FrmIntro()
        {
            InitializeComponent();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            // Nieuw form aanmaken 
            FrmStartMenu nieuwFrm = new FrmStartMenu(); 

            // Dit form verbergen
            Hide();

            // Nieuw form tonen 
            nieuwFrm.ShowDialog();  

            // Dit form tonen
            Show();

        }

        
    }
}

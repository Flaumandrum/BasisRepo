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
    public partial class FrmStartMenu : Form
    {
        public FrmStartMenu()
        {
            InitializeComponent();
        }

        private void btnInstellingen_Click(object sender, EventArgs e)
        {
            // Nieuw form aanmaken 
            FrmInstellingen nieuwFrm = new FrmInstellingen();

            // Dit form verbergen
            Hide();

            // Nieuw form tonen 
            nieuwFrm.ShowDialog();

            //pas form aan
            bool ontvAntwoord = Program.CheckArray();

            if (ontvAntwoord)
            {
                btnProgramma.Visible = true;
            }

            // Dit form tonen
            Show();


        }

        private void FrmStartMenu_Load(object sender, EventArgs e)
        {
            btnProgramma.Visible = false;

            bool ontvAntwoord = Program.CheckArray();

            if (ontvAntwoord)
            {
                btnProgramma.Visible = true;
            }

        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProgramma_Click(object sender, EventArgs e)
        {
            // Nieuw form aanmaken 
            FrmProgramma nieuwFrm = new FrmProgramma();

            // Dit form verbergen
            Hide();

            // Nieuw form tonen 
            nieuwFrm.ShowDialog();

            // Dit form tonen
            Show();
        }
    }
}

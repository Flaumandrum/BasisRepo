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
    public partial class FrmProgramma : Form
    {
        public FrmProgramma()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            // Nieuw form aanmaken 
            FrmToevoegen nieuwFrm = new FrmToevoegen();

            // Dit form verbergen
            Hide();

            // Nieuw form tonen 
            nieuwFrm.ShowDialog();

            if (checkplaatsen())
            {
                btnToevoegen.Enabled = false;
            }

            // Dit form tonen
            Show();
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            // Nieuw form aanmaken 
            FrmAanpassen nieuwFrm = new FrmAanpassen();

            // Dit form verbergen
            Hide();

            // Nieuw form tonen 
            nieuwFrm.ShowDialog();

            // Dit form tonen
            Show();
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            // Nieuw form aanmaken 
            FrmMenuZoeken nieuwFrm = new FrmMenuZoeken();

            // Dit form verbergen
            Hide();

            // Nieuw form tonen 
            nieuwFrm.ShowDialog();

            // Dit form tonen
            Show();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            // Nieuw form aanmaken 
            FrmVerwijderen nieuwFrm = new FrmVerwijderen();

            // Dit form verbergen
            Hide();

            // Nieuw form tonen 
            nieuwFrm.ShowDialog();

            // Dit form tonen
            Show();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProgramma_Load(object sender, EventArgs e)
        {
            if (checkplaatsen())
            {
                btnToevoegen.Enabled = false;
            }
        }

        private bool checkplaatsen()
        {
            bool antwoord = true;

            if(Program.CheckLegePlaats() != -1)
            {
                antwoord = false;
            }

            return antwoord;
        }

    }
}

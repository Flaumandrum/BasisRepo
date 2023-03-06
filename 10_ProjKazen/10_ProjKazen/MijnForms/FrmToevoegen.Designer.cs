namespace _10_ProjKazen.MijnForms
{
    partial class FrmToevoegen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIntroTekst = new System.Windows.Forms.Label();
            this.lblNaamKaas = new System.Windows.Forms.Label();
            this.txtNaamKaas = new System.Windows.Forms.TextBox();
            this.txtOrigine = new System.Windows.Forms.TextBox();
            this.lblOrigine = new System.Windows.Forms.Label();
            this.txtSoortMelk = new System.Windows.Forms.TextBox();
            this.lblSoortMelk = new System.Windows.Forms.Label();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIntroTekst
            // 
            this.lblIntroTekst.AutoSize = true;
            this.lblIntroTekst.Location = new System.Drawing.Point(27, 18);
            this.lblIntroTekst.Name = "lblIntroTekst";
            this.lblIntroTekst.Size = new System.Drawing.Size(305, 23);
            this.lblIntroTekst.TabIndex = 0;
            this.lblIntroTekst.Text = "Vul onderstaande gegevens in.";
            // 
            // lblNaamKaas
            // 
            this.lblNaamKaas.AutoSize = true;
            this.lblNaamKaas.Location = new System.Drawing.Point(27, 71);
            this.lblNaamKaas.Name = "lblNaamKaas";
            this.lblNaamKaas.Size = new System.Drawing.Size(123, 23);
            this.lblNaamKaas.TabIndex = 1;
            this.lblNaamKaas.Text = "Naam kaas:";
            // 
            // txtNaamKaas
            // 
            this.txtNaamKaas.Location = new System.Drawing.Point(168, 71);
            this.txtNaamKaas.Name = "txtNaamKaas";
            this.txtNaamKaas.Size = new System.Drawing.Size(197, 31);
            this.txtNaamKaas.TabIndex = 2;
            // 
            // txtOrigine
            // 
            this.txtOrigine.Location = new System.Drawing.Point(172, 120);
            this.txtOrigine.Name = "txtOrigine";
            this.txtOrigine.Size = new System.Drawing.Size(193, 31);
            this.txtOrigine.TabIndex = 4;
            // 
            // lblOrigine
            // 
            this.lblOrigine.AutoSize = true;
            this.lblOrigine.Location = new System.Drawing.Point(27, 120);
            this.lblOrigine.Name = "lblOrigine";
            this.lblOrigine.Size = new System.Drawing.Size(139, 23);
            this.lblOrigine.TabIndex = 3;
            this.lblOrigine.Text = "Origine kaas:";
            // 
            // txtSoortMelk
            // 
            this.txtSoortMelk.Location = new System.Drawing.Point(172, 165);
            this.txtSoortMelk.Name = "txtSoortMelk";
            this.txtSoortMelk.Size = new System.Drawing.Size(193, 31);
            this.txtSoortMelk.TabIndex = 6;
            // 
            // lblSoortMelk
            // 
            this.lblSoortMelk.AutoSize = true;
            this.lblSoortMelk.Location = new System.Drawing.Point(27, 173);
            this.lblSoortMelk.Name = "lblSoortMelk";
            this.lblSoortMelk.Size = new System.Drawing.Size(131, 23);
            this.lblSoortMelk.TabIndex = 5;
            this.lblSoortMelk.Text = "Soort melk: ";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.BackColor = System.Drawing.Color.Bisque;
            this.btnOpslaan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpslaan.Location = new System.Drawing.Point(17, 217);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(178, 50);
            this.btnOpslaan.TabIndex = 7;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = false;
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.Bisque;
            this.btnAnnuleren.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnnuleren.Location = new System.Drawing.Point(201, 217);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(178, 50);
            this.btnAnnuleren.TabIndex = 8;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            // 
            // FrmToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 281);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.txtSoortMelk);
            this.Controls.Add(this.lblSoortMelk);
            this.Controls.Add(this.txtOrigine);
            this.Controls.Add(this.lblOrigine);
            this.Controls.Add(this.txtNaamKaas);
            this.Controls.Add(this.lblNaamKaas);
            this.Controls.Add(this.lblIntroTekst);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmToevoegen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gegevens toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntroTekst;
        private System.Windows.Forms.Label lblNaamKaas;
        private System.Windows.Forms.TextBox txtNaamKaas;
        private System.Windows.Forms.TextBox txtOrigine;
        private System.Windows.Forms.Label lblOrigine;
        private System.Windows.Forms.TextBox txtSoortMelk;
        private System.Windows.Forms.Label lblSoortMelk;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnAnnuleren;
    }
}
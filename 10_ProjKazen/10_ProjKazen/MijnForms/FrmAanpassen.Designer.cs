namespace _10_ProjKazen.MijnForms
{
    partial class FrmAanpassen
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
            this.lblKiesKaas = new System.Windows.Forms.Label();
            this.cmbKiesKaas = new System.Windows.Forms.ComboBox();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.txtSoortMelk = new System.Windows.Forms.TextBox();
            this.lblSoortMelk = new System.Windows.Forms.Label();
            this.txtOrigine = new System.Windows.Forms.TextBox();
            this.lblOrigine = new System.Windows.Forms.Label();
            this.txtNaamKaas = new System.Windows.Forms.TextBox();
            this.lblNaamKaas = new System.Windows.Forms.Label();
            this.lblIntroTekst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKiesKaas
            // 
            this.lblKiesKaas.AutoSize = true;
            this.lblKiesKaas.Location = new System.Drawing.Point(28, 28);
            this.lblKiesKaas.Name = "lblKiesKaas";
            this.lblKiesKaas.Size = new System.Drawing.Size(144, 23);
            this.lblKiesKaas.TabIndex = 0;
            this.lblKiesKaas.Text = "Kies uw kaas:";
            // 
            // cmbKiesKaas
            // 
            this.cmbKiesKaas.FormattingEnabled = true;
            this.cmbKiesKaas.Location = new System.Drawing.Point(173, 25);
            this.cmbKiesKaas.Name = "cmbKiesKaas";
            this.cmbKiesKaas.Size = new System.Drawing.Size(193, 31);
            this.cmbKiesKaas.TabIndex = 1;
            this.cmbKiesKaas.SelectedIndexChanged += new System.EventHandler(this.cmbKiesKaas_SelectedIndexChanged);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.Bisque;
            this.btnAnnuleren.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnnuleren.Location = new System.Drawing.Point(202, 309);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(178, 50);
            this.btnAnnuleren.TabIndex = 17;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.BackColor = System.Drawing.Color.Bisque;
            this.btnAanpassen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAanpassen.Location = new System.Drawing.Point(18, 309);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(178, 50);
            this.btnAanpassen.TabIndex = 16;
            this.btnAanpassen.Text = "Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = false;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // txtSoortMelk
            // 
            this.txtSoortMelk.Location = new System.Drawing.Point(173, 257);
            this.txtSoortMelk.Name = "txtSoortMelk";
            this.txtSoortMelk.Size = new System.Drawing.Size(193, 31);
            this.txtSoortMelk.TabIndex = 15;
            // 
            // lblSoortMelk
            // 
            this.lblSoortMelk.AutoSize = true;
            this.lblSoortMelk.Location = new System.Drawing.Point(28, 265);
            this.lblSoortMelk.Name = "lblSoortMelk";
            this.lblSoortMelk.Size = new System.Drawing.Size(131, 23);
            this.lblSoortMelk.TabIndex = 14;
            this.lblSoortMelk.Text = "Soort melk: ";
            // 
            // txtOrigine
            // 
            this.txtOrigine.Location = new System.Drawing.Point(173, 212);
            this.txtOrigine.Name = "txtOrigine";
            this.txtOrigine.Size = new System.Drawing.Size(193, 31);
            this.txtOrigine.TabIndex = 13;
            // 
            // lblOrigine
            // 
            this.lblOrigine.AutoSize = true;
            this.lblOrigine.Location = new System.Drawing.Point(28, 212);
            this.lblOrigine.Name = "lblOrigine";
            this.lblOrigine.Size = new System.Drawing.Size(139, 23);
            this.lblOrigine.TabIndex = 12;
            this.lblOrigine.Text = "Origine kaas:";
            // 
            // txtNaamKaas
            // 
            this.txtNaamKaas.Location = new System.Drawing.Point(173, 163);
            this.txtNaamKaas.Name = "txtNaamKaas";
            this.txtNaamKaas.Size = new System.Drawing.Size(193, 31);
            this.txtNaamKaas.TabIndex = 11;
            // 
            // lblNaamKaas
            // 
            this.lblNaamKaas.AutoSize = true;
            this.lblNaamKaas.Location = new System.Drawing.Point(28, 163);
            this.lblNaamKaas.Name = "lblNaamKaas";
            this.lblNaamKaas.Size = new System.Drawing.Size(123, 23);
            this.lblNaamKaas.TabIndex = 10;
            this.lblNaamKaas.Text = "Naam kaas:";
            // 
            // lblIntroTekst
            // 
            this.lblIntroTekst.AutoSize = true;
            this.lblIntroTekst.Location = new System.Drawing.Point(28, 110);
            this.lblIntroTekst.Name = "lblIntroTekst";
            this.lblIntroTekst.Size = new System.Drawing.Size(305, 23);
            this.lblIntroTekst.TabIndex = 9;
            this.lblIntroTekst.Text = "Vul onderstaande gegevens in.";
            // 
            // FrmAanpassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 383);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.txtSoortMelk);
            this.Controls.Add(this.lblSoortMelk);
            this.Controls.Add(this.txtOrigine);
            this.Controls.Add(this.lblOrigine);
            this.Controls.Add(this.txtNaamKaas);
            this.Controls.Add(this.lblNaamKaas);
            this.Controls.Add(this.lblIntroTekst);
            this.Controls.Add(this.cmbKiesKaas);
            this.Controls.Add(this.lblKiesKaas);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmAanpassen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAanpassen";
            this.Load += new System.EventHandler(this.FrmAanpassen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKiesKaas;
        private System.Windows.Forms.ComboBox cmbKiesKaas;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.TextBox txtSoortMelk;
        private System.Windows.Forms.Label lblSoortMelk;
        private System.Windows.Forms.TextBox txtOrigine;
        private System.Windows.Forms.Label lblOrigine;
        private System.Windows.Forms.TextBox txtNaamKaas;
        private System.Windows.Forms.Label lblNaamKaas;
        private System.Windows.Forms.Label lblIntroTekst;
    }
}
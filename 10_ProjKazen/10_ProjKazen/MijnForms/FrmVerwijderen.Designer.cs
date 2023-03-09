namespace _10_ProjKazen.MijnForms
{
    partial class FrmVerwijderen
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
            this.cmbKiesKaas = new System.Windows.Forms.ComboBox();
            this.lblKiesKaas = new System.Windows.Forms.Label();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKiesKaas
            // 
            this.cmbKiesKaas.FormattingEnabled = true;
            this.cmbKiesKaas.Location = new System.Drawing.Point(169, 19);
            this.cmbKiesKaas.Name = "cmbKiesKaas";
            this.cmbKiesKaas.Size = new System.Drawing.Size(193, 31);
            this.cmbKiesKaas.TabIndex = 3;
            // 
            // lblKiesKaas
            // 
            this.lblKiesKaas.AutoSize = true;
            this.lblKiesKaas.Location = new System.Drawing.Point(24, 22);
            this.lblKiesKaas.Name = "lblKiesKaas";
            this.lblKiesKaas.Size = new System.Drawing.Size(144, 23);
            this.lblKiesKaas.TabIndex = 2;
            this.lblKiesKaas.Text = "Kies uw kaas:";
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.Bisque;
            this.btnAnnuleren.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnnuleren.Location = new System.Drawing.Point(196, 68);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(178, 50);
            this.btnAnnuleren.TabIndex = 19;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.BackColor = System.Drawing.Color.Bisque;
            this.btnVerwijderen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerwijderen.Location = new System.Drawing.Point(12, 68);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(178, 50);
            this.btnVerwijderen.TabIndex = 18;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = false;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // FrmVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 136);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.cmbKiesKaas);
            this.Controls.Add(this.lblKiesKaas);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmVerwijderen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verwijderen";
            this.Load += new System.EventHandler(this.FrmVerwijderen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKiesKaas;
        private System.Windows.Forms.Label lblKiesKaas;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnVerwijderen;
    }
}
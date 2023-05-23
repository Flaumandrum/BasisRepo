namespace _17_ProjSchoolreis.MijnForms
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
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.lblKies = new System.Windows.Forms.Label();
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(42, 76);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(312, 32);
            this.cmbKies.TabIndex = 27;
            // 
            // lblKies
            // 
            this.lblKies.Location = new System.Drawing.Point(38, 18);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(316, 55);
            this.lblKies.TabIndex = 26;
            this.lblKies.Text = "Kies de persoon van wie u de score wilt aanpassen: ";
            // 
            // btnAnnuleer
            // 
            this.btnAnnuleer.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAnnuleer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuleer.Location = new System.Drawing.Point(209, 140);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(145, 52);
            this.btnAnnuleer.TabIndex = 25;
            this.btnAnnuleer.Text = "Annuleren";
            this.btnAnnuleer.UseVisualStyleBackColor = false;
            this.btnAnnuleer.Click += new System.EventHandler(this.btnAnnuleer_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnVerwijderen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerwijderen.Location = new System.Drawing.Point(42, 140);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(145, 52);
            this.btnVerwijderen.TabIndex = 24;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = false;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // FrmVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(393, 226);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.btnVerwijderen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmVerwijderen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verwijder een score:";
            this.Load += new System.EventHandler(this.FrmVerwijderen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.Button btnAnnuleer;
        private System.Windows.Forms.Button btnVerwijderen;
    }
}
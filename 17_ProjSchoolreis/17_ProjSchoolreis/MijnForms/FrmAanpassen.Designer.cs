namespace _17_ProjSchoolreis.MijnForms
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
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.cmbScore = new System.Windows.Forms.ComboBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.TxtAchternaam = new System.Windows.Forms.TextBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.lblKies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnnuleer
            // 
            this.btnAnnuleer.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAnnuleer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuleer.Location = new System.Drawing.Point(204, 313);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(145, 52);
            this.btnAnnuleer.TabIndex = 15;
            this.btnAnnuleer.Text = "Annuleren";
            this.btnAnnuleer.UseVisualStyleBackColor = false;
            this.btnAnnuleer.Click += new System.EventHandler(this.btnAnnuleer_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAanpassen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAanpassen.Location = new System.Drawing.Point(37, 313);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(145, 52);
            this.btnAanpassen.TabIndex = 14;
            this.btnAanpassen.Text = "Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = false;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // cmbScore
            // 
            this.cmbScore.FormattingEnabled = true;
            this.cmbScore.Items.AddRange(new object[] {
            "1 - niet goed",
            "2",
            "3",
            "4",
            "5 - uitstekend"});
            this.cmbScore.Location = new System.Drawing.Point(179, 242);
            this.cmbScore.Name = "cmbScore";
            this.cmbScore.Size = new System.Drawing.Size(170, 32);
            this.cmbScore.TabIndex = 13;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(33, 240);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(112, 24);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "Score op 5: ";
            // 
            // TxtAchternaam
            // 
            this.TxtAchternaam.Location = new System.Drawing.Point(179, 183);
            this.TxtAchternaam.Name = "TxtAchternaam";
            this.TxtAchternaam.Size = new System.Drawing.Size(170, 29);
            this.TxtAchternaam.TabIndex = 11;
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(179, 120);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(170, 29);
            this.txtVoornaam.TabIndex = 10;
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(33, 180);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(122, 24);
            this.lblAchternaam.TabIndex = 9;
            this.lblAchternaam.Text = "Achternaam: ";
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(33, 120);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(108, 24);
            this.lblVoornaam.TabIndex = 8;
            this.lblVoornaam.Text = "Voornaam: ";
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(37, 67);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(312, 32);
            this.cmbKies.TabIndex = 17;
            // 
            // lblKies
            // 
            this.lblKies.Location = new System.Drawing.Point(33, 9);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(316, 55);
            this.lblKies.TabIndex = 16;
            this.lblKies.Text = "Kies de persoon van wie u de score wilt aanpassen: ";
            // 
            // FrmAanpassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(389, 403);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.cmbScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.TxtAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblVoornaam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAanpassen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Een score aanpassen:";
            this.Load += new System.EventHandler(this.FrmAanpassen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuleer;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.ComboBox cmbScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox TxtAchternaam;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Label lblKies;
    }
}
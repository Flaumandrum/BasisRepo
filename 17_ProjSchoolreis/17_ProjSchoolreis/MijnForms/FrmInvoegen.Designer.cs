namespace _17_ProjSchoolreis.MijnForms
{
    partial class FrmInvoegen
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
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.TxtAchternaam = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.cmbScore = new System.Windows.Forms.ComboBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(26, 57);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(108, 24);
            this.lblVoornaam.TabIndex = 0;
            this.lblVoornaam.Text = "Voornaam: ";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(30, 120);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(122, 24);
            this.lblAchternaam.TabIndex = 1;
            this.lblAchternaam.Text = "Achternaam: ";
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(176, 60);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(170, 29);
            this.txtVoornaam.TabIndex = 2;
            // 
            // TxtAchternaam
            // 
            this.TxtAchternaam.Location = new System.Drawing.Point(176, 123);
            this.TxtAchternaam.Name = "TxtAchternaam";
            this.TxtAchternaam.Size = new System.Drawing.Size(170, 29);
            this.TxtAchternaam.TabIndex = 3;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(30, 180);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(112, 24);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score op 5: ";
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
            this.cmbScore.Location = new System.Drawing.Point(176, 182);
            this.cmbScore.Name = "cmbScore";
            this.cmbScore.Size = new System.Drawing.Size(170, 32);
            this.cmbScore.TabIndex = 5;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnToevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToevoegen.Location = new System.Drawing.Point(34, 253);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(145, 52);
            this.btnToevoegen.TabIndex = 6;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = false;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnAnnuleer
            // 
            this.btnAnnuleer.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAnnuleer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuleer.Location = new System.Drawing.Point(201, 253);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(145, 52);
            this.btnAnnuleer.TabIndex = 7;
            this.btnAnnuleer.Text = "Annuleren";
            this.btnAnnuleer.UseVisualStyleBackColor = false;
            this.btnAnnuleer.Click += new System.EventHandler(this.btnAnnuleer_Click);
            // 
            // FrmInvoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(385, 337);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.cmbScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.TxtAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblVoornaam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmInvoegen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score invoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox TxtAchternaam;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ComboBox cmbScore;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnAnnuleer;
    }
}
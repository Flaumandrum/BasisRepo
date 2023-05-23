namespace _17_ProjSchoolreis.MijnForms
{
    partial class FrmTonen
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
            this.lblKeuze = new System.Windows.Forms.Label();
            this.grbKeuze = new System.Windows.Forms.GroupBox();
            this.rbnEnkeleGegevens = new System.Windows.Forms.RadioButton();
            this.rbnAllegegevens = new System.Windows.Forms.RadioButton();
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.lblKies = new System.Windows.Forms.Label();
            this.txtToon = new System.Windows.Forms.TextBox();
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.btnTonen = new System.Windows.Forms.Button();
            this.grbKeuze.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKeuze
            // 
            this.lblKeuze.AutoSize = true;
            this.lblKeuze.Location = new System.Drawing.Point(35, 29);
            this.lblKeuze.Name = "lblKeuze";
            this.lblKeuze.Size = new System.Drawing.Size(141, 24);
            this.lblKeuze.TabIndex = 0;
            this.lblKeuze.Text = "Maak uw keuze";
            // 
            // grbKeuze
            // 
            this.grbKeuze.Controls.Add(this.rbnEnkeleGegevens);
            this.grbKeuze.Controls.Add(this.rbnAllegegevens);
            this.grbKeuze.Location = new System.Drawing.Point(39, 56);
            this.grbKeuze.Name = "grbKeuze";
            this.grbKeuze.Size = new System.Drawing.Size(343, 100);
            this.grbKeuze.TabIndex = 1;
            this.grbKeuze.TabStop = false;
            // 
            // rbnEnkeleGegevens
            // 
            this.rbnEnkeleGegevens.AutoSize = true;
            this.rbnEnkeleGegevens.Location = new System.Drawing.Point(6, 62);
            this.rbnEnkeleGegevens.Name = "rbnEnkeleGegevens";
            this.rbnEnkeleGegevens.Size = new System.Drawing.Size(335, 28);
            this.rbnEnkeleGegevens.TabIndex = 1;
            this.rbnEnkeleGegevens.TabStop = true;
            this.rbnEnkeleGegevens.Text = "Kies zelf een naam en toon de score";
            this.rbnEnkeleGegevens.UseVisualStyleBackColor = true;
            this.rbnEnkeleGegevens.CheckedChanged += new System.EventHandler(this.rbnEnkeleGegevens_CheckedChanged);
            // 
            // rbnAllegegevens
            // 
            this.rbnAllegegevens.AutoSize = true;
            this.rbnAllegegevens.Location = new System.Drawing.Point(6, 28);
            this.rbnAllegegevens.Name = "rbnAllegegevens";
            this.rbnAllegegevens.Size = new System.Drawing.Size(288, 28);
            this.rbnAllegegevens.TabIndex = 0;
            this.rbnAllegegevens.TabStop = true;
            this.rbnAllegegevens.Text = "Toon alle namen en hun score";
            this.rbnAllegegevens.UseVisualStyleBackColor = true;
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(39, 211);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(343, 32);
            this.cmbKies.TabIndex = 29;
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(41, 175);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(141, 24);
            this.lblKies.TabIndex = 28;
            this.lblKies.Text = "Kies een naam:";
            // 
            // txtToon
            // 
            this.txtToon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtToon.Location = new System.Drawing.Point(400, 12);
            this.txtToon.Multiline = true;
            this.txtToon.Name = "txtToon";
            this.txtToon.ReadOnly = true;
            this.txtToon.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtToon.Size = new System.Drawing.Size(385, 423);
            this.txtToon.TabIndex = 30;
            // 
            // btnAnnuleer
            // 
            this.btnAnnuleer.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAnnuleer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuleer.Location = new System.Drawing.Point(237, 260);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(145, 52);
            this.btnAnnuleer.TabIndex = 32;
            this.btnAnnuleer.Text = "Annuleren";
            this.btnAnnuleer.UseVisualStyleBackColor = false;
            // 
            // btnTonen
            // 
            this.btnTonen.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnTonen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTonen.Location = new System.Drawing.Point(39, 260);
            this.btnTonen.Name = "btnTonen";
            this.btnTonen.Size = new System.Drawing.Size(145, 52);
            this.btnTonen.TabIndex = 31;
            this.btnTonen.Text = "Tonen";
            this.btnTonen.UseVisualStyleBackColor = false;
            this.btnTonen.Click += new System.EventHandler(this.btnTonen_Click);
            // 
            // FrmTonen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(797, 447);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.btnTonen);
            this.Controls.Add(this.txtToon);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.Controls.Add(this.grbKeuze);
            this.Controls.Add(this.lblKeuze);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmTonen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raadpleeg de gegevens:";
            this.Load += new System.EventHandler(this.FrmTonen_Load);
            this.grbKeuze.ResumeLayout(false);
            this.grbKeuze.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeuze;
        private System.Windows.Forms.GroupBox grbKeuze;
        private System.Windows.Forms.RadioButton rbnEnkeleGegevens;
        private System.Windows.Forms.RadioButton rbnAllegegevens;
        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.TextBox txtToon;
        private System.Windows.Forms.Button btnAnnuleer;
        private System.Windows.Forms.Button btnTonen;
    }
}
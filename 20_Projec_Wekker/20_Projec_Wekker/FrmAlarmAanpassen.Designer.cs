namespace _20_Projec_Wekker
{
    partial class FrmAlarmAanpassen
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
            this.lblKies = new System.Windows.Forms.Label();
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtUur = new System.Windows.Forms.TextBox();
            this.lblScheiding = new System.Windows.Forms.Label();
            this.lblVraagUur = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.lblVraagDatum = new System.Windows.Forms.Label();
            this.cbxActief = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(42, 23);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(140, 24);
            this.lblKies.TabIndex = 0;
            this.lblKies.Text = "Kies een alarm:";
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(188, 20);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(257, 32);
            this.cmbKies.TabIndex = 1;
            this.cmbKies.SelectedIndexChanged += new System.EventHandler(this.cmbKies_SelectedIndexChanged);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(279, 312);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(166, 35);
            this.btnTerug.TabIndex = 15;
            this.btnTerug.Text = "Annuleren";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.Location = new System.Drawing.Point(46, 312);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(166, 35);
            this.btnAanpassen.TabIndex = 14;
            this.btnAanpassen.Text = "Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = true;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(127, 204);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(54, 29);
            this.txtMin.TabIndex = 13;
            // 
            // txtUur
            // 
            this.txtUur.Location = new System.Drawing.Point(46, 204);
            this.txtUur.Name = "txtUur";
            this.txtUur.Size = new System.Drawing.Size(54, 29);
            this.txtUur.TabIndex = 12;
            // 
            // lblScheiding
            // 
            this.lblScheiding.AutoSize = true;
            this.lblScheiding.Location = new System.Drawing.Point(106, 207);
            this.lblScheiding.Name = "lblScheiding";
            this.lblScheiding.Size = new System.Drawing.Size(15, 24);
            this.lblScheiding.TabIndex = 11;
            this.lblScheiding.Text = ":";
            // 
            // lblVraagUur
            // 
            this.lblVraagUur.AutoSize = true;
            this.lblVraagUur.Location = new System.Drawing.Point(42, 163);
            this.lblVraagUur.Name = "lblVraagUur";
            this.lblVraagUur.Size = new System.Drawing.Size(255, 24);
            this.lblVraagUur.TabIndex = 10;
            this.lblVraagUur.Text = "Geef het uur van uw alram in:";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(46, 112);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(399, 29);
            this.txtDatum.TabIndex = 9;
            // 
            // lblVraagDatum
            // 
            this.lblVraagDatum.AutoSize = true;
            this.lblVraagDatum.Location = new System.Drawing.Point(42, 70);
            this.lblVraagDatum.Name = "lblVraagDatum";
            this.lblVraagDatum.Size = new System.Drawing.Size(403, 24);
            this.lblVraagDatum.TabIndex = 8;
            this.lblVraagDatum.Text = "Geef uw datum in, in vulgende vorm: dd/mm/jjjj";
            // 
            // cbxActief
            // 
            this.cbxActief.AutoSize = true;
            this.cbxActief.Location = new System.Drawing.Point(46, 260);
            this.cbxActief.Name = "cbxActief";
            this.cbxActief.Size = new System.Drawing.Size(126, 28);
            this.cbxActief.TabIndex = 16;
            this.cbxActief.Text = "Alarm actief";
            this.cbxActief.UseVisualStyleBackColor = true;
            // 
            // FrmAlarmAanpassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 376);
            this.Controls.Add(this.cbxActief);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtUur);
            this.Controls.Add(this.lblScheiding);
            this.Controls.Add(this.lblVraagUur);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.lblVraagDatum);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAlarmAanpassen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pas de Alarmen aan:";
            this.Load += new System.EventHandler(this.FrmAlarmAanpassen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtUur;
        private System.Windows.Forms.Label lblScheiding;
        private System.Windows.Forms.Label lblVraagUur;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label lblVraagDatum;
        private System.Windows.Forms.CheckBox cbxActief;
    }
}
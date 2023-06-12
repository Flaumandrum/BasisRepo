namespace _20_Projec_Wekker
{
    partial class FrmAlarmInstellen
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
            this.lblVraagDatum = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.lblVraagUur = new System.Windows.Forms.Label();
            this.lblScheiding = new System.Windows.Forms.Label();
            this.txtUur = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVraagDatum
            // 
            this.lblVraagDatum.AutoSize = true;
            this.lblVraagDatum.Location = new System.Drawing.Point(19, 24);
            this.lblVraagDatum.Name = "lblVraagDatum";
            this.lblVraagDatum.Size = new System.Drawing.Size(403, 24);
            this.lblVraagDatum.TabIndex = 0;
            this.lblVraagDatum.Text = "Geef uw datum in, in vulgende vorm: dd/mm/jjjj";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(23, 66);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(399, 29);
            this.txtDatum.TabIndex = 1;
            // 
            // lblVraagUur
            // 
            this.lblVraagUur.AutoSize = true;
            this.lblVraagUur.Location = new System.Drawing.Point(19, 117);
            this.lblVraagUur.Name = "lblVraagUur";
            this.lblVraagUur.Size = new System.Drawing.Size(255, 24);
            this.lblVraagUur.TabIndex = 2;
            this.lblVraagUur.Text = "Geef het uur van uw alram in:";
            // 
            // lblScheiding
            // 
            this.lblScheiding.AutoSize = true;
            this.lblScheiding.Location = new System.Drawing.Point(83, 161);
            this.lblScheiding.Name = "lblScheiding";
            this.lblScheiding.Size = new System.Drawing.Size(15, 24);
            this.lblScheiding.TabIndex = 3;
            this.lblScheiding.Text = ":";
            // 
            // txtUur
            // 
            this.txtUur.Location = new System.Drawing.Point(23, 158);
            this.txtUur.Name = "txtUur";
            this.txtUur.Size = new System.Drawing.Size(54, 29);
            this.txtUur.TabIndex = 4;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(104, 158);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(54, 29);
            this.txtMin.TabIndex = 5;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(23, 226);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(166, 35);
            this.btnOpslaan.TabIndex = 6;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(256, 226);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(166, 35);
            this.btnTerug.TabIndex = 7;
            this.btnTerug.Text = "Annuleren";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // FrmAlarmInstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 287);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtUur);
            this.Controls.Add(this.lblScheiding);
            this.Controls.Add(this.lblVraagUur);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.lblVraagDatum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAlarmInstellen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stel uw alarm in:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVraagDatum;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label lblVraagUur;
        private System.Windows.Forms.Label lblScheiding;
        private System.Windows.Forms.TextBox txtUur;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnTerug;
    }
}
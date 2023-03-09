namespace _10_ProjKazen
{
    partial class FrmZoekMelk
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
            this.txtToonTekst = new System.Windows.Forms.TextBox();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnZoekMelk = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtMelk = new System.Windows.Forms.TextBox();
            this.lbMelk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtToonTekst
            // 
            this.txtToonTekst.BackColor = System.Drawing.Color.Linen;
            this.txtToonTekst.Location = new System.Drawing.Point(257, 11);
            this.txtToonTekst.Multiline = true;
            this.txtToonTekst.Name = "txtToonTekst";
            this.txtToonTekst.ReadOnly = true;
            this.txtToonTekst.Size = new System.Drawing.Size(577, 466);
            this.txtToonTekst.TabIndex = 20;
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.Bisque;
            this.btnAnnuleren.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnnuleren.Location = new System.Drawing.Point(12, 170);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(216, 50);
            this.btnAnnuleren.TabIndex = 19;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnZoekMelk
            // 
            this.btnZoekMelk.BackColor = System.Drawing.Color.Bisque;
            this.btnZoekMelk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZoekMelk.Location = new System.Drawing.Point(12, 114);
            this.btnZoekMelk.Name = "btnZoekMelk";
            this.btnZoekMelk.Size = new System.Drawing.Size(216, 50);
            this.btnZoekMelk.TabIndex = 18;
            this.btnZoekMelk.Text = "Zoeken";
            this.btnZoekMelk.UseVisualStyleBackColor = false;
            this.btnZoekMelk.Click += new System.EventHandler(this.btnZoekMelk_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Linen;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(246, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(600, 489);
            this.splitter1.TabIndex = 17;
            this.splitter1.TabStop = false;
            // 
            // txtMelk
            // 
            this.txtMelk.Location = new System.Drawing.Point(12, 65);
            this.txtMelk.Name = "txtMelk";
            this.txtMelk.Size = new System.Drawing.Size(216, 31);
            this.txtMelk.TabIndex = 16;
            // 
            // lbMelk
            // 
            this.lbMelk.AutoSize = true;
            this.lbMelk.Location = new System.Drawing.Point(23, 30);
            this.lbMelk.Name = "lbMelk";
            this.lbMelk.Size = new System.Drawing.Size(146, 23);
            this.lbMelk.TabIndex = 15;
            this.lbMelk.Text = "Geef de melk:";
            // 
            // FrmZoekMelk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 489);
            this.Controls.Add(this.txtToonTekst);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnZoekMelk);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtMelk);
            this.Controls.Add(this.lbMelk);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmZoekMelk";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmZoekMelk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToonTekst;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnZoekMelk;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox txtMelk;
        private System.Windows.Forms.Label lbMelk;
    }
}
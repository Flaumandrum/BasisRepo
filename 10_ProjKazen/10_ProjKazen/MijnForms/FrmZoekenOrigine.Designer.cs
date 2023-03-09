namespace _10_ProjKazen.MijnForms
{
    partial class FrmZoekenOrigine
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
            this.lblOrigine = new System.Windows.Forms.Label();
            this.txtOrigine = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnZoekOrigine = new System.Windows.Forms.Button();
            this.txtToonTekst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOrigine
            // 
            this.lblOrigine.AutoSize = true;
            this.lblOrigine.Location = new System.Drawing.Point(23, 30);
            this.lblOrigine.Name = "lblOrigine";
            this.lblOrigine.Size = new System.Drawing.Size(167, 23);
            this.lblOrigine.TabIndex = 0;
            this.lblOrigine.Text = "Geef de origine:";
            // 
            // txtOrigine
            // 
            this.txtOrigine.Location = new System.Drawing.Point(12, 65);
            this.txtOrigine.Name = "txtOrigine";
            this.txtOrigine.Size = new System.Drawing.Size(216, 31);
            this.txtOrigine.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Linen;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(245, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(600, 490);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.Bisque;
            this.btnAnnuleren.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnnuleren.Location = new System.Drawing.Point(12, 170);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(216, 50);
            this.btnAnnuleren.TabIndex = 13;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnZoekOrigine
            // 
            this.btnZoekOrigine.BackColor = System.Drawing.Color.Bisque;
            this.btnZoekOrigine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZoekOrigine.Location = new System.Drawing.Point(12, 114);
            this.btnZoekOrigine.Name = "btnZoekOrigine";
            this.btnZoekOrigine.Size = new System.Drawing.Size(216, 50);
            this.btnZoekOrigine.TabIndex = 12;
            this.btnZoekOrigine.Text = "Zoeken";
            this.btnZoekOrigine.UseVisualStyleBackColor = false;
            this.btnZoekOrigine.Click += new System.EventHandler(this.btnZoekOrigine_Click);
            // 
            // txtToonTekst
            // 
            this.txtToonTekst.BackColor = System.Drawing.Color.Linen;
            this.txtToonTekst.Location = new System.Drawing.Point(256, 12);
            this.txtToonTekst.Multiline = true;
            this.txtToonTekst.Name = "txtToonTekst";
            this.txtToonTekst.ReadOnly = true;
            this.txtToonTekst.Size = new System.Drawing.Size(577, 466);
            this.txtToonTekst.TabIndex = 14;
            // 
            // FrmZoekenOrigine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 490);
            this.Controls.Add(this.txtToonTekst);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnZoekOrigine);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtOrigine);
            this.Controls.Add(this.lblOrigine);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmZoekenOrigine";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoeken op origine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrigine;
        private System.Windows.Forms.TextBox txtOrigine;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnZoekOrigine;
        private System.Windows.Forms.TextBox txtToonTekst;
    }
}
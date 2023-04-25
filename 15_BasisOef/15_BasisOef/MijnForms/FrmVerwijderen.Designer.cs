
namespace _15_BasisOef.MijnForms
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
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.lblKiesZin = new System.Windows.Forms.Label();
            this.cmbKiesZin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(328, 177);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(159, 50);
            this.btnTerug.TabIndex = 4;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(42, 177);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(159, 50);
            this.btnVerwijderen.TabIndex = 3;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // lblKiesZin
            // 
            this.lblKiesZin.AutoSize = true;
            this.lblKiesZin.Location = new System.Drawing.Point(42, 44);
            this.lblKiesZin.Name = "lblKiesZin";
            this.lblKiesZin.Size = new System.Drawing.Size(233, 24);
            this.lblKiesZin.TabIndex = 5;
            this.lblKiesZin.Text = "Kies uw te verwijderen zin:";
            // 
            // cmbKiesZin
            // 
            this.cmbKiesZin.FormattingEnabled = true;
            this.cmbKiesZin.Location = new System.Drawing.Point(42, 92);
            this.cmbKiesZin.Name = "cmbKiesZin";
            this.cmbKiesZin.Size = new System.Drawing.Size(445, 32);
            this.cmbKiesZin.TabIndex = 6;
            // 
            // FrmVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 279);
            this.Controls.Add(this.cmbKiesZin);
            this.Controls.Add(this.lblKiesZin);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnVerwijderen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmVerwijderen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verwijderen van een zin";
            this.Load += new System.EventHandler(this.FrmVerwijderen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Label lblKiesZin;
        private System.Windows.Forms.ComboBox cmbKiesZin;
    }
}
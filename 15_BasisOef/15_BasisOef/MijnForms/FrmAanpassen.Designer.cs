
namespace _15_BasisOef.MijnForms
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
            this.cmbKiesZin = new System.Windows.Forms.ComboBox();
            this.lblKiesZin = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.lblZin = new System.Windows.Forms.Label();
            this.txtZin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbKiesZin
            // 
            this.cmbKiesZin.FormattingEnabled = true;
            this.cmbKiesZin.Location = new System.Drawing.Point(41, 69);
            this.cmbKiesZin.Name = "cmbKiesZin";
            this.cmbKiesZin.Size = new System.Drawing.Size(445, 32);
            this.cmbKiesZin.TabIndex = 10;
            // 
            // lblKiesZin
            // 
            this.lblKiesZin.AutoSize = true;
            this.lblKiesZin.Location = new System.Drawing.Point(37, 21);
            this.lblKiesZin.Name = "lblKiesZin";
            this.lblKiesZin.Size = new System.Drawing.Size(232, 24);
            this.lblKiesZin.TabIndex = 9;
            this.lblKiesZin.Text = "Kies uw aan te passen zin:";
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(323, 249);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(159, 50);
            this.btnTerug.TabIndex = 8;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.Location = new System.Drawing.Point(41, 249);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(159, 50);
            this.btnAanpassen.TabIndex = 7;
            this.btnAanpassen.Text = "Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = true;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // lblZin
            // 
            this.lblZin.AutoSize = true;
            this.lblZin.Location = new System.Drawing.Point(37, 138);
            this.lblZin.Name = "lblZin";
            this.lblZin.Size = new System.Drawing.Size(171, 24);
            this.lblZin.TabIndex = 12;
            this.lblZin.Text = "Geef hier uw zin in:";
            // 
            // txtZin
            // 
            this.txtZin.Location = new System.Drawing.Point(41, 179);
            this.txtZin.Name = "txtZin";
            this.txtZin.Size = new System.Drawing.Size(441, 29);
            this.txtZin.TabIndex = 11;
            // 
            // FrmAanpassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 336);
            this.Controls.Add(this.lblZin);
            this.Controls.Add(this.txtZin);
            this.Controls.Add(this.cmbKiesZin);
            this.Controls.Add(this.lblKiesZin);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnAanpassen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmAanpassen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zinnen aanpassen";
            this.Load += new System.EventHandler(this.FrmAanpassen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKiesZin;
        private System.Windows.Forms.Label lblKiesZin;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.Label lblZin;
        private System.Windows.Forms.TextBox txtZin;
    }
}
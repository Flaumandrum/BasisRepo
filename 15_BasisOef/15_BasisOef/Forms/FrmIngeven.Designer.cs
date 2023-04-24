namespace _15_BasisOef
{
    partial class FrmIngeven
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
            this.btnIngeven = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.txtZin = new System.Windows.Forms.TextBox();
            this.lblZin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngeven
            // 
            this.btnIngeven.Location = new System.Drawing.Point(30, 101);
            this.btnIngeven.Name = "btnIngeven";
            this.btnIngeven.Size = new System.Drawing.Size(159, 50);
            this.btnIngeven.TabIndex = 1;
            this.btnIngeven.Text = "Ingeven";
            this.btnIngeven.UseVisualStyleBackColor = true;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(406, 101);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(159, 50);
            this.btnTerug.TabIndex = 2;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            // 
            // txtZin
            // 
            this.txtZin.Location = new System.Drawing.Point(203, 31);
            this.txtZin.Name = "txtZin";
            this.txtZin.Size = new System.Drawing.Size(362, 29);
            this.txtZin.TabIndex = 4;
            // 
            // lblZin
            // 
            this.lblZin.AutoSize = true;
            this.lblZin.Location = new System.Drawing.Point(26, 36);
            this.lblZin.Name = "lblZin";
            this.lblZin.Size = new System.Drawing.Size(171, 24);
            this.lblZin.TabIndex = 5;
            this.lblZin.Text = "Geef hier uw zin in:";
            // 
            // FrmIngeven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 185);
            this.Controls.Add(this.lblZin);
            this.Controls.Add(this.txtZin);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnIngeven);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmIngeven";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vul alle gegevens in:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngeven;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.TextBox txtZin;
        private System.Windows.Forms.Label lblZin;
    }
}
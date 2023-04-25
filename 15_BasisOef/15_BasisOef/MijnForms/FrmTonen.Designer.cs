namespace _15_BasisOef
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
            this.btnTerug = new System.Windows.Forms.Button();
            this.txtToon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 12);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(159, 50);
            this.btnTerug.TabIndex = 1;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // txtToon
            // 
            this.txtToon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtToon.Location = new System.Drawing.Point(12, 79);
            this.txtToon.Multiline = true;
            this.txtToon.Name = "txtToon";
            this.txtToon.ReadOnly = true;
            this.txtToon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtToon.Size = new System.Drawing.Size(595, 313);
            this.txtToon.TabIndex = 3;
            // 
            // FrmTonen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 404);
            this.Controls.Add(this.txtToon);
            this.Controls.Add(this.btnTerug);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmTonen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hier zijn de zin:";
            this.Load += new System.EventHandler(this.FrmTonen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.TextBox txtToon;
    }
}
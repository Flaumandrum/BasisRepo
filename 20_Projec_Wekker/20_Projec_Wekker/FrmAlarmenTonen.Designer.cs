namespace _20_Projec_Wekker
{
    partial class FrmAlarmenTonen
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
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnIngeven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(40, 312);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(127, 41);
            this.btnTerug.TabIndex = 0;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // txtToon
            // 
            this.txtToon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtToon.Location = new System.Drawing.Point(40, 37);
            this.txtToon.Multiline = true;
            this.txtToon.Name = "txtToon";
            this.txtToon.ReadOnly = true;
            this.txtToon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtToon.Size = new System.Drawing.Size(702, 254);
            this.txtToon.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(40, 37);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(226, 24);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Typ volgende code over: ";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(44, 74);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(222, 29);
            this.txtCode.TabIndex = 3;
            // 
            // btnIngeven
            // 
            this.btnIngeven.Location = new System.Drawing.Point(44, 119);
            this.btnIngeven.Name = "btnIngeven";
            this.btnIngeven.Size = new System.Drawing.Size(123, 34);
            this.btnIngeven.TabIndex = 4;
            this.btnIngeven.Text = "Ingeven";
            this.btnIngeven.UseVisualStyleBackColor = true;
            this.btnIngeven.Click += new System.EventHandler(this.btnIngeven_Click);
            // 
            // FrmAlarmenTonen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 371);
            this.Controls.Add(this.btnIngeven);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtToon);
            this.Controls.Add(this.btnTerug);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAlarmenTonen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alarmen: ";
            this.Load += new System.EventHandler(this.FrmAlarmenTonen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.TextBox txtToon;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnIngeven;
    }
}
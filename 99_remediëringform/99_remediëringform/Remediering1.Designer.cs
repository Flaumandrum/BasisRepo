namespace _99_remediëringform
{
    partial class Remediering1
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
            this.txtnaam = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.btnActie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnaam
            // 
            this.txtnaam.Location = new System.Drawing.Point(196, 56);
            this.txtnaam.Name = "txtnaam";
            this.txtnaam.Size = new System.Drawing.Size(100, 20);
            this.txtnaam.TabIndex = 0;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(64, 56);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(79, 13);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Geef uw naam:";
            // 
            // btnActie
            // 
            this.btnActie.Location = new System.Drawing.Point(67, 115);
            this.btnActie.Name = "btnActie";
            this.btnActie.Size = new System.Drawing.Size(126, 31);
            this.btnActie.TabIndex = 2;
            this.btnActie.Text = "Zeg Hallo";
            this.btnActie.UseVisualStyleBackColor = true;
            this.btnActie.Click += new System.EventHandler(this.btnActie_Click);
            // 
            // Remediering1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 196);
            this.Controls.Add(this.btnActie);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.txtnaam);
            this.Name = "Remediering1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnaam;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Button btnActie;
    }
}


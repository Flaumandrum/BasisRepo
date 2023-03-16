namespace EersteKlassePersoon
{
    partial class FrmStart
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
            this.btnNaam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNaam
            // 
            this.btnNaam.Location = new System.Drawing.Point(332, 205);
            this.btnNaam.Name = "btnNaam";
            this.btnNaam.Size = new System.Drawing.Size(75, 23);
            this.btnNaam.TabIndex = 0;
            this.btnNaam.Text = "Druk Hier";
            this.btnNaam.UseVisualStyleBackColor = true;
            this.btnNaam.Click += new System.EventHandler(this.btnNaam_Click);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNaam);
            this.Name = "FrmStart";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNaam;
    }
}


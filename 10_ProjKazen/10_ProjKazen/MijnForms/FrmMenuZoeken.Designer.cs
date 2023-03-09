namespace _10_ProjKazen.MijnForms
{
    partial class FrmMenuZoeken
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
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnZoekMelk = new System.Windows.Forms.Button();
            this.btnZoekOrigine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.Bisque;
            this.btnAnnuleren.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnnuleren.Location = new System.Drawing.Point(24, 123);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(216, 50);
            this.btnAnnuleren.TabIndex = 11;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnZoekMelk
            // 
            this.btnZoekMelk.BackColor = System.Drawing.Color.Bisque;
            this.btnZoekMelk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZoekMelk.Location = new System.Drawing.Point(24, 67);
            this.btnZoekMelk.Name = "btnZoekMelk";
            this.btnZoekMelk.Size = new System.Drawing.Size(216, 50);
            this.btnZoekMelk.TabIndex = 10;
            this.btnZoekMelk.Text = "Zoek op melk ";
            this.btnZoekMelk.UseVisualStyleBackColor = false;
            this.btnZoekMelk.Click += new System.EventHandler(this.btnZoekMelk_Click);
            // 
            // btnZoekOrigine
            // 
            this.btnZoekOrigine.BackColor = System.Drawing.Color.Bisque;
            this.btnZoekOrigine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZoekOrigine.Location = new System.Drawing.Point(24, 12);
            this.btnZoekOrigine.Name = "btnZoekOrigine";
            this.btnZoekOrigine.Size = new System.Drawing.Size(216, 50);
            this.btnZoekOrigine.TabIndex = 9;
            this.btnZoekOrigine.Text = "Zoek op origine";
            this.btnZoekOrigine.UseVisualStyleBackColor = false;
            this.btnZoekOrigine.Click += new System.EventHandler(this.btnZoekOrigine_Click);
            // 
            // FrmMenuZoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 184);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnZoekMelk);
            this.Controls.Add(this.btnZoekOrigine);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmMenuZoeken";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kies uit onderstaand menu:";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnZoekMelk;
        private System.Windows.Forms.Button btnZoekOrigine;
    }
}
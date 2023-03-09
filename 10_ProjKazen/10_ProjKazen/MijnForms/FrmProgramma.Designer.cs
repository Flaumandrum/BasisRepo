namespace _10_ProjKazen.MijnForms
{
    partial class FrmProgramma
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
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.BackColor = System.Drawing.Color.Bisque;
            this.btnToevoegen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnToevoegen.Location = new System.Drawing.Point(25, 12);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(216, 50);
            this.btnToevoegen.TabIndex = 4;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = false;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.BackColor = System.Drawing.Color.Bisque;
            this.btnAanpassen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAanpassen.Location = new System.Drawing.Point(25, 68);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(216, 50);
            this.btnAanpassen.TabIndex = 5;
            this.btnAanpassen.Text = "Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = false;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.BackColor = System.Drawing.Color.Bisque;
            this.btnVerwijderen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerwijderen.Location = new System.Drawing.Point(25, 124);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(216, 50);
            this.btnVerwijderen.TabIndex = 6;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = false;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnZoeken
            // 
            this.btnZoeken.BackColor = System.Drawing.Color.Bisque;
            this.btnZoeken.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZoeken.Location = new System.Drawing.Point(25, 179);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(216, 50);
            this.btnZoeken.TabIndex = 7;
            this.btnZoeken.Text = "Zoeken";
            this.btnZoeken.UseVisualStyleBackColor = false;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.Bisque;
            this.btnAnnuleren.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnnuleren.Location = new System.Drawing.Point(25, 235);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(216, 50);
            this.btnAnnuleren.TabIndex = 8;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // FrmProgramma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 298);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.btnToevoegen);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmProgramma";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maak uw keuze:";
            this.Load += new System.EventHandler(this.FrmProgramma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.Button btnAnnuleren;
    }
}
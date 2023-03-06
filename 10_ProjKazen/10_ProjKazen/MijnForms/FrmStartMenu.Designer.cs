namespace _10_ProjKazen.MijnForms
{
    partial class FrmStartMenu
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
            this.btnInstellingen = new System.Windows.Forms.Button();
            this.btnProgramma = new System.Windows.Forms.Button();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInstellingen
            // 
            this.btnInstellingen.BackColor = System.Drawing.Color.Bisque;
            this.btnInstellingen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInstellingen.Location = new System.Drawing.Point(31, 26);
            this.btnInstellingen.Name = "btnInstellingen";
            this.btnInstellingen.Size = new System.Drawing.Size(216, 50);
            this.btnInstellingen.TabIndex = 1;
            this.btnInstellingen.Text = "Instellingen";
            this.btnInstellingen.UseVisualStyleBackColor = false;
            this.btnInstellingen.Click += new System.EventHandler(this.btnInstellingen_Click);
            // 
            // btnProgramma
            // 
            this.btnProgramma.BackColor = System.Drawing.Color.Bisque;
            this.btnProgramma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProgramma.Location = new System.Drawing.Point(31, 91);
            this.btnProgramma.Name = "btnProgramma";
            this.btnProgramma.Size = new System.Drawing.Size(216, 50);
            this.btnProgramma.TabIndex = 2;
            this.btnProgramma.Text = "Programma";
            this.btnProgramma.UseVisualStyleBackColor = false;
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.BackColor = System.Drawing.Color.Bisque;
            this.btnAfsluiten.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAfsluiten.Location = new System.Drawing.Point(31, 157);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(216, 50);
            this.btnAfsluiten.TabIndex = 3;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = false;
            // 
            // FrmStartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 236);
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnProgramma);
            this.Controls.Add(this.btnInstellingen);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmStartMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmStartMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInstellingen;
        private System.Windows.Forms.Button btnProgramma;
        private System.Windows.Forms.Button btnAfsluiten;
    }
}
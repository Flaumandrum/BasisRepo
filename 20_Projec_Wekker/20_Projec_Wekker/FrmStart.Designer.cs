namespace _20_Projec_Wekker
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
            this.btnHuidigeTijd = new System.Windows.Forms.Button();
            this.btnAlarmInstellen = new System.Windows.Forms.Button();
            this.btnAlarmAanpassen = new System.Windows.Forms.Button();
            this.btnAlarmVerwijderen = new System.Windows.Forms.Button();
            this.btnAlarmTonen = new System.Windows.Forms.Button();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHuidigeTijd
            // 
            this.btnHuidigeTijd.Location = new System.Drawing.Point(23, 25);
            this.btnHuidigeTijd.Name = "btnHuidigeTijd";
            this.btnHuidigeTijd.Size = new System.Drawing.Size(227, 50);
            this.btnHuidigeTijd.TabIndex = 0;
            this.btnHuidigeTijd.Text = "Huidige tijd";
            this.btnHuidigeTijd.UseVisualStyleBackColor = true;
            this.btnHuidigeTijd.Click += new System.EventHandler(this.btnHuidigeTijd_Click);
            // 
            // btnAlarmInstellen
            // 
            this.btnAlarmInstellen.Location = new System.Drawing.Point(23, 81);
            this.btnAlarmInstellen.Name = "btnAlarmInstellen";
            this.btnAlarmInstellen.Size = new System.Drawing.Size(227, 50);
            this.btnAlarmInstellen.TabIndex = 1;
            this.btnAlarmInstellen.Text = "Alarm instellen";
            this.btnAlarmInstellen.UseVisualStyleBackColor = true;
            this.btnAlarmInstellen.Click += new System.EventHandler(this.btnAlarmInstellen_Click);
            // 
            // btnAlarmAanpassen
            // 
            this.btnAlarmAanpassen.Location = new System.Drawing.Point(23, 137);
            this.btnAlarmAanpassen.Name = "btnAlarmAanpassen";
            this.btnAlarmAanpassen.Size = new System.Drawing.Size(227, 50);
            this.btnAlarmAanpassen.TabIndex = 2;
            this.btnAlarmAanpassen.Text = "Alarm aanpassen";
            this.btnAlarmAanpassen.UseVisualStyleBackColor = true;
            this.btnAlarmAanpassen.Click += new System.EventHandler(this.btnAlarmAanpassen_Click);
            // 
            // btnAlarmVerwijderen
            // 
            this.btnAlarmVerwijderen.Location = new System.Drawing.Point(23, 193);
            this.btnAlarmVerwijderen.Name = "btnAlarmVerwijderen";
            this.btnAlarmVerwijderen.Size = new System.Drawing.Size(227, 50);
            this.btnAlarmVerwijderen.TabIndex = 5;
            this.btnAlarmVerwijderen.Text = "Alarm verwijderen";
            this.btnAlarmVerwijderen.UseVisualStyleBackColor = true;
            this.btnAlarmVerwijderen.Click += new System.EventHandler(this.btnAlarmVerwijderen_Click);
            // 
            // btnAlarmTonen
            // 
            this.btnAlarmTonen.Location = new System.Drawing.Point(23, 249);
            this.btnAlarmTonen.Name = "btnAlarmTonen";
            this.btnAlarmTonen.Size = new System.Drawing.Size(227, 50);
            this.btnAlarmTonen.TabIndex = 4;
            this.btnAlarmTonen.Text = "Alarm tonen";
            this.btnAlarmTonen.UseVisualStyleBackColor = true;
            this.btnAlarmTonen.Click += new System.EventHandler(this.btnAlarmTonen_Click);
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Location = new System.Drawing.Point(23, 305);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(227, 50);
            this.btnAfsluiten.TabIndex = 3;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 381);
            this.Controls.Add(this.btnAlarmVerwijderen);
            this.Controls.Add(this.btnAlarmTonen);
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnAlarmAanpassen);
            this.Controls.Add(this.btnAlarmInstellen);
            this.Controls.Add(this.btnHuidigeTijd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmStart";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maak uw keuze:";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHuidigeTijd;
        private System.Windows.Forms.Button btnAlarmInstellen;
        private System.Windows.Forms.Button btnAlarmAanpassen;
        private System.Windows.Forms.Button btnAlarmVerwijderen;
        private System.Windows.Forms.Button btnAlarmTonen;
        private System.Windows.Forms.Button btnAfsluiten;
    }
}


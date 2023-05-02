namespace _15_BasisOef
{
    partial class FrmMenu
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
            this.btnTonen = new System.Windows.Forms.Button();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngeven
            // 
            this.btnIngeven.Location = new System.Drawing.Point(36, 27);
            this.btnIngeven.Name = "btnIngeven";
            this.btnIngeven.Size = new System.Drawing.Size(159, 50);
            this.btnIngeven.TabIndex = 1;
            this.btnIngeven.Text = "Ingeven";
            this.btnIngeven.UseVisualStyleBackColor = true;
            this.btnIngeven.Click += new System.EventHandler(this.btnIngeven_Click);
            // 
            // btnTonen
            // 
            this.btnTonen.Location = new System.Drawing.Point(201, 27);
            this.btnTonen.Name = "btnTonen";
            this.btnTonen.Size = new System.Drawing.Size(159, 50);
            this.btnTonen.TabIndex = 2;
            this.btnTonen.Text = "Tonen";
            this.btnTonen.UseVisualStyleBackColor = true;
            this.btnTonen.Click += new System.EventHandler(this.btnTonen_Click);
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Location = new System.Drawing.Point(36, 139);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(159, 50);
            this.btnAfsluiten.TabIndex = 5;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(201, 83);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(159, 50);
            this.btnVerwijderen.TabIndex = 4;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.Location = new System.Drawing.Point(36, 83);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(159, 50);
            this.btnAanpassen.TabIndex = 3;
            this.btnAanpassen.Text = "Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = true;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 216);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnTonen);
            this.Controls.Add(this.btnIngeven);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maak uw keuze:";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngeven;
        private System.Windows.Forms.Button btnTonen;
        private System.Windows.Forms.Button btnAfsluiten;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnAanpassen;
    }
}


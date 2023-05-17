namespace _17_ProjSchoolreis
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
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.btnTonen = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.btnInvoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAfsluiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfsluiten.Location = new System.Drawing.Point(54, 187);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(222, 35);
            this.btnAfsluiten.TabIndex = 9;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = false;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // btnTonen
            // 
            this.btnTonen.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnTonen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTonen.Location = new System.Drawing.Point(54, 146);
            this.btnTonen.Name = "btnTonen";
            this.btnTonen.Size = new System.Drawing.Size(222, 35);
            this.btnTonen.TabIndex = 8;
            this.btnTonen.Text = "Scores Tonen";
            this.btnTonen.UseVisualStyleBackColor = false;
            this.btnTonen.Click += new System.EventHandler(this.btnTonen_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnVerwijderen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerwijderen.Location = new System.Drawing.Point(54, 105);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(222, 35);
            this.btnVerwijderen.TabIndex = 7;
            this.btnVerwijderen.Text = "Score Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = false;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAanpassen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAanpassen.Location = new System.Drawing.Point(54, 64);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(222, 35);
            this.btnAanpassen.TabIndex = 6;
            this.btnAanpassen.Text = "Scores Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = false;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // btnInvoegen
            // 
            this.btnInvoegen.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnInvoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoegen.Location = new System.Drawing.Point(54, 23);
            this.btnInvoegen.Name = "btnInvoegen";
            this.btnInvoegen.Size = new System.Drawing.Size(222, 35);
            this.btnInvoegen.TabIndex = 5;
            this.btnInvoegen.Text = "Scores Ingeven";
            this.btnInvoegen.UseVisualStyleBackColor = false;
            this.btnInvoegen.Click += new System.EventHandler(this.btnInvoegen_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(330, 247);
            this.ControlBox = false;
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnTonen);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.btnInvoegen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maak uw keuze uit onderstaand menu:";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfsluiten;
        private System.Windows.Forms.Button btnTonen;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.Button btnInvoegen;
    }
}


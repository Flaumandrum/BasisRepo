namespace _18_ProjDobbelsteen
{
    partial class Rollen
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
            this.lblOgen = new System.Windows.Forms.Label();
            this.lblAantal = new System.Windows.Forms.Label();
            this.txtOgen = new System.Windows.Forms.TextBox();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.btnRollen = new System.Windows.Forms.Button();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOgen
            // 
            this.lblOgen.AutoSize = true;
            this.lblOgen.Location = new System.Drawing.Point(32, 63);
            this.lblOgen.Name = "lblOgen";
            this.lblOgen.Size = new System.Drawing.Size(328, 24);
            this.lblOgen.TabIndex = 0;
            this.lblOgen.Text = "Hoeveel ogen heeft de dobbelsteen?:";
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(32, 117);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(311, 24);
            this.lblAantal.TabIndex = 1;
            this.lblAantal.Text = "Hoeveel dobbelstenen wilt u rollen?";
            // 
            // txtOgen
            // 
            this.txtOgen.Location = new System.Drawing.Point(391, 63);
            this.txtOgen.Name = "txtOgen";
            this.txtOgen.Size = new System.Drawing.Size(123, 29);
            this.txtOgen.TabIndex = 2;
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(391, 117);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(123, 29);
            this.txtAantal.TabIndex = 3;
            // 
            // txtResultaat
            // 
            this.txtResultaat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResultaat.Location = new System.Drawing.Point(191, 177);
            this.txtResultaat.Multiline = true;
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.ReadOnly = true;
            this.txtResultaat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultaat.Size = new System.Drawing.Size(323, 134);
            this.txtResultaat.TabIndex = 4;
            // 
            // btnRollen
            // 
            this.btnRollen.Location = new System.Drawing.Point(36, 200);
            this.btnRollen.Name = "btnRollen";
            this.btnRollen.Size = new System.Drawing.Size(119, 42);
            this.btnRollen.TabIndex = 5;
            this.btnRollen.Text = "Rollen";
            this.btnRollen.UseVisualStyleBackColor = true;
            this.btnRollen.Click += new System.EventHandler(this.btnRollen_Click);
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Location = new System.Drawing.Point(36, 248);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(119, 42);
            this.btnAfsluiten.TabIndex = 6;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            // 
            // Rollen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 344);
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnRollen);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.txtOgen);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.lblOgen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Rollen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vul onderstaande gegevens in:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgen;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.TextBox txtOgen;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.TextBox txtResultaat;
        private System.Windows.Forms.Button btnRollen;
        private System.Windows.Forms.Button btnAfsluiten;
    }
}


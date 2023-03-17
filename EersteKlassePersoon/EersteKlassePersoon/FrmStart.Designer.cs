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
            this.button1 = new System.Windows.Forms.Button();
            this.lblVn = new System.Windows.Forms.Label();
            this.txtVn = new System.Windows.Forms.TextBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.lblAn = new System.Windows.Forms.Label();
            this.txtGD = new System.Windows.Forms.TextBox();
            this.lblGD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNaam
            // 
            this.btnNaam.Location = new System.Drawing.Point(469, 171);
            this.btnNaam.Name = "btnNaam";
            this.btnNaam.Size = new System.Drawing.Size(140, 23);
            this.btnNaam.TabIndex = 0;
            this.btnNaam.Text = "Toon gegevens";
            this.btnNaam.UseVisualStyleBackColor = true;
            this.btnNaam.Click += new System.EventHandler(this.btnNaam_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Opslaan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblVn
            // 
            this.lblVn.AutoSize = true;
            this.lblVn.Location = new System.Drawing.Point(68, 72);
            this.lblVn.Name = "lblVn";
            this.lblVn.Size = new System.Drawing.Size(58, 13);
            this.lblVn.TabIndex = 2;
            this.lblVn.Text = "Voornaam:";
            // 
            // txtVn
            // 
            this.txtVn.Location = new System.Drawing.Point(197, 64);
            this.txtVn.Name = "txtVn";
            this.txtVn.Size = new System.Drawing.Size(100, 20);
            this.txtVn.TabIndex = 3;
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(197, 90);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(100, 20);
            this.txtAn.TabIndex = 5;
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(68, 98);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(64, 13);
            this.lblAn.TabIndex = 4;
            this.lblAn.Text = "Achternaam";
            // 
            // txtGD
            // 
            this.txtGD.Location = new System.Drawing.Point(197, 116);
            this.txtGD.Name = "txtGD";
            this.txtGD.Size = new System.Drawing.Size(100, 20);
            this.txtGD.TabIndex = 7;
            this.txtGD.Text = "dd/mm/jjjj";
            // 
            // lblGD
            // 
            this.lblGD.AutoSize = true;
            this.lblGD.Location = new System.Drawing.Point(68, 124);
            this.lblGD.Name = "lblGD";
            this.lblGD.Size = new System.Drawing.Size(46, 13);
            this.lblGD.TabIndex = 6;
            this.lblGD.Text = "Opslaan";
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGD);
            this.Controls.Add(this.lblGD);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.txtVn);
            this.Controls.Add(this.lblVn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNaam);
            this.Name = "FrmStart";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNaam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblVn;
        private System.Windows.Forms.TextBox txtVn;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.TextBox txtGD;
        private System.Windows.Forms.Label lblGD;
    }
}


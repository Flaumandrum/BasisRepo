namespace _10_ProjKazen.MijnForms
{
    partial class FrmInstellingen
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
            this.lblArrayAanpassen = new System.Windows.Forms.Label();
            this.txtArrayAanpassen = new System.Windows.Forms.TextBox();
            this.btnArrayAanpassen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArrayAanpassen
            // 
            this.lblArrayAanpassen.AutoSize = true;
            this.lblArrayAanpassen.Location = new System.Drawing.Point(28, 18);
            this.lblArrayAanpassen.Name = "lblArrayAanpassen";
            this.lblArrayAanpassen.Size = new System.Drawing.Size(300, 23);
            this.lblArrayAanpassen.TabIndex = 0;
            this.lblArrayAanpassen.Text = "Hoeveel kazen wilt u opslaan?";
            // 
            // txtArrayAanpassen
            // 
            this.txtArrayAanpassen.Location = new System.Drawing.Point(32, 63);
            this.txtArrayAanpassen.Name = "txtArrayAanpassen";
            this.txtArrayAanpassen.Size = new System.Drawing.Size(296, 31);
            this.txtArrayAanpassen.TabIndex = 1;
            // 
            // btnArrayAanpassen
            // 
            this.btnArrayAanpassen.Location = new System.Drawing.Point(32, 118);
            this.btnArrayAanpassen.Name = "btnArrayAanpassen";
            this.btnArrayAanpassen.Size = new System.Drawing.Size(296, 43);
            this.btnArrayAanpassen.TabIndex = 2;
            this.btnArrayAanpassen.Text = "Ingeven";
            this.btnArrayAanpassen.UseVisualStyleBackColor = true;
            this.btnArrayAanpassen.Click += new System.EventHandler(this.btnArrayAanpassen_Click);
            // 
            // FrmInstellingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 191);
            this.Controls.Add(this.btnArrayAanpassen);
            this.Controls.Add(this.txtArrayAanpassen);
            this.Controls.Add(this.lblArrayAanpassen);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FrmInstellingen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInstellingen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArrayAanpassen;
        private System.Windows.Forms.TextBox txtArrayAanpassen;
        private System.Windows.Forms.Button btnArrayAanpassen;
    }
}
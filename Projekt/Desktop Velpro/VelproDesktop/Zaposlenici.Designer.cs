namespace VelproDesktop
{
    partial class Zaposlenici
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
            this.BrisiZap = new System.Windows.Forms.Button();
            this.DodajZap = new System.Windows.Forms.Button();
            this.DodajKor = new System.Windows.Forms.Button();
            this.BrisiKor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BrisiZap
            // 
            this.BrisiZap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.BrisiZap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrisiZap.Location = new System.Drawing.Point(88, 240);
            this.BrisiZap.Name = "BrisiZap";
            this.BrisiZap.Size = new System.Drawing.Size(219, 117);
            this.BrisiZap.TabIndex = 0;
            this.BrisiZap.Text = "Brisi zaposlenika";
            this.BrisiZap.UseVisualStyleBackColor = false;
            this.BrisiZap.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodajZap
            // 
            this.DodajZap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.DodajZap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DodajZap.Location = new System.Drawing.Point(88, 81);
            this.DodajZap.Name = "DodajZap";
            this.DodajZap.Size = new System.Drawing.Size(219, 117);
            this.DodajZap.TabIndex = 1;
            this.DodajZap.Text = "Dodaj zaposlenika";
            this.DodajZap.UseVisualStyleBackColor = false;
            this.DodajZap.Click += new System.EventHandler(this.button2_Click);
            // 
            // DodajKor
            // 
            this.DodajKor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.DodajKor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DodajKor.Location = new System.Drawing.Point(404, 81);
            this.DodajKor.Name = "DodajKor";
            this.DodajKor.Size = new System.Drawing.Size(219, 117);
            this.DodajKor.TabIndex = 2;
            this.DodajKor.Text = "Dodaj korisnika";
            this.DodajKor.UseVisualStyleBackColor = false;
            this.DodajKor.Click += new System.EventHandler(this.DodajKor_Click);
            // 
            // BrisiKor
            // 
            this.BrisiKor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.BrisiKor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrisiKor.Location = new System.Drawing.Point(404, 240);
            this.BrisiKor.Name = "BrisiKor";
            this.BrisiKor.Size = new System.Drawing.Size(219, 117);
            this.BrisiKor.TabIndex = 3;
            this.BrisiKor.Text = "Brisi korisnika";
            this.BrisiKor.UseVisualStyleBackColor = false;
            this.BrisiKor.Click += new System.EventHandler(this.BrisiKor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ažuriraj zaposlenika";
            // 
            // Zaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(721, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrisiKor);
            this.Controls.Add(this.DodajKor);
            this.Controls.Add(this.DodajZap);
            this.Controls.Add(this.BrisiZap);
            this.Name = "Zaposlenici";
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.Zaposlenici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrisiZap;
        private System.Windows.Forms.Button DodajZap;
        private System.Windows.Forms.Button DodajKor;
        private System.Windows.Forms.Button BrisiKor;
        private System.Windows.Forms.Label label1;
    }
}
namespace VelproDesktop
{
    partial class Form1
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
            this.Naslov = new System.Windows.Forms.Label();
            this.lblKorIme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.korIme = new System.Windows.Forms.TextBox();
            this.Lozinka = new System.Windows.Forms.TextBox();
            this.Prijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.Naslov.Location = new System.Drawing.Point(131, 9);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(311, 76);
            this.Naslov.TabIndex = 0;
            this.Naslov.Text = "VELPRO";
            // 
            // lblKorIme
            // 
            this.lblKorIme.AutoSize = true;
            this.lblKorIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.lblKorIme.Location = new System.Drawing.Point(223, 115);
            this.lblKorIme.Name = "lblKorIme";
            this.lblKorIme.Size = new System.Drawing.Size(145, 25);
            this.lblKorIme.TabIndex = 1;
            this.lblKorIme.Text = "Korisničko ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(247, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lozinka:";
            // 
            // korIme
            // 
            this.korIme.Location = new System.Drawing.Point(144, 143);
            this.korIme.Name = "korIme";
            this.korIme.Size = new System.Drawing.Size(298, 20);
            this.korIme.TabIndex = 3;
            // 
            // Lozinka
            // 
            this.Lozinka.Location = new System.Drawing.Point(144, 229);
            this.Lozinka.Name = "Lozinka";
            this.Lozinka.PasswordChar = '*';
            this.Lozinka.Size = new System.Drawing.Size(298, 20);
            this.Lozinka.TabIndex = 4;
            // 
            // Prijava
            // 
            this.Prijava.Location = new System.Drawing.Point(144, 283);
            this.Prijava.Name = "Prijava";
            this.Prijava.Size = new System.Drawing.Size(298, 67);
            this.Prijava.TabIndex = 5;
            this.Prijava.Text = "Prijava";
            this.Prijava.UseVisualStyleBackColor = true;
            this.Prijava.Click += new System.EventHandler(this.Prijava_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(562, 380);
            this.Controls.Add(this.Prijava);
            this.Controls.Add(this.Lozinka);
            this.Controls.Add(this.korIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKorIme);
            this.Controls.Add(this.Naslov);
            this.Name = "Form1";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Label lblKorIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox korIme;
        private System.Windows.Forms.TextBox Lozinka;
        private System.Windows.Forms.Button Prijava;
    }
}


namespace VelproDesktop
{
    partial class DodajZaposlenika
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
            this.components = new System.ComponentModel.Container();
            this.ulogeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t18_DBDataSet6 = new VelproDesktop.T18_DBDataSet6();
            this.ulogeTableAdapter = new VelproDesktop.T18_DBDataSet6TableAdapters.UlogeTableAdapter();
            this.Uredu = new System.Windows.Forms.Button();
            this.Odustani = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.brTel = new System.Windows.Forms.MaskedTextBox();
            this.Ime = new System.Windows.Forms.TextBox();
            this.Prezime = new System.Windows.Forms.TextBox();
            this.korIme = new System.Windows.Forms.TextBox();
            this.Lozinka = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ulogeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // ulogeBindingSource
            // 
            this.ulogeBindingSource.DataMember = "Uloge";
            this.ulogeBindingSource.DataSource = this.t18_DBDataSet6;
            // 
            // t18_DBDataSet6
            // 
            this.t18_DBDataSet6.DataSetName = "T18_DBDataSet6";
            this.t18_DBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ulogeTableAdapter
            // 
            this.ulogeTableAdapter.ClearBeforeFill = true;
            // 
            // Uredu
            // 
            this.Uredu.Location = new System.Drawing.Point(131, 308);
            this.Uredu.Name = "Uredu";
            this.Uredu.Size = new System.Drawing.Size(203, 47);
            this.Uredu.TabIndex = 17;
            this.Uredu.Text = "U redu";
            this.Uredu.UseVisualStyleBackColor = true;
            this.Uredu.Click += new System.EventHandler(this.button1_Click);
            // 
            // Odustani
            // 
            this.Odustani.Location = new System.Drawing.Point(395, 308);
            this.Odustani.Name = "Odustani";
            this.Odustani.Size = new System.Drawing.Size(203, 47);
            this.Odustani.TabIndex = 18;
            this.Odustani.Text = "Odustani";
            this.Odustani.UseVisualStyleBackColor = true;
            this.Odustani.Click += new System.EventHandler(this.Odustani_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(127, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(127, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(127, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Korisničko ime:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(127, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lozinka:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(127, 194);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(127, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Broj telefona:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // brTel
            // 
            this.brTel.AllowDrop = true;
            this.brTel.Location = new System.Drawing.Point(288, 231);
            this.brTel.Mask = "999/000-00-00";
            this.brTel.Name = "brTel";
            this.brTel.Size = new System.Drawing.Size(310, 20);
            this.brTel.TabIndex = 16;
            this.brTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.brTel_MaskInputRejected);
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(288, 60);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(310, 20);
            this.Ime.TabIndex = 9;
            this.Ime.TextChanged += new System.EventHandler(this.Ime_TextChanged);
            // 
            // Prezime
            // 
            this.Prezime.Location = new System.Drawing.Point(288, 96);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(310, 20);
            this.Prezime.TabIndex = 10;
            this.Prezime.TextChanged += new System.EventHandler(this.Prezime_TextChanged);
            // 
            // korIme
            // 
            this.korIme.Location = new System.Drawing.Point(288, 128);
            this.korIme.Name = "korIme";
            this.korIme.Size = new System.Drawing.Size(310, 20);
            this.korIme.TabIndex = 11;
            this.korIme.TextChanged += new System.EventHandler(this.korIme_TextChanged);
            // 
            // Lozinka
            // 
            this.Lozinka.Location = new System.Drawing.Point(288, 161);
            this.Lozinka.Name = "Lozinka";
            this.Lozinka.Size = new System.Drawing.Size(310, 20);
            this.Lozinka.TabIndex = 12;
            this.Lozinka.TextChanged += new System.EventHandler(this.Lozinka_TextChanged);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(288, 196);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(310, 20);
            this.mail.TabIndex = 13;
            this.mail.TextChanged += new System.EventHandler(this.mail_TextChanged);
            // 
            // DodajZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(721, 379);
            this.Controls.Add(this.Odustani);
            this.Controls.Add(this.Uredu);
            this.Controls.Add(this.brTel);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.Lozinka);
            this.Controls.Add(this.korIme);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DodajZaposlenika";
            this.Text = "Dodaj zaposlenika";
            this.Load += new System.EventHandler(this.DodajZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ulogeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private T18_DBDataSet6 t18_DBDataSet6;
        private System.Windows.Forms.BindingSource ulogeBindingSource;
        private T18_DBDataSet6TableAdapters.UlogeTableAdapter ulogeTableAdapter;
        private System.Windows.Forms.Button Uredu;
        private System.Windows.Forms.Button Odustani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox brTel;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.TextBox Prezime;
        private System.Windows.Forms.TextBox korIme;
        private System.Windows.Forms.TextBox Lozinka;
        private System.Windows.Forms.TextBox mail;
    }
}
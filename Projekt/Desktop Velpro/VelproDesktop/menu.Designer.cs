namespace VelproDesktop
{
    partial class menu
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
            this.PregledSkladiste = new System.Windows.Forms.Button();
            this.PregledArhiva = new System.Windows.Forms.Button();
            this.NarucitiDobavljac = new System.Windows.Forms.Button();
            this.PregledAktivne = new System.Windows.Forms.Button();
            this.PregledZelje = new System.Windows.Forms.Button();
            this.Azuriraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PregledSkladiste
            // 
            this.PregledSkladiste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.PregledSkladiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PregledSkladiste.Location = new System.Drawing.Point(528, 73);
            this.PregledSkladiste.Name = "PregledSkladiste";
            this.PregledSkladiste.Size = new System.Drawing.Size(181, 117);
            this.PregledSkladiste.TabIndex = 0;
            this.PregledSkladiste.Text = "Pregled stanja na skladištu";
            this.PregledSkladiste.UseVisualStyleBackColor = false;
            this.PregledSkladiste.Click += new System.EventHandler(this.PregledSkladiste_Click);
            // 
            // PregledArhiva
            // 
            this.PregledArhiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.PregledArhiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PregledArhiva.Location = new System.Drawing.Point(12, 233);
            this.PregledArhiva.Name = "PregledArhiva";
            this.PregledArhiva.Size = new System.Drawing.Size(181, 117);
            this.PregledArhiva.TabIndex = 1;
            this.PregledArhiva.Text = "Pregled arhive narudžbi";
            this.PregledArhiva.UseVisualStyleBackColor = false;
            this.PregledArhiva.Click += new System.EventHandler(this.PregledArhiva_Click);
            // 
            // NarucitiDobavljac
            // 
            this.NarucitiDobavljac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.NarucitiDobavljac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NarucitiDobavljac.Location = new System.Drawing.Point(271, 73);
            this.NarucitiDobavljac.Name = "NarucitiDobavljac";
            this.NarucitiDobavljac.Size = new System.Drawing.Size(181, 117);
            this.NarucitiDobavljac.TabIndex = 2;
            this.NarucitiDobavljac.Text = "Naručiti od dobavljača";
            this.NarucitiDobavljac.UseVisualStyleBackColor = false;
            this.NarucitiDobavljac.Click += new System.EventHandler(this.NarucitiDobavljac_Click);
            // 
            // PregledAktivne
            // 
            this.PregledAktivne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.PregledAktivne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PregledAktivne.Location = new System.Drawing.Point(12, 73);
            this.PregledAktivne.Name = "PregledAktivne";
            this.PregledAktivne.Size = new System.Drawing.Size(181, 117);
            this.PregledAktivne.TabIndex = 3;
            this.PregledAktivne.Text = "Pregled aktivnih narudžbi";
            this.PregledAktivne.UseVisualStyleBackColor = false;
            this.PregledAktivne.Click += new System.EventHandler(this.PregledAktivne_Click);
            // 
            // PregledZelje
            // 
            this.PregledZelje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.PregledZelje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PregledZelje.Location = new System.Drawing.Point(271, 233);
            this.PregledZelje.Name = "PregledZelje";
            this.PregledZelje.Size = new System.Drawing.Size(181, 117);
            this.PregledZelje.TabIndex = 5;
            this.PregledZelje.Text = "Pregled liste želja";
            this.PregledZelje.UseVisualStyleBackColor = false;
            this.PregledZelje.Click += new System.EventHandler(this.PregledZelje_Click);
            // 
            // Azuriraj
            // 
            this.Azuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.Azuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Azuriraj.Location = new System.Drawing.Point(528, 233);
            this.Azuriraj.Name = "Azuriraj";
            this.Azuriraj.Size = new System.Drawing.Size(181, 117);
            this.Azuriraj.TabIndex = 6;
            this.Azuriraj.Text = "Ažuriraj zaposlenike";
            this.Azuriraj.UseVisualStyleBackColor = false;
            this.Azuriraj.Click += new System.EventHandler(this.Azuriraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Izbornik";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(721, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Azuriraj);
            this.Controls.Add(this.PregledZelje);
            this.Controls.Add(this.PregledAktivne);
            this.Controls.Add(this.NarucitiDobavljac);
            this.Controls.Add(this.PregledArhiva);
            this.Controls.Add(this.PregledSkladiste);
            this.Name = "menu";
            this.Text = "Izbornik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_FormClosing);
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PregledSkladiste;
        private System.Windows.Forms.Button PregledArhiva;
        private System.Windows.Forms.Button NarucitiDobavljac;
        private System.Windows.Forms.Button PregledAktivne;
        private System.Windows.Forms.Button PregledZelje;
        private System.Windows.Forms.Button Azuriraj;
        private System.Windows.Forms.Label label1;
    }
}
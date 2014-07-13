namespace VelproDesktop
{
    partial class Dodaj_Narudzbu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Adresa = new System.Windows.Forms.TextBox();
            this.Dobavljac = new System.Windows.Forms.ComboBox();
            this.dobavljaciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.t18_DBDataSet14 = new VelproDesktop.T18_DBDataSet14();
            this.t18_DBDataSet13 = new VelproDesktop.T18_DBDataSet13();
            this.dobavljaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljaciTableAdapter = new VelproDesktop.T18_DBDataSet13TableAdapters.DobavljaciTableAdapter();
            this.dobavljaciTableAdapter1 = new VelproDesktop.T18_DBDataSet14TableAdapters.DobavljaciTableAdapter();
            this.Uredu = new System.Windows.Forms.Button();
            this.Odustani = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.KolicinaArtikla = new System.Windows.Forms.TextBox();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t18_DBDataSet15 = new VelproDesktop.T18_DBDataSet15();
            this.artikliTableAdapter = new VelproDesktop.T18_DBDataSet15TableAdapters.ArtikliTableAdapter();
            this.Naruceno = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dodaj = new System.Windows.Forms.Button();
            this.obrisiSve = new System.Windows.Forms.Button();
            this.obrisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.t18_DBDataSet16 = new VelproDesktop.T18_DBDataSet16();
            this.artikliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.artikliTableAdapter1 = new VelproDesktop.T18_DBDataSet16TableAdapters.ArtikliTableAdapter();
            this.Artikli = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dostupna_kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostupnakolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Naruceno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Artikli)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresa dostave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dobavljač:";
            // 
            // Adresa
            // 
            this.Adresa.Location = new System.Drawing.Point(98, 309);
            this.Adresa.Multiline = true;
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(632, 71);
            this.Adresa.TabIndex = 3;
            // 
            // Dobavljac
            // 
            this.Dobavljac.DataSource = this.dobavljaciBindingSource1;
            this.Dobavljac.DisplayMember = "Naziv_dobavljaca";
            this.Dobavljac.FormattingEnabled = true;
            this.Dobavljac.Location = new System.Drawing.Point(98, 386);
            this.Dobavljac.Name = "Dobavljac";
            this.Dobavljac.Size = new System.Drawing.Size(632, 21);
            this.Dobavljac.TabIndex = 4;
            this.Dobavljac.ValueMember = "ID_dobavljaca";
            // 
            // dobavljaciBindingSource1
            // 
            this.dobavljaciBindingSource1.DataMember = "Dobavljaci";
            this.dobavljaciBindingSource1.DataSource = this.t18_DBDataSet14;
            // 
            // t18_DBDataSet14
            // 
            this.t18_DBDataSet14.DataSetName = "T18_DBDataSet14";
            this.t18_DBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t18_DBDataSet13
            // 
            this.t18_DBDataSet13.DataSetName = "T18_DBDataSet13";
            this.t18_DBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dobavljaciBindingSource
            // 
            this.dobavljaciBindingSource.DataMember = "Dobavljaci";
            this.dobavljaciBindingSource.DataSource = this.t18_DBDataSet13;
            // 
            // dobavljaciTableAdapter
            // 
            this.dobavljaciTableAdapter.ClearBeforeFill = true;
            // 
            // dobavljaciTableAdapter1
            // 
            this.dobavljaciTableAdapter1.ClearBeforeFill = true;
            // 
            // Uredu
            // 
            this.Uredu.Location = new System.Drawing.Point(739, 357);
            this.Uredu.Name = "Uredu";
            this.Uredu.Size = new System.Drawing.Size(104, 23);
            this.Uredu.TabIndex = 5;
            this.Uredu.Text = "U redu";
            this.Uredu.UseVisualStyleBackColor = true;
            this.Uredu.Click += new System.EventHandler(this.Uredu_Click);
            // 
            // Odustani
            // 
            this.Odustani.Location = new System.Drawing.Point(739, 384);
            this.Odustani.Name = "Odustani";
            this.Odustani.Size = new System.Drawing.Size(104, 23);
            this.Odustani.TabIndex = 6;
            this.Odustani.Text = "Odustani";
            this.Odustani.UseVisualStyleBackColor = true;
            this.Odustani.Click += new System.EventHandler(this.Odustani_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(736, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Količina:";
            // 
            // KolicinaArtikla
            // 
            this.KolicinaArtikla.Location = new System.Drawing.Point(739, 109);
            this.KolicinaArtikla.Name = "KolicinaArtikla";
            this.KolicinaArtikla.Size = new System.Drawing.Size(104, 20);
            this.KolicinaArtikla.TabIndex = 9;
            this.KolicinaArtikla.TextChanged += new System.EventHandler(this.KolicinaArtikla_TextChanged);
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this.t18_DBDataSet15;
            // 
            // t18_DBDataSet15
            // 
            this.t18_DBDataSet15.DataSetName = "T18_DBDataSet15";
            this.t18_DBDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // Naruceno
            // 
            this.Naruceno.AllowUserToAddRows = false;
            this.Naruceno.AllowUserToDeleteRows = false;
            this.Naruceno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Naruceno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Naruceno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.Cijena,
            this.Dostupna_kolicina,
            this.Opis,
            this.Kolicina});
            this.Naruceno.Location = new System.Drawing.Point(98, 168);
            this.Naruceno.MultiSelect = false;
            this.Naruceno.Name = "Naruceno";
            this.Naruceno.ReadOnly = true;
            this.Naruceno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Naruceno.Size = new System.Drawing.Size(632, 135);
            this.Naruceno.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Naruceni artikli:";
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(739, 135);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(104, 23);
            this.dodaj.TabIndex = 13;
            this.dodaj.Text = "Dodaj u narudžbu";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // obrisiSve
            // 
            this.obrisiSve.Location = new System.Drawing.Point(736, 247);
            this.obrisiSve.Name = "obrisiSve";
            this.obrisiSve.Size = new System.Drawing.Size(104, 23);
            this.obrisiSve.TabIndex = 14;
            this.obrisiSve.Text = "Obriši sve";
            this.obrisiSve.UseVisualStyleBackColor = true;
            this.obrisiSve.Click += new System.EventHandler(this.obrisiSve_Click);
            // 
            // obrisi
            // 
            this.obrisi.Location = new System.Drawing.Point(736, 218);
            this.obrisi.Name = "obrisi";
            this.obrisi.Size = new System.Drawing.Size(104, 23);
            this.obrisi.TabIndex = 15;
            this.obrisi.Text = "Obriši";
            this.obrisi.UseVisualStyleBackColor = true;
            this.obrisi.Click += new System.EventHandler(this.obrisi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Artikli:";
            // 
            // t18_DBDataSet16
            // 
            this.t18_DBDataSet16.DataSetName = "T18_DBDataSet16";
            this.t18_DBDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliBindingSource1
            // 
            this.artikliBindingSource1.DataMember = "Artikli";
            this.artikliBindingSource1.DataSource = this.t18_DBDataSet16;
            // 
            // artikliTableAdapter1
            // 
            this.artikliTableAdapter1.ClearBeforeFill = true;
            // 
            // Artikli
            // 
            this.Artikli.AllowUserToAddRows = false;
            this.Artikli.AllowUserToDeleteRows = false;
            this.Artikli.AutoGenerateColumns = false;
            this.Artikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Artikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Artikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDartiklaDataGridViewTextBoxColumn,
            this.nazivartiklaDataGridViewTextBoxColumn,
            this.cijenaartiklaDataGridViewTextBoxColumn,
            this.dostupnakolicinaDataGridViewTextBoxColumn,
            this.opisartiklaDataGridViewTextBoxColumn,
            this.Količina});
            this.Artikli.DataSource = this.artikliBindingSource1;
            this.Artikli.Location = new System.Drawing.Point(98, 12);
            this.Artikli.MultiSelect = false;
            this.Artikli.Name = "Artikli";
            this.Artikli.ReadOnly = true;
            this.Artikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Artikli.Size = new System.Drawing.Size(632, 150);
            this.Artikli.TabIndex = 18;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Dostupna_kolicina
            // 
            this.Dostupna_kolicina.HeaderText = "Dostupna količina";
            this.Dostupna_kolicina.Name = "Dostupna_kolicina";
            this.Dostupna_kolicina.ReadOnly = true;
            this.Dostupna_kolicina.Visible = false;
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Visible = false;
            // 
            // Kolicina
            // 
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // iDartiklaDataGridViewTextBoxColumn
            // 
            this.iDartiklaDataGridViewTextBoxColumn.DataPropertyName = "ID_artikla";
            this.iDartiklaDataGridViewTextBoxColumn.HeaderText = "ID artikla";
            this.iDartiklaDataGridViewTextBoxColumn.Name = "iDartiklaDataGridViewTextBoxColumn";
            this.iDartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivartiklaDataGridViewTextBoxColumn
            // 
            this.nazivartiklaDataGridViewTextBoxColumn.DataPropertyName = "Naziv_artikla";
            this.nazivartiklaDataGridViewTextBoxColumn.HeaderText = "Naziv artikla";
            this.nazivartiklaDataGridViewTextBoxColumn.Name = "nazivartiklaDataGridViewTextBoxColumn";
            this.nazivartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaartiklaDataGridViewTextBoxColumn
            // 
            this.cijenaartiklaDataGridViewTextBoxColumn.DataPropertyName = "Cijena_artikla";
            this.cijenaartiklaDataGridViewTextBoxColumn.HeaderText = "Cijena artikla";
            this.cijenaartiklaDataGridViewTextBoxColumn.Name = "cijenaartiklaDataGridViewTextBoxColumn";
            this.cijenaartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dostupnakolicinaDataGridViewTextBoxColumn
            // 
            this.dostupnakolicinaDataGridViewTextBoxColumn.DataPropertyName = "Dostupna_kolicina";
            this.dostupnakolicinaDataGridViewTextBoxColumn.HeaderText = "Dostupna količina";
            this.dostupnakolicinaDataGridViewTextBoxColumn.Name = "dostupnakolicinaDataGridViewTextBoxColumn";
            this.dostupnakolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisartiklaDataGridViewTextBoxColumn
            // 
            this.opisartiklaDataGridViewTextBoxColumn.DataPropertyName = "Opis_artikla";
            this.opisartiklaDataGridViewTextBoxColumn.HeaderText = "Opis artikla";
            this.opisartiklaDataGridViewTextBoxColumn.Name = "opisartiklaDataGridViewTextBoxColumn";
            this.opisartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Količina
            // 
            this.Količina.HeaderText = "Količina_art";
            this.Količina.Name = "Količina";
            this.Količina.ReadOnly = true;
            this.Količina.Visible = false;
            // 
            // Dodaj_Narudzbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(857, 419);
            this.Controls.Add(this.Artikli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.obrisi);
            this.Controls.Add(this.obrisiSve);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Naruceno);
            this.Controls.Add(this.KolicinaArtikla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Odustani);
            this.Controls.Add(this.Uredu);
            this.Controls.Add(this.Dobavljac);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Dodaj_Narudzbu";
            this.Text = "Dodaj narudžbu";
            this.Load += new System.EventHandler(this.Dodaj_Narudzbu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Naruceno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Artikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Adresa;
        private System.Windows.Forms.ComboBox Dobavljac;
        private T18_DBDataSet13 t18_DBDataSet13;
        private System.Windows.Forms.BindingSource dobavljaciBindingSource;
        private T18_DBDataSet13TableAdapters.DobavljaciTableAdapter dobavljaciTableAdapter;
        private T18_DBDataSet14 t18_DBDataSet14;
        private System.Windows.Forms.BindingSource dobavljaciBindingSource1;
        private T18_DBDataSet14TableAdapters.DobavljaciTableAdapter dobavljaciTableAdapter1;
        private System.Windows.Forms.Button Uredu;
        private System.Windows.Forms.Button Odustani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KolicinaArtikla;
        private T18_DBDataSet15 t18_DBDataSet15;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private T18_DBDataSet15TableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.DataGridView Naruceno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button obrisiSve;
        private System.Windows.Forms.Button obrisi;
        private System.Windows.Forms.Label label2;
        private T18_DBDataSet16 t18_DBDataSet16;
        private System.Windows.Forms.BindingSource artikliBindingSource1;
        private T18_DBDataSet16TableAdapters.ArtikliTableAdapter artikliTableAdapter1;
        private System.Windows.Forms.DataGridView Artikli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dostupna_kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostupnakolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
    }
}
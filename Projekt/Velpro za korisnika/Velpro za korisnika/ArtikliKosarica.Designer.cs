namespace Velpro_za_korisnika
{
    partial class ArtikliKosarica
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostupnakolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina_artikla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t18_DBDataSet = new Velpro_za_korisnika.T18_DBDataSet();
            this.artikliTableAdapter = new Velpro_za_korisnika.T18_DBDataSetTableAdapters.ArtikliTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dostupna_kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKosarica = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDartiklaDataGridViewTextBoxColumn,
            this.nazivartiklaDataGridViewTextBoxColumn,
            this.cijenaartiklaDataGridViewTextBoxColumn,
            this.dostupnakolicinaDataGridViewTextBoxColumn,
            this.opisartiklaDataGridViewTextBoxColumn,
            this.Kolicina_artikla});
            this.dataGridView1.DataSource = this.artikliBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(454, 146);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDartiklaDataGridViewTextBoxColumn
            // 
            this.iDartiklaDataGridViewTextBoxColumn.DataPropertyName = "ID_artikla";
            this.iDartiklaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDartiklaDataGridViewTextBoxColumn.Name = "iDartiklaDataGridViewTextBoxColumn";
            this.iDartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDartiklaDataGridViewTextBoxColumn.Width = 30;
            // 
            // nazivartiklaDataGridViewTextBoxColumn
            // 
            this.nazivartiklaDataGridViewTextBoxColumn.DataPropertyName = "Naziv_artikla";
            this.nazivartiklaDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivartiklaDataGridViewTextBoxColumn.Name = "nazivartiklaDataGridViewTextBoxColumn";
            this.nazivartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaartiklaDataGridViewTextBoxColumn
            // 
            this.cijenaartiklaDataGridViewTextBoxColumn.DataPropertyName = "Cijena_artikla";
            this.cijenaartiklaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaartiklaDataGridViewTextBoxColumn.Name = "cijenaartiklaDataGridViewTextBoxColumn";
            this.cijenaartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenaartiklaDataGridViewTextBoxColumn.Width = 60;
            // 
            // dostupnakolicinaDataGridViewTextBoxColumn
            // 
            this.dostupnakolicinaDataGridViewTextBoxColumn.DataPropertyName = "Dostupna_kolicina";
            this.dostupnakolicinaDataGridViewTextBoxColumn.HeaderText = "Dostupna količina";
            this.dostupnakolicinaDataGridViewTextBoxColumn.Name = "dostupnakolicinaDataGridViewTextBoxColumn";
            this.dostupnakolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dostupnakolicinaDataGridViewTextBoxColumn.Width = 120;
            // 
            // opisartiklaDataGridViewTextBoxColumn
            // 
            this.opisartiklaDataGridViewTextBoxColumn.DataPropertyName = "Opis_artikla";
            this.opisartiklaDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisartiklaDataGridViewTextBoxColumn.Name = "opisartiklaDataGridViewTextBoxColumn";
            this.opisartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Kolicina_artikla
            // 
            this.Kolicina_artikla.HeaderText = "Kolicina";
            this.Kolicina_artikla.Name = "Kolicina_artikla";
            this.Kolicina_artikla.ReadOnly = true;
            this.Kolicina_artikla.Visible = false;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this.t18_DBDataSet;
            // 
            // t18_DBDataSet
            // 
            this.t18_DBDataSet.DataSetName = "T18_DBDataSet";
            this.t18_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.Cijena,
            this.Dostupna_kolicina,
            this.Opis,
            this.Kolicina});
            this.dataGridView2.Location = new System.Drawing.Point(12, 208);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(455, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
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
            this.Cijena.Width = 60;
            // 
            // Dostupna_kolicina
            // 
            this.Dostupna_kolicina.HeaderText = "Dostupna Kolicina";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Artikli";
            // 
            // btnKosarica
            // 
            this.btnKosarica.Location = new System.Drawing.Point(473, 73);
            this.btnKosarica.Name = "btnKosarica";
            this.btnKosarica.Size = new System.Drawing.Size(119, 23);
            this.btnKosarica.TabIndex = 3;
            this.btnKosarica.Text = "Prebaci u košaricu";
            this.btnKosarica.UseVisualStyleBackColor = true;
            this.btnKosarica.Click += new System.EventHandler(this.btnKosarica_Click);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(474, 47);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(118, 20);
            this.txtKolicina.TabIndex = 4;
            this.txtKolicina.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Količina";
            // 
            // btnNaruci
            // 
            this.btnNaruci.Enabled = false;
            this.btnNaruci.Location = new System.Drawing.Point(473, 335);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(119, 23);
            this.btnNaruci.TabIndex = 6;
            this.btnNaruci.Text = "Naruči";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(474, 309);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(118, 20);
            this.txtAdresa.TabIndex = 7;
            this.txtAdresa.TextChanged += new System.EventHandler(this.txtAdresa_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adresa dostave";
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(476, 208);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(116, 23);
            this.btnUkloni.TabIndex = 9;
            this.btnUkloni.Text = "Ukloni artikl";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(476, 238);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(116, 23);
            this.btnOcisti.TabIndex = 10;
            this.btnOcisti.Text = "Ukloni sve";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // ArtikliKosarica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 370);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.btnKosarica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ArtikliKosarica";
            this.Text = "Narudžba";
            this.Load += new System.EventHandler(this.ArtikliKosarica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private T18_DBDataSet t18_DBDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private T18_DBDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKosarica;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostupnakolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina_artikla;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dostupna_kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnOcisti;
    }
}
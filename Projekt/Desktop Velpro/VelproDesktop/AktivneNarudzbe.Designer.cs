namespace VelproDesktop
{
    partial class AktivneNarudzbe
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
            this.Narudzbenice = new System.Windows.Forms.DataGridView();
            this.Ispis = new System.Windows.Forms.DataGridView();
            this.NaruciteljIme = new System.Windows.Forms.Label();
            this.fillBy11ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy11ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NaruciteljPrez = new System.Windows.Forms.Label();
            this.Izdaj = new System.Windows.Forms.Button();
            this.t18_DBDataSet17 = new VelproDesktop.T18_DBDataSet17();
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliTableAdapter = new VelproDesktop.T18_DBDataSet17TableAdapters.ArtikliTableAdapter();
            this.iDnarudzbeniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresadostaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumivrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbeniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t18_DBDataSet5 = new VelproDesktop.T18_DBDataSet5();
            this.narudzbeniceTableAdapter = new VelproDesktop.T18_DBDataSet5TableAdapters.NarudzbeniceTableAdapter();
            this.fillBy7ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy7ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.Narudzbenice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ispis)).BeginInit();
            this.fillBy11ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet5)).BeginInit();
            this.fillBy7ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Narudzbenice
            // 
            this.Narudzbenice.AllowUserToAddRows = false;
            this.Narudzbenice.AllowUserToDeleteRows = false;
            this.Narudzbenice.AutoGenerateColumns = false;
            this.Narudzbenice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Narudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Narudzbenice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDnarudzbeniceDataGridViewTextBoxColumn,
            this.adresadostaveDataGridViewTextBoxColumn,
            this.datumivrijemeDataGridViewTextBoxColumn});
            this.Narudzbenice.DataSource = this.narudzbeniceBindingSource;
            this.Narudzbenice.Location = new System.Drawing.Point(12, 58);
            this.Narudzbenice.MultiSelect = false;
            this.Narudzbenice.Name = "Narudzbenice";
            this.Narudzbenice.ReadOnly = true;
            this.Narudzbenice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Narudzbenice.Size = new System.Drawing.Size(697, 146);
            this.Narudzbenice.TabIndex = 0;
            this.Narudzbenice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.Narudzbenice.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Ispis
            // 
            this.Ispis.AllowUserToAddRows = false;
            this.Ispis.AllowUserToDeleteRows = false;
            this.Ispis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Ispis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ispis.Location = new System.Drawing.Point(12, 210);
            this.Ispis.MultiSelect = false;
            this.Ispis.Name = "Ispis";
            this.Ispis.ReadOnly = true;
            this.Ispis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Ispis.Size = new System.Drawing.Size(697, 146);
            this.Ispis.TabIndex = 1;
            this.Ispis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // NaruciteljIme
            // 
            this.NaruciteljIme.AutoSize = true;
            this.NaruciteljIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaruciteljIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.NaruciteljIme.Location = new System.Drawing.Point(287, 9);
            this.NaruciteljIme.Name = "NaruciteljIme";
            this.NaruciteljIme.Size = new System.Drawing.Size(0, 46);
            this.NaruciteljIme.TabIndex = 2;
            // 
            // fillBy11ToolStrip
            // 
            this.fillBy11ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillBy11ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy11ToolStripButton});
            this.fillBy11ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy11ToolStrip.Name = "fillBy11ToolStrip";
            this.fillBy11ToolStrip.Size = new System.Drawing.Size(729, 25);
            this.fillBy11ToolStrip.TabIndex = 3;
            this.fillBy11ToolStrip.Text = "fillBy11ToolStrip";
            this.fillBy11ToolStrip.Visible = false;
            this.fillBy11ToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillBy11ToolStrip_ItemClicked);
            // 
            // fillBy11ToolStripButton
            // 
            this.fillBy11ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy11ToolStripButton.Name = "fillBy11ToolStripButton";
            this.fillBy11ToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.fillBy11ToolStripButton.Text = "FillBy11";
            this.fillBy11ToolStripButton.Click += new System.EventHandler(this.fillBy11ToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naručitelj:";
            // 
            // NaruciteljPrez
            // 
            this.NaruciteljPrez.AutoSize = true;
            this.NaruciteljPrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaruciteljPrez.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.NaruciteljPrez.Location = new System.Drawing.Point(421, 9);
            this.NaruciteljPrez.Name = "NaruciteljPrez";
            this.NaruciteljPrez.Size = new System.Drawing.Size(0, 46);
            this.NaruciteljPrez.TabIndex = 5;
            // 
            // Izdaj
            // 
            this.Izdaj.Location = new System.Drawing.Point(12, 362);
            this.Izdaj.Name = "Izdaj";
            this.Izdaj.Size = new System.Drawing.Size(697, 23);
            this.Izdaj.TabIndex = 6;
            this.Izdaj.Text = "Izdaj otpremnicu";
            this.Izdaj.UseVisualStyleBackColor = true;
            this.Izdaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // t18_DBDataSet17
            // 
            this.t18_DBDataSet17.DataSetName = "T18_DBDataSet17";
            this.t18_DBDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this.t18_DBDataSet17;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // iDnarudzbeniceDataGridViewTextBoxColumn
            // 
            this.iDnarudzbeniceDataGridViewTextBoxColumn.DataPropertyName = "ID_narudzbenice";
            this.iDnarudzbeniceDataGridViewTextBoxColumn.HeaderText = "Šifra narudžbenice";
            this.iDnarudzbeniceDataGridViewTextBoxColumn.Name = "iDnarudzbeniceDataGridViewTextBoxColumn";
            this.iDnarudzbeniceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresadostaveDataGridViewTextBoxColumn
            // 
            this.adresadostaveDataGridViewTextBoxColumn.DataPropertyName = "Adresa_dostave";
            this.adresadostaveDataGridViewTextBoxColumn.HeaderText = "Adresa dostave";
            this.adresadostaveDataGridViewTextBoxColumn.Name = "adresadostaveDataGridViewTextBoxColumn";
            this.adresadostaveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumivrijemeDataGridViewTextBoxColumn
            // 
            this.datumivrijemeDataGridViewTextBoxColumn.DataPropertyName = "Datum_i_vrijeme";
            this.datumivrijemeDataGridViewTextBoxColumn.HeaderText = "Datum i vrijeme";
            this.datumivrijemeDataGridViewTextBoxColumn.Name = "datumivrijemeDataGridViewTextBoxColumn";
            this.datumivrijemeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // narudzbeniceBindingSource
            // 
            this.narudzbeniceBindingSource.DataMember = "Narudzbenice";
            this.narudzbeniceBindingSource.DataSource = this.t18_DBDataSet5;
            // 
            // t18_DBDataSet5
            // 
            this.t18_DBDataSet5.DataSetName = "T18_DBDataSet5";
            this.t18_DBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narudzbeniceTableAdapter
            // 
            this.narudzbeniceTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy7ToolStrip
            // 
            this.fillBy7ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy7ToolStripButton});
            this.fillBy7ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy7ToolStrip.Name = "fillBy7ToolStrip";
            this.fillBy7ToolStrip.Size = new System.Drawing.Size(729, 25);
            this.fillBy7ToolStrip.TabIndex = 7;
            this.fillBy7ToolStrip.Text = "fillBy7ToolStrip";
            this.fillBy7ToolStrip.Visible = false;
            // 
            // fillBy7ToolStripButton
            // 
            this.fillBy7ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy7ToolStripButton.Name = "fillBy7ToolStripButton";
            this.fillBy7ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy7ToolStripButton.Text = "FillBy7";
            this.fillBy7ToolStripButton.Click += new System.EventHandler(this.fillBy7ToolStripButton_Click);
            // 
            // AktivneNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(729, 405);
            this.Controls.Add(this.fillBy7ToolStrip);
            this.Controls.Add(this.Izdaj);
            this.Controls.Add(this.NaruciteljPrez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillBy11ToolStrip);
            this.Controls.Add(this.NaruciteljIme);
            this.Controls.Add(this.Ispis);
            this.Controls.Add(this.Narudzbenice);
            this.Name = "AktivneNarudzbe";
            this.Text = "Aktivne narudžbe";
            this.Load += new System.EventHandler(this.fillBy11ToolStripButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Narudzbenice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ispis)).EndInit();
            this.fillBy11ToolStrip.ResumeLayout(false);
            this.fillBy11ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet5)).EndInit();
            this.fillBy7ToolStrip.ResumeLayout(false);
            this.fillBy7ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Narudzbenice;
        private System.Windows.Forms.DataGridView Ispis;
        private System.Windows.Forms.Label NaruciteljIme;
        private T18_DBDataSet5 t18_DBDataSet5;
        private System.Windows.Forms.BindingSource narudzbeniceBindingSource;
        private T18_DBDataSet5TableAdapters.NarudzbeniceTableAdapter narudzbeniceTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy11ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy11ToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnarudzbeniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresadostaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumivrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NaruciteljPrez;
        private System.Windows.Forms.Button Izdaj;
        private T18_DBDataSet17 t18_DBDataSet17;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private T18_DBDataSet17TableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy7ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy7ToolStripButton;
    }
}
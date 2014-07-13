namespace VelproDesktop
{
    partial class ArhivaNarudzbi
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
            this.NaruciteljIme = new System.Windows.Forms.Label();
            this.NaruciteljPrez = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ispis = new System.Windows.Forms.DataGridView();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.iDnarudzbeniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresadostaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumivrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbeniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t18_DBDataSet9 = new VelproDesktop.T18_DBDataSet9();
            this.narudzbeniceTableAdapter = new VelproDesktop.T18_DBDataSet9TableAdapters.NarudzbeniceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ispis)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naručitelj:";
            // 
            // NaruciteljIme
            // 
            this.NaruciteljIme.AutoSize = true;
            this.NaruciteljIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaruciteljIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.NaruciteljIme.Location = new System.Drawing.Point(282, 9);
            this.NaruciteljIme.Name = "NaruciteljIme";
            this.NaruciteljIme.Size = new System.Drawing.Size(0, 46);
            this.NaruciteljIme.TabIndex = 1;
            // 
            // NaruciteljPrez
            // 
            this.NaruciteljPrez.AutoSize = true;
            this.NaruciteljPrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaruciteljPrez.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.NaruciteljPrez.Location = new System.Drawing.Point(406, 9);
            this.NaruciteljPrez.Name = "NaruciteljPrez";
            this.NaruciteljPrez.Size = new System.Drawing.Size(0, 46);
            this.NaruciteljPrez.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDnarudzbeniceDataGridViewTextBoxColumn,
            this.adresadostaveDataGridViewTextBoxColumn,
            this.datumivrijemeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.narudzbeniceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(697, 151);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Ispis
            // 
            this.Ispis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ispis.Location = new System.Drawing.Point(12, 216);
            this.Ispis.Name = "Ispis";
            this.Ispis.Size = new System.Drawing.Size(697, 151);
            this.Ispis.TabIndex = 4;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(729, 25);
            this.fillByToolStrip.TabIndex = 5;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
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
            this.narudzbeniceBindingSource.DataSource = this.t18_DBDataSet9;
            // 
            // t18_DBDataSet9
            // 
            this.t18_DBDataSet9.DataSetName = "T18_DBDataSet9";
            this.t18_DBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narudzbeniceTableAdapter
            // 
            this.narudzbeniceTableAdapter.ClearBeforeFill = true;
            // 
            // ArhivaNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(729, 387);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.Ispis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NaruciteljPrez);
            this.Controls.Add(this.NaruciteljIme);
            this.Controls.Add(this.label1);
            this.Name = "ArhivaNarudzbi";
            this.Text = "Arhiva narudžbi";
            this.Load += new System.EventHandler(this.fillByToolStripButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ispis)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NaruciteljIme;
        private System.Windows.Forms.Label NaruciteljPrez;
        private System.Windows.Forms.DataGridView dataGridView1;
        private T18_DBDataSet9 t18_DBDataSet9;
        private System.Windows.Forms.BindingSource narudzbeniceBindingSource;
        private T18_DBDataSet9TableAdapters.NarudzbeniceTableAdapter narudzbeniceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnarudzbeniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresadostaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumivrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView Ispis;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}
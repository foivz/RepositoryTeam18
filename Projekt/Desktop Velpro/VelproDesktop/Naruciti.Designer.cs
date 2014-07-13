namespace VelproDesktop
{
    partial class Naruciti
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
            this.narudzbeniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t18_DBDataSet10 = new VelproDesktop.T18_DBDataSet10();
            this.narudzbeniceTableAdapter = new VelproDesktop.T18_DBDataSet10TableAdapters.NarudzbeniceTableAdapter();
            this.t18_DBDataSet11 = new VelproDesktop.T18_DBDataSet11();
            this.narudzbeniceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbeniceTableAdapter1 = new VelproDesktop.T18_DBDataSet11TableAdapters.NarudzbeniceTableAdapter();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Narudzbenice = new System.Windows.Forms.DataGridView();
            this.t18_DBDataSet12 = new VelproDesktop.T18_DBDataSet12();
            this.narudzbeniceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbeniceTableAdapter2 = new VelproDesktop.T18_DBDataSet12TableAdapters.NarudzbeniceTableAdapter();
            this.Odustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Narudzbenice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // narudzbeniceBindingSource
            // 
            this.narudzbeniceBindingSource.DataMember = "Narudzbenice";
            this.narudzbeniceBindingSource.DataSource = this.t18_DBDataSet10;
            // 
            // t18_DBDataSet10
            // 
            this.t18_DBDataSet10.DataSetName = "T18_DBDataSet10";
            this.t18_DBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narudzbeniceTableAdapter
            // 
            this.narudzbeniceTableAdapter.ClearBeforeFill = true;
            // 
            // t18_DBDataSet11
            // 
            this.t18_DBDataSet11.DataSetName = "T18_DBDataSet11";
            this.t18_DBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narudzbeniceBindingSource1
            // 
            this.narudzbeniceBindingSource1.DataMember = "Narudzbenice";
            this.narudzbeniceBindingSource1.DataSource = this.t18_DBDataSet11;
            // 
            // narudzbeniceTableAdapter1
            // 
            this.narudzbeniceTableAdapter1.ClearBeforeFill = true;
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(553, 328);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 1;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Narudzbenice
            // 
            this.Narudzbenice.AllowUserToAddRows = false;
            this.Narudzbenice.AllowUserToDeleteRows = false;
            this.Narudzbenice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Narudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Narudzbenice.Location = new System.Drawing.Point(12, 45);
            this.Narudzbenice.MultiSelect = false;
            this.Narudzbenice.Name = "Narudzbenice";
            this.Narudzbenice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Narudzbenice.Size = new System.Drawing.Size(697, 277);
            this.Narudzbenice.TabIndex = 2;
            // 
            // t18_DBDataSet12
            // 
            this.t18_DBDataSet12.DataSetName = "T18_DBDataSet12";
            this.t18_DBDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narudzbeniceBindingSource2
            // 
            this.narudzbeniceBindingSource2.DataMember = "Narudzbenice";
            this.narudzbeniceBindingSource2.DataSource = this.t18_DBDataSet12;
            // 
            // narudzbeniceTableAdapter2
            // 
            this.narudzbeniceTableAdapter2.ClearBeforeFill = true;
            // 
            // Odustani
            // 
            this.Odustani.Location = new System.Drawing.Point(634, 328);
            this.Odustani.Name = "Odustani";
            this.Odustani.Size = new System.Drawing.Size(75, 23);
            this.Odustani.TabIndex = 4;
            this.Odustani.Text = "Odustani";
            this.Odustani.UseVisualStyleBackColor = true;
            this.Odustani.Click += new System.EventHandler(this.Odustani_Click);
            // 
            // Naruciti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(721, 379);
            this.Controls.Add(this.Odustani);
            this.Controls.Add(this.Narudzbenice);
            this.Controls.Add(this.Dodaj);
            this.Name = "Naruciti";
            this.Text = "Naruciti od dobavljača";
            this.Load += new System.EventHandler(this.Naruciti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Narudzbenice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeniceBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private T18_DBDataSet10 t18_DBDataSet10;
        private System.Windows.Forms.BindingSource narudzbeniceBindingSource;
        private T18_DBDataSet10TableAdapters.NarudzbeniceTableAdapter narudzbeniceTableAdapter;
        private T18_DBDataSet11 t18_DBDataSet11;
        private System.Windows.Forms.BindingSource narudzbeniceBindingSource1;
        private T18_DBDataSet11TableAdapters.NarudzbeniceTableAdapter narudzbeniceTableAdapter1;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.DataGridView Narudzbenice;
        private T18_DBDataSet12 t18_DBDataSet12;
        private System.Windows.Forms.BindingSource narudzbeniceBindingSource2;
        private T18_DBDataSet12TableAdapters.NarudzbeniceTableAdapter narudzbeniceTableAdapter2;
        private System.Windows.Forms.Button Odustani;
    }
}
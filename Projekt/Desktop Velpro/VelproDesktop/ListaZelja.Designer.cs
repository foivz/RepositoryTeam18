namespace VelproDesktop
{
    partial class ListaZelja
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
            this.t18_DBDataSet = new VelproDesktop.T18_DBDataSet();
            this.t18DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikliTableAdapter = new VelproDesktop.T18_DBDataSetTableAdapters.ArtikliTableAdapter();
            this.artikliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.t18_DBDataSet3 = new VelproDesktop.T18_DBDataSet3();
            this.t18DBDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Lista = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18DBDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // t18_DBDataSet
            // 
            this.t18_DBDataSet.DataSetName = "T18_DBDataSet";
            this.t18_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t18DBDataSetBindingSource
            // 
            this.t18DBDataSetBindingSource.DataSource = this.t18_DBDataSet;
            this.t18DBDataSetBindingSource.Position = 0;
            // 
            // artikliBindingSource
            // 
            this.artikliBindingSource.DataMember = "Artikli";
            this.artikliBindingSource.DataSource = this.t18DBDataSetBindingSource;
            // 
            // artikliTableAdapter
            // 
            this.artikliTableAdapter.ClearBeforeFill = true;
            // 
            // artikliBindingSource1
            // 
            this.artikliBindingSource1.DataMember = "Artikli";
            this.artikliBindingSource1.DataSource = this.t18DBDataSetBindingSource;
            // 
            // t18_DBDataSet3
            // 
            this.t18_DBDataSet3.DataSetName = "T18_DBDataSet3";
            this.t18_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t18DBDataSet3BindingSource
            // 
            this.t18DBDataSet3BindingSource.DataSource = this.t18_DBDataSet3;
            this.t18DBDataSet3BindingSource.Position = 0;
            // 
            // Lista
            // 
            this.Lista.AllowUserToAddRows = false;
            this.Lista.AllowUserToDeleteRows = false;
            this.Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lista.Location = new System.Drawing.Point(12, 75);
            this.Lista.MultiSelect = false;
            this.Lista.Name = "Lista";
            this.Lista.ReadOnly = true;
            this.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Lista.Size = new System.Drawing.Size(697, 292);
            this.Lista.TabIndex = 0;
            this.Lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista Želja";
            // 
            // ListaZelja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(721, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lista);
            this.Name = "ListaZelja";
            this.Text = "Lista Želja";
            this.Load += new System.EventHandler(this.ListaZelja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikliBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t18DBDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource t18DBDataSetBindingSource;
        private T18_DBDataSet t18_DBDataSet;
        private System.Windows.Forms.BindingSource artikliBindingSource;
        private T18_DBDataSetTableAdapters.ArtikliTableAdapter artikliTableAdapter;
        private System.Windows.Forms.BindingSource t18DBDataSet3BindingSource;
        private T18_DBDataSet3 t18_DBDataSet3;
        private System.Windows.Forms.BindingSource artikliBindingSource1;
        private System.Windows.Forms.DataGridView Lista;
        private System.Windows.Forms.Label label1;
    }
}
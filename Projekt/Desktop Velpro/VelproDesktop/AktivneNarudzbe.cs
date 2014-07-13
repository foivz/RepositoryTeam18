using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelproDesktop
{
    public partial class AktivneNarudzbe : Form
    {
        public AktivneNarudzbe()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void AktivneNarudzbe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't18_DBDataSet5.Narudzbenice' table. You can move, or remove it, as needed.
            this.narudzbeniceTableAdapter.Fill(this.t18_DBDataSet5.Narudzbenice);
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.narudzbeniceTableAdapter.FillBy(this.t18_DBDataSet5.Narudzbenice);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.narudzbeniceTableAdapter.FillBy1(this.t18_DBDataSet5.Narudzbenice);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.narudzbeniceTableAdapter.FillBy2(this.t18_DBDataSet5.Narudzbenice);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.narudzbeniceTableAdapter.FillBy3(this.t18_DBDataSet5.Narudzbenice);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy11ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.narudzbeniceTableAdapter.FillBy11(this.t18_DBDataSet5.Narudzbenice);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            string ID_narudzbe = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var kupac = new StringBuilder();
            conn.ConnectionString = @"Server=31.147.204.119\PISERVER,1433; Database=T18_DB; User Id=T18_User; Password=2GQEdQrM;";
            using (SqlCommand sql = conn.CreateCommand())
            {
                conn.Open();
                sql.CommandText = "SELECT sn.Kolicina AS [Naručena količina], a.Naziv_artikla AS Naziv, a.Cijena_artikla AS Cijena, a.Dostupna_kolicina AS [Dostupna količina] FROM Stavke_narudzbe sn INNER JOIN Artikli a ON sn.ID_artikla=a.ID_artikla WHERE sn.ID_narudzbenice=" + ID_narudzbe + "";
                SqlDataAdapter DA = new SqlDataAdapter(sql);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                Ispis.DataSource = DS.Tables[0].DefaultView;
                Ispis.Refresh();
                sql.CommandText = "SELECT k.Ime FROM Narudzbenice n INNER JOIN Korisnici k ON n.ID_korisnika=k.ID_korisnika WHERE n.ID_narudzbenice=" + ID_narudzbe + "";
                NaruciteljIme.Text = sql.ExecuteScalar().ToString();
                sql.CommandText = "SELECT k.Prezime FROM Narudzbenice n INNER JOIN Korisnici k ON n.ID_korisnika=k.ID_korisnika WHERE n.ID_narudzbenice=" + ID_narudzbe + "";
                NaruciteljPrez.Text = sql.ExecuteScalar().ToString();
            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBy11ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

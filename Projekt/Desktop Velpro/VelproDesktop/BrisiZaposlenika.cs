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
    public partial class BrisiZaposlenika : Form
    {
        public BrisiZaposlenika()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void BrisiZaposlenika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't18_DBDataSet7.Korisnici' table. You can move, or remove it, as needed.
            this.korisniciTableAdapter.Fill(this.t18_DBDataSet7.Korisnici);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.korisniciTableAdapter.FillBy(this.t18_DBDataSet7.Korisnici);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Obrisi_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=31.147.204.119\PISERVER,1433; Database=T18_DB; User Id=T18_User; Password=2GQEdQrM;");
            SqlCommand sql = new SqlCommand();
            conn.Open();
            sql.CommandText = "DELETE FROM Korisnici WHERE ID_korisnika=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
            sql.Connection = conn;
            sql.ExecuteNonQuery();
            conn.Close();
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            MessageBox.Show("Uspješno obrisano!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

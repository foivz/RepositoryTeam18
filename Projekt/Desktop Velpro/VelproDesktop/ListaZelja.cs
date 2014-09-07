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
    public partial class ListaZelja : Form
    {
        public ListaZelja()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void ListaZelja_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=31.147.204.119\PISERVER,1433; Database=T18_DB; User Id=T18_User; Password=2GQEdQrM;";
            using (SqlCommand sql = conn.CreateCommand())
            {
                conn.Open();
                sql.CommandText = "SELECT l.ID_lista_zelja, k.Korisnicko_ime, l.naziv, l.Opis FROM Korisnici k INNER JOIN Lista_zelja l ON l.ID_lista_zelja=k.ID_korisnika";
                SqlDataAdapter DA = new SqlDataAdapter(sql);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                Lista.DataSource = DS.Tables[0].DefaultView;
            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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

namespace Velpro_za_korisnika
{
    public partial class Prijava : Form
    {
        public static int ID;

        public Prijava()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=31.147.204.119\PISERVER,1433; Database=T18_DB; User Id=T18_User; Password=2GQEdQrM;";
            conn.Open();

            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            SqlCommand sql = new SqlCommand("SELECT ID_korisnika FROM Korisnici WHERE Korisnicko_ime='" + user + "' and Lozinka='" + pass + "'", conn);
            SqlDataAdapter DA = new SqlDataAdapter(sql);
            DataTable DT = new DataTable();
            DA.Fill(DT);

            if (DT.Rows.Count > 0)
            {
                ID = int.Parse(sql.ExecuteScalar().ToString());
                GlavnaForma Izbornik = new GlavnaForma();
                Izbornik.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                conn.Close();
            }
        }

        private void Prijava_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't18_DBDataSet.Korisnici' table. You can move, or remove it, as needed.
            this.korisniciTableAdapter.Fill(this.t18_DBDataSet.Korisnici);

        }
    }
}

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
    public partial class Form1 : Form
    {
        public static int ID;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Prijava_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Server=31.147.204.119\PISERVER,1433; Database=T18_DB; User Id=T18_User; Password=2GQEdQrM;";
                conn.Open();

                string user = korIme.Text;
                string pass = Lozinka.Text;

                SqlCommand sql = new SqlCommand("SELECT ID_korisnika FROM Korisnici WHERE Korisnicko_ime='" + user + "' and Lozinka='" + pass + "'", conn);
                SqlDataAdapter DA = new SqlDataAdapter(sql);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                if (DT.Rows.Count > 0)
                {
                    menu Izbornik = new menu();
                    ID = int.Parse(sql.ExecuteScalar().ToString());
                    Izbornik.Show();
                    this.Hide();
                    conn.Close();
                }
                else
                {
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("Greška kod povezivanja s bazom! Provjerite vezu s internetom.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

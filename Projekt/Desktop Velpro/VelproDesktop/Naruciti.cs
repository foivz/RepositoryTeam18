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
    public partial class Naruciti : Form
    {
        public SqlDataAdapter DA;
        public DataSet DS;
        public Naruciti()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Naruciti_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=31.147.204.119\PISERVER,1433; Database=T18_DB; User Id=T18_User; Password=2GQEdQrM;";
            using (SqlCommand sql = conn.CreateCommand())
            {
                conn.Open();
                //sql.CommandText = "SELECT nr.ID_narudzbenice AS [Šifra narudžbenice], nr.Adresa_dostave AS [Adresa dostave], sn.Kolicina AS [Naručena količina], ar.Naziv_artikla AS [Naziv artikla], db.Naziv_dobavljaca AS [Naziv dobavljača] FROM Narudzbenice nr LEFT OUTER JOIN Stavke_narudzbe sn ON nr.ID_narudzbenice=sn.ID_narudzbenice LEFT OUTER JOIN Artikli ar ON sn.ID_artikla=ar.ID_artikla LEFT OUTER JOIN Dobavljaci db ON nr.ID_dobavljaca=db.ID_dobavljaca WHERE nr.ID_dobavljaca IS NOT NULL";
                sql.CommandText = "SELECT nr.ID_narudzbenice AS [Šifra narudžbenice], nr.Datum_i_vrijeme AS [Datum i vrijeme] FROM Narudzbenice nr  WHERE nr.ID_dobavljaca IS NOT NULL AND nr.Aktivna=1";
                //SqlDataAdapter 
                DA = new SqlDataAdapter(sql);
                //DataSet 
                DS = new DataSet();
                DA.Fill(DS);
                Narudzbenice.DataSource = DS.Tables[0].DefaultView;
            }
            conn.Close();
            Narudzbenice.ReadOnly = false;
            Narudzbenice.Columns[0].ReadOnly = true;
            Narudzbenice.Columns[1].ReadOnly = true;
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            Dodaj_Narudzbu Dodavanje = new Dodaj_Narudzbu();
            Dodavanje.Show();
        }

        private void Odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Uredu_Click(object sender, EventArgs e)
        {
        }

        private void Narudzbenice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Narudzbenice_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                string ID_narudzbe = Narudzbenice.SelectedRows[0].Cells[0].Value.ToString();
                var kupac = new StringBuilder();
                conn.ConnectionString = @"Server=31.147.204.119\PISERVER,1433; Database=T18_DB; User Id=T18_User; Password=2GQEdQrM;";
                using (SqlCommand sql = conn.CreateCommand())
                {
                    conn.Open();
                    sql.CommandText = "SELECT sn.ID_artikla AS [ID Artikla], sn.Kolicina AS [Naručena količina], a.Naziv_artikla AS Naziv, a.Cijena_artikla AS Cijena, a.Dostupna_kolicina AS [Dostupna količina] FROM Stavke_narudzbe sn INNER JOIN Artikli a ON sn.ID_artikla=a.ID_artikla WHERE sn.ID_narudzbenice=" + ID_narudzbe + "";
                    SqlDataAdapter DA = new SqlDataAdapter(sql);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    Ispis.DataSource = DS.Tables[0].DefaultView;
                    Ispis.Refresh();

                }
                conn.Close();
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Server=31.147.204.119\PISERVER,1433; Database=T18_DB; User Id=T18_User; Password=2GQEdQrM;";
                SqlCommand sql = new SqlCommand();
                sql.CommandType = CommandType.Text;
                string ID_narudzbe = Narudzbenice.SelectedRows[0].Cells[0].Value.ToString();
                conn.Open();
                sql.Connection = conn;
                foreach (DataGridViewRow red in Ispis.Rows)
                {
                    int ID_artikla = int.Parse(red.Cells[0].Value.ToString());
                    int Kolicina = int.Parse(red.Cells[1].Value.ToString());
                    int Dostupna_kolicina = int.Parse(red.Cells[4].Value.ToString());
                    int Nova_kolicina = Dostupna_kolicina + Kolicina;
                    sql.CommandText = "UPDATE Artikli SET Dostupna_kolicina=" + Nova_kolicina.ToString() + " WHERE ID_artikla=" + ID_artikla.ToString() + "";
                    sql.ExecuteNonQuery();
                }
                
                sql.CommandText = "UPDATE Narudzbenice SET Aktivna=0 WHERE ID_narudzbenice=" + ID_narudzbe.ToString() + "";
                
                sql.ExecuteNonQuery();

                conn.Close();
                this.Naruciti_Load(null, null);
        }

        private void Naruciti_Activated(object sender, EventArgs e)
        {
            this.Naruciti_Load(null, null);
        } 
    }
}

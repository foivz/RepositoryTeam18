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
                sql.CommandText = "SELECT nr.ID_narudzbenice AS [Šifra narudžbenice], nr.Adresa_dostave AS [Adresa dostave], sn.Kolicina AS [Naručena količina], ar.Naziv_artikla AS [Naziv artikla], db.Naziv_dobavljaca AS [Naziv dobavljača] FROM Narudzbenice nr LEFT OUTER JOIN Stavke_narudzbe sn ON nr.ID_narudzbenice=sn.ID_narudzbenice LEFT OUTER JOIN Artikli ar ON sn.ID_artikla=ar.ID_artikla LEFT OUTER JOIN Dobavljaci db ON nr.ID_dobavljaca=db.ID_dobavljaca WHERE nr.ID_korisnika=" + Form1.ID.ToString() + "";
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
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace VelproDesktop
{
    class baza
    {
        private SqlConnection conn = new SqlConnection();

        public baza()
        {
            conn.ConnectionString = @"Server=31.147.204.119\PISERVER,1433; Database=T18_DB; User Id=T18_User; Password=2GQEdQrM;";
        }

        public string SelectUpit(string upit)
        {
            string odgovor;
            using (SqlCommand sql = conn.CreateCommand())
            {
                conn.Open();
                sql.CommandText = upit;
                SqlDataAdapter DA = new SqlDataAdapter();
                DataSet DS = new DataSet();
                DA.Fill(DS);
                odgovor = sql.ExecuteScalar().ToString();
            }
            conn.Close();
            return odgovor;
        }
    }
}

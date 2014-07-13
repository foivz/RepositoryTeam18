using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velpro_za_korisnika
{
    public partial class ListaZelja : Form
    {
        public ListaZelja()
        {
            InitializeComponent();
        }

        private void btnSalji_Click(object sender, EventArgs e)
        {
            using (var db = new T18_DBEntities()) 
            {
                Prijava prijava = new Prijava();
                db.Database.Connection.Open();
                Lista_zelja lista = new Lista_zelja
                {
                    ID_korisnika = Prijava.ID,
                    Naziv = txtNaslov.Text,
                    Opis = txtOpis.Text
                };
                db.Lista_zelja.Add(lista);
                db.SaveChanges();
            }
            Close();
        }


    }
}

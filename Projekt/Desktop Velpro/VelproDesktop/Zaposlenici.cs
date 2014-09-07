using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelproDesktop
{
    public partial class Zaposlenici : Form
    {
        public Zaposlenici()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DodajZaposlenika formaDodajZap = new DodajZaposlenika();
            formaDodajZap.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BrisiZaposlenika formaBrisiZap = new BrisiZaposlenika();
            formaBrisiZap.Show();
        }

        private void DodajKor_Click(object sender, EventArgs e)
        {
            DodajKorisnika formaDodajKor = new DodajKorisnika();
            formaDodajKor.Show();
        }

        private void BrisiKor_Click(object sender, EventArgs e)
        {
            BrisiKorisnika formaBrisiKori = new BrisiKorisnika();
            formaBrisiKori.Show();
        }

        private void Zaposlenici_Load(object sender, EventArgs e)
        {

        }
    }
}

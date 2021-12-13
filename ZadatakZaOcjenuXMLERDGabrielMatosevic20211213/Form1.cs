using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadatakZaOcjenuXMLERDGabrielMatosevic20211213
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UnosKorisnikaButun_Click(object sender, EventArgs e)
        {
            UnosKorisnika NoviKorisnik = new UnosKorisnika();
            NoviKorisnik.ShowDialog();
        }

        private void UnosKnjigeButun_Click(object sender, EventArgs e)
        {
            UnosKnjige NovaKnjiga = new UnosKnjige();
            NovaKnjiga.ShowDialog();
        }

        private void UnosPosudivanjaButun_Click(object sender, EventArgs e)
        {
            UnosPosudivanja NovoPosudivanje = new UnosPosudivanja();
            NovoPosudivanje.ShowDialog();
        }
    }
}

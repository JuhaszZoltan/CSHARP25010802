using System.Text;

namespace BarlangokGUI
{
    public partial class BarlangokForm : Form
    {
        private const string SOLDIR = "C:\\Users\\juhaszz\\source\\repos\\CSHARP25010802\\SRC";

        List<Barlang> barlangok = [];
        Barlang kijBarlang = null;

        public BarlangokForm()
        {
            InitializeComponent();
            this.Load += BarlangokFormLoad;
            btnKereses.Click += BtnKeresesClick;
            btnMentes.Click += BtnMentesClick;
        }

        private void BtnMentesClick(object sender, EventArgs e)
        {
            string msg = string.Empty;

            if (kijBarlang.Hossz > int.Parse(tbHosszusag.Text))
                msg += "A hossz nem lehet kissebb a korábbi értéknél!\n";
            if (kijBarlang.Melyseg > int.Parse(tbMelyseg.Text))
                msg += "A mélység nem lehet kisebb a korábbi értéknél!\n";

            if (msg != string.Empty)
            {
                _ = MessageBox.Show(msg);
            }
            else
            {
                kijBarlang.Hossz = int.Parse(tbHosszusag.Text);
                kijBarlang.Melyseg = int.Parse(tbMelyseg.Text);
            }
            EredetiAllapot();
        }

        private void BtnKeresesClick(object sender, EventArgs e)
        {
            kijBarlang = barlangok
                .SingleOrDefault(b => b.Azon == int.Parse(tbAzonosito.Text));

            if (kijBarlang is null)
            {
                _ = MessageBox.Show("Ezzel az azonosítóval nem létezik barlang!");
                EredetiAllapot();
            }
            else
            {
                lblBarlangNeve.Text = kijBarlang.Nev;
                tbHosszusag.Text = $"{kijBarlang.Hossz}";
                tbMelyseg.Text = $"{kijBarlang.Melyseg}";
                btnMentes.Enabled = true;
            }
        }

        private void BarlangokFormLoad(object? sender, EventArgs e)
        {
            StreamReader sr = new($"{SOLDIR}\\barlangok.txt", Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream) barlangok.Add(new(sr.ReadLine()));
        }

        private void EredetiAllapot()
        {
            tbAzonosito.Text = string.Empty;
            lblBarlangNeve.Text = string.Empty;
            tbHosszusag.Text = string.Empty;
            tbMelyseg.Text = string.Empty;
            btnMentes.Enabled = false;
            kijBarlang = null;
        }
    }
}

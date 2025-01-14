using System.Text;

namespace BarlangokGUI
{
    public partial class BarlangokForm : Form
    {
        private const string SOLDIR = "C:\\Users\\juhaszz\\Source\\Repos\\CSHARP25010802\\SRC";

        List<Barlang> barlangok = [];
        Barlang kijBarlang = null;

        public BarlangokForm()
        {
            InitializeComponent();
            this.Load += BarlangokFormLoad;
            btnKereses.Click += BtnKeresesClick;
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

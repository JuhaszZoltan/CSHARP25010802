using System.Text;

namespace BarlangokGUI
{
    public partial class BarlangokForm : Form
    {
        private const string SOLDIR =
    "C:\\Users\\juhaszz\\Source\\Repos\\CSHARP25010802\\SRC";

        List<Barlang> barlangok = [];
        public BarlangokForm()
        {
            InitializeComponent();
            this.Load += BarlangokFormLoad;
            btnKereses.Click += BtnKeresesClick;
        }

        private void BtnKeresesClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BarlangokFormLoad(object? sender, EventArgs e)
        {
            StreamReader sr = new($"{SOLDIR}\\barlangok.txt", Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream) barlangok.Add(new(sr.ReadLine()));
        }
    }
}

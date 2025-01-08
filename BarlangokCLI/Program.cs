using BarlangokCLI;
using System.Text;

const string SOLDIR = "E:\\juhaszz\\PROJECTS\\CSHARP25010802\\SRC";

List<Barlang> barlangok = [];

StreamReader sr = new($"{SOLDIR}\\barlangok.txt", Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) barlangok.Add(new(sr.ReadLine()));

Console.WriteLine($"4. feladat: barlangok szama: {barlangok.Count}");

var f5 = barlangok
    .Where(b => b.Telepules.StartsWith("Miskolc"))
    .Average(b => b.Melyseg);
Console.WriteLine($"5. feladat: miskolci barlangok atlagos melysege: {f5:0.000} meter");
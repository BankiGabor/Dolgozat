using triatlon241007;
using System.Text;

List<Versenyzo> versenyzok = [];

using StreamReader sr = new(
    path: @"forras.txt",
    encoding: Encoding.UTF8);
while (!sr.EndOfStream) versenyzok.Add(new(sr.ReadLine()));

Console.WriteLine($"A versenyt befejező versenyzők száma: {versenyzok.Count}");

var elitjuniorversenyzok = versenyzok.Count(v => v.Korcsoport == "elit junior");
Console.WriteLine($"\nElit junior kategóriában versenyzők száma: {elitjuniorversenyzok}");

var ferfiatlag = versenyzok.Where(v => v.Nem == "f").Average(a => a.Kor);
Console.WriteLine($"\nA férfi versenyzők átlag életkora: {ferfiatlag:0.00}");

var uszasatlag = versenyzok.Where(v => v.Korcsoport == "20-24").Average(a => a.Uszas.Hour);
Console.WriteLine($"\nA 20-24 éves korcsoportban átlagos úszási idő: {uszasatlag}");


var ferfibefejezett = versenyzok.Count(v => v.Nem == "f");
var noibefejezett = versenyzok.Count(v => v.Nem == "n");
Console.WriteLine($"\nA versenyt befejező férfiak száma: {ferfibefejezett}\nA versenyt befejező nők száma: {noibefejezett}");
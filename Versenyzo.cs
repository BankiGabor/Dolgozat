using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triatlon241007
{
    internal class Versenyzo
    {
        public string Nev { get; set; }
        public int Szulev { get; set; }
        public int Rajtszam { get; set; }
        public string Nem { get; set; }
        public string Korcsoport { get; set; }
        public DateTime Uszas {  get; set; }
        public DateTime Elsodepo { get; set; }
        public DateTime Kerekpar { get; set; }
        public DateTime Masodikdepo { get; set; }
        public DateTime Futas { get; set; }
        public int Kor => (int)(2024 - Szulev);

        public override string ToString()
        {
            return $"{Nev}: SZületett: {Szulev}, Rajtszám: {Rajtszam}, Neme: {Nem}, Korcsoport: {Korcsoport}, Időeredmények(Úszás, első depóban töltött idő, kerékpározás, második depóban töltött idő, futás): {Uszas}; {Elsodepo}; {Kerekpar}; {Masodikdepo}; {Futas} ";
        }


        public Versenyzo(string row)
        {
            var v = row.Split(';');
            Nev = v[0];
            Szulev = int.Parse(v[1]);
            Rajtszam = int.Parse(v[2]);
            Nem = v[3];
            Korcsoport = v[4];
            Uszas = DateTime.ParseExact(v[5], "HH:mm:ss", CultureInfo.InvariantCulture);
            Elsodepo = DateTime.ParseExact(v[6], "HH:mm:ss", CultureInfo.InvariantCulture);
            Kerekpar = DateTime.ParseExact(v[7], "HH:mm:ss", CultureInfo.InvariantCulture);
            Masodikdepo = DateTime.ParseExact(v[8], "HH:mm:ss", CultureInfo.InvariantCulture);
            Futas = DateTime.ParseExact(v[9], "HH:mm:ss", CultureInfo.InvariantCulture);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_dolgozat_gyakorlo
{
    public class Eszkoz
    {
        private int napiDij;
        private int keszlet;
        private static int osszesRegisztraltEszkoz = 0;
        public string Azonosito { get; set; }
        public string Nev { get; set; }
        public string Kategoria { get; set; }
        public int NapiDij
        {
            get => napiDij;
            set => napiDij = value < 0 ? 0 : value;
        }
        public int Keszlet {
            get => keszlet;
            set => keszlet = value < 1 ? 1 : value;
        }
        public static int OsszesRegisztraltEszkoz
        {
            get => osszesRegisztraltEszkoz;
        }
        public Eszkoz(string azonosito, string nev, string kategoria, int napiDij):this ( azonosito, nev, kategoria, napiDij, 1) 
        { 

        }
        public Eszkoz(string azonosito, string nev, string kategoria, int napiDij, int keszlet)
        {
            azonosito = Azonosito;
            nev = Nev;
            kategoria = Kategoria;
            napiDij = NapiDij;
            keszlet = Keszlet;
            osszesRegisztraltEszkoz++;
        }
        public override string ToString()
        {
            return $"[{Azonosito}] {Nev} ({Kategoria}) - Napi díj: {NapiDij} Ft | Készlet: {Keszlet} db";
        }
        public int TeljesNapiBevetel()
        {
            return NapiDij*Keszlet;
        }
        //public bool KategoriaEgyezik(string keresettKategoria)
    }
    
}

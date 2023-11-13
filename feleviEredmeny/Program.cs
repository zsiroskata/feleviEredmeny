using System;
using System.IO;
using System.Collections.Generic;

namespace feleviEredmeny
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tanulo> tanulok = new List<Tanulo>();
            List<Tanulo> tantargyak = new List<Tanulo>();
            //1. feladat Írjunk függvényt, ami kiszámítja a jegyek átlagát tanulónként.Írjunk függvényt, ami kiszámítja az osztályátlagot, illetve a tantárgyankénti átlagot is.
            var sr = new StreamReader(
                path: @"..\..\..\src\forras.txt",
                encoding: System.Text.Encoding.UTF8
                );

                sr.ReadLine();

            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                var sor = new Tanulo(sr.ReadLine());
                tanulok.Add(sor);
            }

            double yes = 0;
            foreach (var tanulo in tanulok)
            {
                Console.WriteLine($"{tanulo.ToString()} átlag: {tanulo.egyatlag(yes)}");
            }
           
            Console.WriteLine($"osztály átlag: {osztalyAtlag(tanulok)}");
         
            //2. feladat: Programozás gyakorlatból megbukottak adatainak kiiratása.


            //3. feladat: Írjunk függvényt, amivel keressük meg az első olyan embert, akinek hármasa van angol nyelvből, majd írjuk ki az adatait.

            //4. feladat: Kérjük be a felhasználótól, melyik tanuló legjobb jegyét szeretné megtudni.
            //Írjuk ki az adott tanuló legjobb eredményét függvénnyel. Szorgalmi: Kezeljük a lehetséges felhasználói hibát is.
            //5. feladat: Egy új fájlba írjuk ki a fenti tanuló nevét és oktatási azonosítóját.
        }
        static double osztalyAtlag(List<Tanulo> tanulok)
        {
            double atlag = 0;
            foreach (var tanulo in tanulok)
            {
                atlag += tanulo.atlag;
            }
            return atlag / tanulok.Count;
        }
    }
}

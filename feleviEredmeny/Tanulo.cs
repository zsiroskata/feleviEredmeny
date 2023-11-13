using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace feleviEredmeny
{
    class Tanulo
    {
        public string Diak { get; set; }
        public double Oktazonosito { get; set; }
        public List<int> jegyek { get; set; }


        public Tanulo(string adatok)
        {
            string[] adat = adatok.Split("\t");
            
            Diak = adat[0];
            Oktazonosito = Convert.ToDouble(adat[1]);


            jegyek = new List<int>();
            for (int i = 2; i < adat.Length; i++)
            {
                jegyek.Add(Convert.ToInt32(adat[i]));
            }
        }
        public double atlag => jegyek.Average();
        public override string ToString()
        {
            return $"Diák neve {Diak}, azonosítója: {Oktazonosito}";
        }
        
        public double egyatlag(double atlag)
        {
            foreach (var tanulo in jegyek)
            {
                atlag += tanulo;
            }
            return atlag / jegyek.Count;
        }

    }
}

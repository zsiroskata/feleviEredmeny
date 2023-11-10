using System;
using System.Collections.Generic;
using System.Text;

namespace feleviEredmeny
{
    class Tanulo
    {
        public string Diak { get; set; }
        public double Oktazonosito { get; set; }
        List<int> Lista { get; set; }


        public Tanulo(string adatok)
        {
            string[] adat = adatok.Split("\t");
            Diak = adat[0];
            Oktazonosito = Convert.ToDouble(adat[1]);

            Lista = new List<int>();
            for (int i = 2; i < adat.Length; i++)
            {
                Lista.Add(Convert.ToInt32(adat[i]));
            }
        }

        public override string ToString()
        {
            return $"Diák neve {Diak}, azonosítója: {Oktazonosito}";
        }
        
        public double atlag(double atlag)
        {
            foreach (var tanulo in Lista)
            {
                atlag += tanulo;
            }
            return atlag / Lista.Count;
        }

    }
}

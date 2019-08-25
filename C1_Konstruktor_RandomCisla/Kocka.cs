using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1_Konstruktor_RandomCisla
{
    class Kocka
    {
        private Random random;
        private sbyte pocetStien; //nepredpokladame ze sa bude hadzat viac ako 127 stenovou kockou....


        public Kocka(sbyte aPocetStien)
        {
            this.pocetStien = aPocetStien;
            random = new Random();
            validation();
        }

        private void validation()
        {
            if (pocetStien < 0)
            {
                pocetStien *= -1;
            }
        }

        public sbyte getPocetStien()
        {
            return pocetStien;
        }

        public sbyte getRandomHod()
        {
            return Convert.ToSByte(random.Next(1, pocetStien + 1));
            
        }

        public override string ToString()
        {
            return String.Format("Ďakujem za vstup\n zadali ste kocku s {0} stenami", getPocetStien());
        }
    }
}

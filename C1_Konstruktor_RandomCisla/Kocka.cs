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
        private int pocetStien;
        public Kocka(int pocetStien)
        {
            this.pocetStien = pocetStien;
        }
    }
}

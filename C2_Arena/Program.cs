using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using C1_Konstruktor_RandomCisla;




namespace C2_Arena
{
    class Program
    {
        static void Main(string[] args)
        {
            Kocka kocka = new Kocka(10);

            Bojovnik Flip = new Bojovnik("Filip", 1, 0, 0, kocka);



        }
    }
}

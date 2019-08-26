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
            Bojovnik Thor = new Bojovnik("Thor", 100, 20, 10, kocka);
            Bojovnik Hulk = new Bojovnik("Hulk", 60, 18, 15, kocka);

            Arena arena = new Arena(Thor, Hulk, kocka);
            arena.Zapas();
            Console.ReadKey();
             

        }
    }
}

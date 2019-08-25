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

            Bojovnik filip = new Bojovnik("Filip", 100, 90, 20, kocka);

            Console.WriteLine("Bojovník: {0}", filip); // test ToString();
            Console.WriteLine("Naživu: {0}", filip.JeNaZivu()); // test Nazivu();
            Console.WriteLine("Život: {0}", filip.GrafickyZivot()); // test GrafickyZivot();

            filip.Utoc(filip);
            Console.WriteLine(filip.GrafickyZivot());
            Console.ReadKey();




        }
    }
}

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

            Bojovnik filip = new Bojovnik("Filip", 100, 20, 10, kocka);

            //Console.WriteLine("Bojovník: {0}", filip); // test ToString();
            //Console.WriteLine("Naživu: {0}", filip.JeNaZivu()); // test Nazivu();
            Console.WriteLine("Život: {0}", filip.GrafickyZivot()); // test GrafickyZivot();

            Bojovnik protivnik = new Bojovnik("Shadow",40,18,15,kocka);
            protivnik.Utoc(filip);
            Console.WriteLine(protivnik.getPoslednuSpravu());
            Console.WriteLine(filip.getPoslednuSpravu());

            Console.WriteLine(filip.GrafickyZivot());
            Console.ReadKey();


            while (filip.JeNaZivu() && protivnik.JeNaZivu() )
            {
                filip.Utoc(protivnik);
                Console.WriteLine(filip.getPoslednuSpravu());
                Console.WriteLine(protivnik.getPoslednuSpravu());

                Console.WriteLine(filip.GrafickyZivot());
                Console.WriteLine(protivnik.GrafickyZivot());

                //kontrola ci ziju hraci
                if (!(filip.JeNaZivu() && protivnik.JeNaZivu()))
                    break;


                protivnik.Utoc(filip);

                    Console.WriteLine(protivnik.getPoslednuSpravu());
                    Console.WriteLine(filip.getPoslednuSpravu());
                Console.WriteLine(filip.GrafickyZivot());
                Console.WriteLine(protivnik.GrafickyZivot());

            }


            //vyhral hrac ktory je na zive
            Console.WriteLine("vyhral hrac: {0}");

            Console.ReadKey();

        }
    }
}

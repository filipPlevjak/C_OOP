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

            Bojovnik Thor = new Bojovnik("Thor", 100, 15, 12, kocka);

            //Console.WriteLine("Bojovník: {0}", filip); // test ToString();
            //Console.WriteLine("Naživu: {0}", filip.JeNaZivu()); // test Nazivu();
            Console.WriteLine("Život: {0}", Thor.GrafickyZivot()); // test GrafickyZivot();

            Bojovnik Hulk = new Bojovnik("Hulk",90,25,9,kocka);
            Hulk.Utoc(Thor);
            Console.WriteLine(Hulk.getPoslednuSpravu());
            Console.WriteLine(Thor.getPoslednuSpravu());

            Console.WriteLine(Thor.GrafickyZivot());
            Console.ReadKey();


            while (Thor.JeNaZivu() && Hulk.JeNaZivu() )
            {
                Thor.Utoc(Hulk);
                Console.WriteLine(Thor.getPoslednuSpravu());
                Console.WriteLine(Hulk.getPoslednuSpravu());

                Console.WriteLine(Thor.GrafickyZivot());
                Console.WriteLine(Hulk.GrafickyZivot());

                //kontrola ci ziju hraci
                if (!(Thor.JeNaZivu() && Hulk.JeNaZivu()))
                    break;


                Hulk.Utoc(Thor);

                    Console.WriteLine(Hulk.getPoslednuSpravu());
                    Console.WriteLine(Thor.getPoslednuSpravu());
                Console.WriteLine(Thor.GrafickyZivot());
                Console.WriteLine(Hulk.GrafickyZivot());

            }


            //vyhral hrac ktory je na zive
            Console.WriteLine("vyhral hrac: {0}");

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using C1_Konstruktor_RandomCisla;

namespace C2_Arena
{
    class Arena
    {
        private Bojovnik bojovnik1;
        private Bojovnik bojovnik2;
        private Kocka kocka;

        public Arena(Bojovnik bojovnik1, Bojovnik bojovnik2, Kocka kocka)
        {
            this.bojovnik1 = bojovnik1;
            this.bojovnik2 = bojovnik2;
            this.kocka = kocka;
        }

        private void Vykresli()
        {
            Console.Clear();
            Console.WriteLine("-------------- Aréna -------------- \n");
            Console.WriteLine("Zdravie bojovníkov: \n");
            Console.WriteLine("{0} {1}", bojovnik1, bojovnik1.GrafickyZivot());
            Console.WriteLine("{0} {1}", bojovnik2, bojovnik2.GrafickyZivot());
        }

        private void VypisSpravu(string sprava)
        {
            Console.WriteLine(sprava);
            Thread.Sleep(100);
        }

        public void Zapas()
        {
            Console.WriteLine("Vítajte v aréne!");
            Console.WriteLine("Dnes se pobjiú {0} s {1}! \n", bojovnik1, bojovnik2);
            Console.WriteLine("Zápas môže začať...");
            Console.ReadKey();

            // cyklus s bojom
            while (bojovnik1.JeNaZivu() && bojovnik2.JeNaZivu())
            {
                bojovnik1.Utoc(bojovnik2);
                Vykresli();
               // Console.WriteLine("\n");
                VypisSpravu(bojovnik1.GetPoslednuSpravu()); // zpráva o útoku
                VypisSpravu(bojovnik2.GetPoslednuSpravu()); // zpráva o obrane
                if (!(bojovnik1.JeNaZivu() && bojovnik2.JeNaZivu()))
                    break;

                bojovnik2.Utoc(bojovnik1);
                Vykresli();
                //Console.WriteLine("\n");
                VypisSpravu(bojovnik2.GetPoslednuSpravu()); // zpráva o útoku
                VypisSpravu(bojovnik1.GetPoslednuSpravu()); // zpráva o obrane
                Console.WriteLine();
            }
        }


    }
}

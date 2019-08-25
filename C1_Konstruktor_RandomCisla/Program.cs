using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1_Konstruktor_RandomCisla
{
    class Program
    {
        public const sbyte TEEN = 10;


        static void Main(string[] args)
        {
            sbyte stenyKocky = 0;
            Console.WriteLine("Zadaj kolko stennou kockou chceš hadzat");
            

            if (sbyte.TryParse(Console.ReadLine(), out stenyKocky))
            {
                Kocka kocka = new Kocka(stenyKocky);

                Console.WriteLine(kocka.ToString());
                for (int i = 0; i < TEEN; i++)
                {
                    Console.Write(kocka.GetRandomHod() + " ");
                }

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("error pri vstupe\nPravdepodobne ste nezadali cislo alebo ste vymysleli brutalnu kocku");
                Console.ReadKey();
            } 
        }
    }
}

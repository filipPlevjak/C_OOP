using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C1_Konstruktor_RandomCisla;

namespace C2_Arena
{
    class Bojovnik
    {
        public const sbyte MAX_ZIVOT_ZNAKOV = 20;

        //meno bojovnika
        private string meno;

        //Život v HP
        private short zivot;

        //max život v HP
        private short maxZivot;

        //utok v HP
        private short utok;

        //obrana v HP
        private short obrana;

        //inštancia hracej kocky
        private Kocka kocka;

        //get/set sprava
        private string sprava;

        public Bojovnik(string meno, short zivot, short utok, short obrana, Kocka kocka)
        {
            this.meno = meno;
            this.zivot = zivot;
            this.maxZivot = zivot;
            this.utok = utok;
            this.obrana = obrana;
            this.kocka = kocka;
            GrafickyZivot();
        }

        public override string ToString()
        {
            return meno;
        }

        public bool JeNaZivu()
        {
            return (zivot > 0);
        }


        public string GrafickyZivot()
        {
            string sGrafickyZivot = "[";
            double pocet = Math.Round(((double)zivot / maxZivot) * MAX_ZIVOT_ZNAKOV);

            if ((pocet == 0) && (JeNaZivu()))
                pocet = 1;

            for (int i = 0; i < pocet; i++)
                sGrafickyZivot += "#";

            sGrafickyZivot = sGrafickyZivot.PadRight(MAX_ZIVOT_ZNAKOV + 1);
            sGrafickyZivot += "]";


            return sGrafickyZivot;
        }

        public void Utoc(Bojovnik super)
        {
            short uder = (short)(utok + kocka.GetRandomHod());
            SetSpravu(String.Format("{0} útočí s úderom za {1} HP", meno, uder));
            super.BranSa(uder);
        }

        public void BranSa(short uder)
        {
            

            short zranenie = (short)(uder - (obrana + kocka.GetRandomHod()));
            if (zranenie > 0)
            {
                zivot -= (short)zranenie;
                sprava = String.Format("{0} utrpel poškodenie {1} HP", meno, zranenie);
                if (zivot <= 0)
                {
                    zivot = 0;
                    sprava += " a zomrel";
                }
            }

            else
                sprava = String.Format("{0} odrazil utok", meno);
            SetSpravu(sprava);

          
        }

        private void SetSpravu(string sprava)
        {
            this.sprava = sprava;
        }

        public string GetPoslednuSpravu()
        {
            return sprava;
        }




    }
}

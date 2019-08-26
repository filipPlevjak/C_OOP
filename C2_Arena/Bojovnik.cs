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
        private byte zivot;

        //max život v HP
        private byte maxZivot;

        //utok v HP
        private byte utok;

        //obrana v HP
        private byte obrana;

        //inštancia hracej kocky
        private Kocka kocka;

        //get/set sprava
        private string sprava;

        public Bojovnik(string meno, byte zivot, byte utok, byte obrana, Kocka kocka)
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
            byte uder = (byte)(utok + kocka.GetRandomHod());
            setSpravu(String.Format("{0} útočí s úderom za {1} HP", meno, uder);
            super.BranSa(uder);
        }

        public void BranSa(byte uder)
        {
            byte zranenie = (byte)(uder - (obrana + kocka.GetRandomHod()));
            if (zranenie > 0)
            {
                zivot -= (byte)zranenie;
                sprava = String.Format("{0} utrpel poškodenie {1} HP", meno, zranenie);
                if (zivot <= 0)
                    zivot = 0;
                sprava += " a zomrel";

            }

            else
                sprava = String.Format("{0} odrazil utok", meno);
            setSpravu(sprava);
        }

        private void setSpravu(string sprava)
        {
            this.sprava = sprava;
        }

        public string getPoslednuSpravu()
        {
            return sprava;
        }



    }
}

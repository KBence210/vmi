using testek;

//1.b. Készítsen egy Hasabok osztályt,
//amely hasábokat képes tárolni
//(Hibakezeléssel egyelőre nem foglalkozunk)
namespace testeketHasznalo
{
    class Hasabok
    {
        //- legyen egy Hasab tömb adattagja
        private Hasab[] hasabTomb;

        //- legyen tulajdonsága (csak olvasható), amely visszaadja a tömb méretét (size),
        //azaz a hasábok maximális számát
        public int TombMerete
        {
            get { return hasabTomb.Length; }
            //set-es rész törölve, ezért read-only
        }

        //- legyen egy csak olvasható tulajdonsága, amely visszaadja,
        //hogy hány darab nem null értékű tömbelem van
        public int NemNullErtekuTombelem
        {
            get
            {
                int darab = 0;

                for (int i = 0; i < TombMerete; i++)
                {
                    if (hasabTomb[i] != null)
                    {
                        darab++;
                    }
                }

                return darab;
            }
        }

        //- legyen egy konstruktora, amely paraméterben megkapja a hasábok
        //maximális számát és ilyen mérettel hozza létre a tömböt!
        public Hasabok(int hasabok_maximalis_szama)
        {
            hasabTomb = new Hasab[hasabok_maximalis_szama];
        }

        //- legyen egy indexere, amely paraméterként egy indexet kap
        //(legyen egy metódusa, amely paraméterben megkap egy index-et és egy Hasab-ot
        //és a tömb indexedik elemének értékül adja a kapott hasáb referenciáját,
        //legyen metódusa, amely paraméterként egy indexet kap és visszaadja a tömb indexedik elemét)
        public Hasab this[int index]
        {
            get
            {
                if (index >= 0 && index < TombMerete)
                {
                    return hasabTomb[index];
                }
                else
                    return null;
            }

            set
            {
                //hasabTomb[index] = value;
                if (value is Henger)
                {
                    hasabTomb[index] = new Henger(((Henger)value).Sugar, value.Magassag);
                }
                else if (value is Teglatest)
                {
                    hasabTomb[index] = new Teglatest(((Teglatest)value).AOldal, ((Teglatest)value).BOldal, value.Magassag);
                }
            }
        }

        //- legyen metódusa, amely visszaadja a hasábok átlagos térfogatát
        public double AtlagosTerfogat()
        {
            double szum = 0;
            /*
            foreach (Hasab hasab in hasabTomb)
            {
                if (hasab != null)
                {
                    szum += hasab.Terfogat();
                }
            }

            return szum / NemNullErtekuTombelem;
             */
            int darab = 0;

            for (int i = 0; i < TombMerete; i++)
            {
                if (hasabTomb[i] != null)
                {
                    szum += hasabTomb[i].Terfogat();
                    darab++;
                }
            }

            if (darab != 0)
            {
                return szum / darab;
            }
            else
            {
                return 0;
            }
        }

        //- legyen egy csak olvasható tulajdonsága,
        //amely visszaadja a Henger típusú hasábok számát
        public int HengerekSzama
        {
            get
            {
                int darab = 0;

                for (int i = 0; i < TombMerete; i++)
                {
                    if (hasabTomb[i] is Henger)
                    {
                        darab++;
                    }
                }

                return darab;
            }
        }
    }
}

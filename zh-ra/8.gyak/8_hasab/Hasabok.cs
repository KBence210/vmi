using Testek;

namespace TestekHasznalata
{
    class Hasabok
    {
        private Hasab[] hasabok;

        public Hasabok(int meret)
        {
            hasabok = new Hasab[meret];
        }

        public Hasab this[int index]
        {
            //- Getter metódus, amely paraméterként egy indexet kap
            //és visszaadja a tömb adott indexű elemét
            get
            {
                if (index >= 0 && index < hasabok.Length )
                {
                    return hasabok[index];
                }
                else
                {
                    return null;
                }
            }
            //- Setter metódus, amely paraméterben megkap egy indexet
            //és egy hasábot, és a tömb adott indexű
            //elemének értékül adja a kapott hasáb referenciáját
            set 
            {
                //hasabok[index] = value;

                if (value is Henger)
                {
                    hasabok[index] = new Henger( 
                            ((Henger)value).Sugar, value.Magassag);
                }
                else if (value is Teglatest)
                {
                    hasabok[index] = new Teglatest(
                             ((Teglatest)value).AOldal,
                             ((Teglatest)value).BOldal,
                             value.Magassag);
                }
            }
        }

        //Getter, amely visszaadja a tömb méretét,
        //azaz a hasábok maximális számát.
        public int HasabokSzama
        {
            get { return hasabok.Length; }
        }

        //Getter, amely visszaadja,
        //hogy hány darab nem null értékű tömbelem van.
        public int NemNullErtekuTombelemekSzama
        {
            get 
            {
                int darabszam = 0;

                foreach (var hasab in hasabok)
                {
                    if (hasab != null)
                    {
                        darabszam++;
                    }
                }

                return darabszam;
            }
        }


        //Getter, amely visszaadja a hasábok átlagos térfogatát.
        public double HasabokAtlagosTerfogata
        {
            get 
            {
                double szumma = 0;

                foreach (Hasab hasab in hasabok)
                {
                    if (hasab != null)
                    {
                        szumma += hasab.Terfogat();
                    }
                }

                return szumma / NemNullErtekuTombelemekSzama;
            }
        }

        //Getter, amely visszaadja a Henger típusú hasábok számát.
        public int HengerekSzama
        {
            get 
            {
                int hengerekSzama = 0;

                foreach (Hasab hasab in hasabok)
                {
                    if (hasab is Henger)
                    {
                        hengerekSzama++;
                    }
                }

                return hengerekSzama;
            }
        }

        //hazi
        //Getter, amely visszaadja a Teglatest típusú hasábok számát

    }
}

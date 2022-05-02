using System;

namespace _2_Ikerprimek
{
    class Program
    {
        static void Main(string[] args)
        {
            int also_hatar = 1, felso_hatar = 100;
            int darab = 0;
            int i, j;

            Console.WriteLine("Ikerprimek:");

            for (i = also_hatar; i < felso_hatar; i++)
            {
                bool i_prime = PrimszamE(i);

                for (j = i + 1; j <= felso_hatar; j++)
                {
                    if (i_prime && PrimszamE(j))
                    {
                        if (j - i == 2)
                        {
                            darab++;
                            Console.WriteLine(i + ", " + j);
                        }
                    }
                }
            }

            Console.WriteLine(darab + " darab ikerprim van a megadott szamok kozott.");
        }

        public static bool PrimszamE(int szam)
        {
            if (szam < 2)
            {
                return false;
            }

            for (int i = 2; i <= szam / 2; i++)
            {
                if (szam % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        //logikai típus használatával
        public static bool PrimszamE2(int szam)
        {
            //talalt-e osztot
            bool talalt = false;

            if (szam < 2)
            {
                return false;
            }

            for (int i = 2; i <= szam / 2; i++)
            {
                if (szam % i == 0)
                {
                    talalt = true;
                    break;
                }
            }

            return !talalt;
        }
    }
}

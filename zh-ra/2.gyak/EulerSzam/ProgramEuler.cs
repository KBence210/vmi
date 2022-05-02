using System;

namespace EulerSzam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adjon közelítést az Euler-féle e számra
            //(e = 2,718 281 828)
            //az alábbi sorozat elsõ 100 / 1000 tagjának kiszámításával!
            double e = 0;
            int darab = 100;

            for (int i = 0; i < darab; i++)
            {
                e += 1 / Faktorialis(i);
            }

            Console.WriteLine("Euler-fele szam");
            Console.WriteLine("e: " + e);
        }

        static private double Faktorialis(int n)
        {
            double faktorialis = 1;

            for (int i = 2; i <= n; i++)
            {
                faktorialis *= i;
            }

            return faktorialis;
        }
    }
}

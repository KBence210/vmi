using System;

namespace _1_Pi_erteke
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wallis-formula
            double pi = 1;
            int darab = 10000 / 2;
            int i;

            for (i = 1; i <= darab; i++)
            {
                pi *= 2.0 * i / (2 * i - 1);
                pi *= 2.0 * i / (2 * i + 1);
            }

            Console.WriteLine("Wallis-formula");
            Console.WriteLine("pi/2 erteke: " + pi);
            Console.WriteLine("pi erteke: " + pi * 2);

            //Leibniz-fele sor
            pi = 0;
            darab *= 4;
            int elojel = 1;

            for (i = 1; i <= darab; i += 2)
            {
                pi += elojel * 1.0 / i;
                elojel *= -1;
            }

            /*
            for (int i = 0; i < darab / 2; i++) {
                pi += Math.pow(-1, i) / (2 * i + 1);     
            }
            */

            Console.WriteLine("Leibniz - fele sorfejtes");
            Console.WriteLine("pi/4 erteke: " + pi);
            Console.WriteLine("pi erteke: " + pi * 4);
        }
    }
}

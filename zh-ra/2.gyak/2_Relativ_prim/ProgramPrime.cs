using System;

namespace _2_Relativ_prim
{
    class Program
    {
        static void Main(string[] args)
        {
            //controlled integer reading
            int n;
            string readString;
            bool successRead;

            do
            {
                Console.WriteLine("Enter a number between 1 and 10");

                readString = Console.ReadLine();

                successRead = Int32.TryParse(readString, out n);

                if (!successRead)
                {
                    Console.WriteLine("That's not a number");
                }
            } while (!successRead || n < 1 || n > 10);

            Console.WriteLine("n = " + n);

            int count = 0;
            int startNumber = 10;

            //for (int i = startNumber, j = i + 1; count < n; i++, j++)
            for (int i = startNumber, j = i + 1; count < n; j++)
            {
                if (Relativeprimes(i, j))
                {
                    Console.WriteLine("(" + i + "," + j + ")");

                    count++;
                }
            }
        }

        private static bool Relativeprimes(int x, int y)
        {
            //if (GreatestCommonDivisorRecursive(x, y) == 1)
            if (GreatestCommonDivisor(x, y) == 1)
                return true;

            return false;
        }

        private static int GreatestCommonDivisor(int x, int y)
        {
            while (y != 0)
            {
                int temporaryNumber = y;
                y = x % y;
                x = temporaryNumber;
            }

            return x;
        }

        private static int GreatestCommonDivisorRecursive(int x, int y)
        {
            if (x % y == 0)
            {
                return y;
            }
            else
            {
                return GreatestCommonDivisorRecursive(y, x % y);
            }
        }
    }
}

using System;

namespace _3_Egydimenzios_tomb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 20, 10, 30, 90, 50, 60, 70, 80, 40, 100 };
            int[] tomb2 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
                //Console.WriteLine(tomb2[i]);
            }

            int size = 10;
            int[] tomb3 = new int[size];
            Feltolt(tomb3);

            Listaz(tomb3);
            ForditottListazas(tomb3);

            Console.WriteLine("A tombelemek atlaga: " + Atlag(tomb));
            Console.WriteLine("A tomb legkisebb eleme: " + tomb[MinimalisIndex(tomb)]);

            int keresettElem = 10;

            if (LinearisKereses(tomb, keresettElem))
                Console.WriteLine("A keresett elem (" + keresettElem + ") a tomb eleme.");
            else
                Console.WriteLine("A keresett elem (" + keresettElem + ") nem eleme a tombnek.");

            Console.WriteLine("A keresett elem (" + keresettElem + ") indexe: " + LinearisKereses2(tomb, keresettElem));

            Console.WriteLine("Rendezes: ");

            Rendez(tomb);
            Listaz(tomb);
        }

        public static void Feltolt(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(50) + 1;
            }
        }

        public static void Listaz(int[] array)
        {
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(i + 1 + ". elem: " + array[i]);
            //}

            Console.Write("Tombelemek: ");

            foreach (int item in array)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
        }

        public static void ForditottListazas(int[] array)
        {
            Console.Write("Forditva: ");

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + ", ");
            }

            Console.WriteLine();
        }

        public static double Atlag(int[] array)
        {
            double osszeg = 0;

            foreach (int item in array)
            {
                osszeg += item;
            }

            return osszeg / array.Length;
        }

        public static int MinimalisIndex(int[] array)
        {
            int minimalisIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minimalisIndex])
                    minimalisIndex = i;
            }

            return minimalisIndex;
        }

        public static bool LinearisKereses(int[] array, int searchkey)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchkey)
                    return true;
            }

            return false;
        }

        public static int LinearisKereses2(int[] tomb, int keresett)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                if (keresett == tomb[i])
                {
                    return i;
                }
            }

            return -1;
        }

        public static void Rendez(int[] array)
        {
            //minimum kivalasztasos rendezes
            for (int i = 0; i < array.Length; i++)
            {
                int minimalisIndex = i;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[minimalisIndex])
                        minimalisIndex = j;
                }

                //helycsere, ha szukseges
                if (array[minimalisIndex] != array[i])
                {
                    int ideiglenesTarolo = array[i];
                    array[i] = array[minimalisIndex];
                    array[minimalisIndex] = ideiglenesTarolo;
                }
            }
        }
    }
}

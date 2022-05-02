using System;
using System.Linq;

namespace _2_Tomb_veletlenszam
{
    class Program
    {
        static void Main(string[] args)
        {
            int meret = 10;
            int[] egeszTomb = new int[meret];

            FeltoltEgeszTomb(egeszTomb);
            Array.Sort(egeszTomb);
            ListazEgeszTomb(egeszTomb);

            //legnagyobb paros szam keresese
            if (LegnagyobbParosSzam(egeszTomb) < 0)
                Console.WriteLine("Nincs paros szam a tombben");
            else
                Console.WriteLine("A legnagyobb paros szam: " + LegnagyobbParosSzam(egeszTomb));

            Console.WriteLine("A negyzetszamok szama: " + MegszamolNegyzetszamokat(egeszTomb));

            int keresettEgeszSzam = EgeszetBeolvas("A keresett elem: ");
            int index = Array.BinarySearch(egeszTomb, keresettEgeszSzam);

            if (index < 0)
                Console.WriteLine("A keresett elem nincs a tombben");
            else
                Console.WriteLine("Indexe: " + index);

            //tombok osszehasonlitasa
            int[] elsoTomb = { 1, 2, 3 };
            int[] masodikTomb = { 1, 2, 3 };

            //Equals a referencia egyezeset vizsgalja
            //if (elsoTomb.Equals(masodikTomb))
            //if (Array.Equals(elsoTomb, masodikTomb))
            if (Enumerable.SequenceEqual(elsoTomb, masodikTomb))
                Console.WriteLine("A ket tomb azonos");
            else
                Console.WriteLine("A ket tomb nem azonos");

            //double tomb
            double[] valosTomb = new double[meret];
            FeltoltValosTomb(valosTomb);
            Array.Sort(valosTomb);
            ListazValosTomb(valosTomb);

            //Console.WriteLine("Mertani atlag: " + GeometriaiAtlag(valosTomb));
            Console.WriteLine($"Mertani atlag: {GeometriaiAtlag(valosTomb):N3}");

            Console.WriteLine("A keresett elem: ");
            double keresettValosSzam = double.Parse(Console.ReadLine());
            index = Array.BinarySearch(valosTomb, keresettValosSzam);

            if (index < 0)
                Console.WriteLine("A keresett elem nincs a tombben");
            else
                Console.WriteLine("Indexe: " + index);

            //char tomb
            char[] karakterTomb = { 'a', 'f', 'c', 'e', 'b', 'd', 'g' };

            ListazKarakterTomb(karakterTomb);
            Array.Sort(karakterTomb);
            ListazKarakterTomb(karakterTomb);
        }

        private static void FeltoltEgeszTomb(int[] tomb)
        {
            Random veletlenObjekum = new Random();

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = veletlenObjekum.Next(50) + 1;
            }
        }

        private static void ListazEgeszTomb(int[] tomb)
        {
            foreach (int elem in tomb)
            {
                Console.Write(elem + ", ");
            }

            Console.WriteLine();
        }

        private static void FeltoltValosTomb(double[] tomb)
        {
            Random veletlenObjekum = new Random();

            for (int i = 0; i < tomb.Length; i++)
            {
                double valosVeletlenSzam = veletlenObjekum.NextDouble() * 50 + 1;
                //Console.Write(value + ", ");

                //ket tizedesre kerekites
                //value = Math.Round(value, 2);
                valosVeletlenSzam = valosVeletlenSzam * 100;
                valosVeletlenSzam = Math.Round(valosVeletlenSzam);
                valosVeletlenSzam = valosVeletlenSzam / 100;

                tomb[i] = valosVeletlenSzam;
            }
        }

        private static void ListazValosTomb(double[] tomb)
        {
            foreach (double elem in tomb)
            {
                Console.Write(elem + ", ");
            }

            Console.WriteLine();
        }

        private static int LegnagyobbParosSzam(int[] tomb)
        {
            bool talaltParosSzamot = false;
            int maximalisIndex = 0;

            foreach (int elem in tomb)
            {
                if (elem % 2 == 0)
                {
                    talaltParosSzamot = true;

                    if (elem > maximalisIndex)
                    {
                        maximalisIndex = elem;
                    }
                }
            }

            if (talaltParosSzamot)
                return maximalisIndex;
            else
                return -1;
        }

        private static int MegszamolNegyzetszamokat(int[] tomb)
        {
            int negyzetszamokDarabszama = 0;

            foreach (int elem in tomb)
            {
                if (NegyzetSzamE(elem))
                    negyzetszamokDarabszama++;

            }

            //foreach (int elem in tomb)
            //{
            //    int elemNegyzetgyoke = (int)Math.Sqrt(elem);

            //    if (elemNegyzetgyoke * elemNegyzetgyoke == elem)
            //        negyzetszamokDarabszama++;
            //}

            return negyzetszamokDarabszama;
        }

        private static bool NegyzetSzamE(int egeszSzam)
        {
            if (egeszSzam == 1)
                return true;

            for (int i = 1; i <= egeszSzam / 2; i++)
            {
                if (i * i == egeszSzam)
                    return true;
            }

            return false;
        }

        private static double GeometriaiAtlag(double[] tomb)
        {
            double atlag = 1;

            foreach (double elem in tomb)
            {
                atlag *= elem;
            }

            return Math.Pow(atlag, 1.0 / tomb.Length);
        }

        private static void ListazKarakterTomb(char[] tomb)
        {
            foreach (char elem in tomb)
            {
                Console.Write(elem + ", ");

            }

            Console.WriteLine();
        }

        private static int EgeszetBeolvas(string uzenet)
        {
            //controlled integer reading
            int size;
            string readString;
            bool successRead;

            do
            {
                Console.WriteLine(uzenet);

                readString = Console.ReadLine();
                successRead = Int32.TryParse(readString, out size);

                if (!successRead)
                {
                    Console.WriteLine("Nem szamot adott meg!");
                }
            } while (!successRead);

            return size;
        }
    }
}

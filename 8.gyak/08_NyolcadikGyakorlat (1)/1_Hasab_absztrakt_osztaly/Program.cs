using System;
using testeketHasznalo;

namespace testek.futtathato
{
    //futtatható osztály, tartalmaz egy statikus Main metódust
    class TestekTeszt
    {
        static void Main(string[] args)
        {
            #region Elso resz, henger es teglatest tesztelese
            //létrehoz egy Henger-t,
            Henger henger = new Henger(3, 4);

            //majd kiírja az adatait és a térfogatát,
            Console.WriteLine("A henger:");
            Console.WriteLine(henger);
            Console.WriteLine("Térfogat: {0:n3}", henger.Terfogat());

            //majd létrehoz egy Teglatest-et, és kiírja az adatait és a térfogatát, 
            Teglatest teglatest = new Teglatest(1, 2, 3);

            Console.WriteLine("\nA téglatest:");
            Console.WriteLine(teglatest);
            Console.WriteLine("Térfogat: " + String.Format("{0:n3}", teglatest.Terfogat()));

            //majd kiírja a nagyobb térfogatút!
            Console.WriteLine();
            Console.WriteLine("teglatest.NagyobbTerfogatuMint(henger):");
            Console.WriteLine(teglatest.NagyobbTerfogatuMint(henger));

            Console.WriteLine("henger.NagyobbTerfogatuMint(teglatest):");
            Console.WriteLine(henger.NagyobbTerfogatuMint(teglatest));

            Console.WriteLine();
            Console.Write("A nagyobb térfogatú ");
            if (teglatest.NagyobbTerfogatuMint(henger))
            {
                Console.WriteLine("a téglatest.");
            }
            else
            {
                Console.WriteLine("a henger (vagy egyenlőek).");
            }

            Console.WriteLine();
            #endregion

            #region Masodik resz, hasabtomb tesztelese
            //amelyben létrehoz egy 5 elemű hasáb tömb objektumot
            Hasabok hasabok = new Hasabok(5);

            //majd beállít hasraütésszerű adatokkal 2 Henger-t és 1 Teglatest-et, 
            hasabok[0] = null;
            hasabok[1] = new Henger(3, 3);
            hasabok[2] = new Henger(4, 4);
            hasabok[3] = new Teglatest(1, 2, 3);

            //majd kiírja az összes hasáb adatát,
            for (int i = 0; i < hasabok.TombMerete; i++)
            {
                if (hasabok[i] != null)
                {
                    Console.WriteLine(hasabok[i]);
                }                
            }

            //majd a hasábok átlagos térfogatát, majd a Henger-ek számát.
            Console.WriteLine("Hengerek száma: {0}", hasabok.HengerekSzama);
            Console.WriteLine("Átlagos térfogat: {0:n3}", hasabok.AtlagosTerfogat());
            #endregion
        }
    }
}

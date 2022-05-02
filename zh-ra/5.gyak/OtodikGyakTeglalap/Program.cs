//#define TeglalapTomb
using System;

namespace OtodikGyakTeglalap
{
    class Futtathato
    {
#if !TeglalapTomb
        static void Main(string[] args)
        {
            //Teglalap teglalapA = new Teglalap(1, 2);
            Teglalap teglalapA;
            teglalapA = new Teglalap(1, 2);

            Teglalap teglalapB = new Teglalap(1, 2);
            //Teglalap teglalapC = teglalapA;
            Teglalap teglalapC;
            teglalapC = teglalapA;

            Teglalap negyzet = new Teglalap(15);

            Console.WriteLine("Objektumok letrehozasa utan");
            Console.WriteLine(teglalapA);
            Console.WriteLine(teglalapA.ToString());
            Console.WriteLine(teglalapB);
            Console.WriteLine(teglalapC);

            teglalapA.AOldal = 11;
            teglalapA.BOldal = 22;

            Console.WriteLine("teglalapA megvaltoztatasa utan");
            Console.WriteLine(teglalapA);
            Console.WriteLine(teglalapB);
            Console.WriteLine(teglalapC);

            //teglalapB.AOldal = 11;
            //teglalapB.BOldal = 22;
            teglalapB.SetTeglalap(11, 22);

            Console.WriteLine("teglalapB modositasa utan");
            Console.WriteLine(teglalapA);
            Console.WriteLine(teglalapB);
            Console.WriteLine(teglalapC);

            Console.WriteLine("Osszehasonlitasok");
            Console.WriteLine("teglalapA == teglalapB");
            Console.WriteLine(teglalapA == teglalapB);
            Console.WriteLine(teglalapA.Equals(teglalapB));

            Console.WriteLine("teglalapA == teglalapC");
            Console.WriteLine(teglalapA == teglalapC);            
            Console.WriteLine(teglalapA.Equals(teglalapC));

            Console.WriteLine("TeglalapOldalaiMegegyeznek metodus meghivasa");
            Console.Write("teglalapA.TeglalapOldalaiMegegyeznek(teglalapB): ");
            Console.WriteLine(teglalapA.TeglalapOldalaiMegegyeznek(teglalapB));

            Console.WriteLine("Negyzet:");
            Console.WriteLine(negyzet);

            if (teglalapA.NagyobbTeruletuMint(negyzet))
            {
                Console.WriteLine("A teglalap terulete nagyobb, mint a negyzete.");
            }
            else
            {
                Console.WriteLine("A teglalap terulete nem nagyobb (kisebb, vagy egyenlo), mint a negyzete.");
            }
        }
#else
        static void Main(string[] args)
        {
            int tombmeret = 10;
            int minimalisOldalhossz = 2;
            int maximalisOldalhossz = 10;
            Teglalap[] teglalapok = new Teglalap[tombmeret];
            Random veletlenObjektum = new Random();

            for (int i = 0; i < teglalapok.Length; i++)
            {
                teglalapok[i] = new Teglalap(veletlenObjektum.Next(minimalisOldalhossz, maximalisOldalhossz + 1),
                                            veletlenObjektum.Next(minimalisOldalhossz, maximalisOldalhossz + 1));
            }

            foreach (Teglalap teglalap in teglalapok)
            {
                Console.WriteLine(teglalap);
            }

            Console.WriteLine("Legkisebb teruletu teglalap:");
            //megoldas for-ral
            Console.WriteLine(teglalapok[MinimalisTeruletuTeglalap(teglalapok)]);

            //megoldas foreach-csel
            Teglalap minimalisTeruletuTeglalapObjektum = teglalapok[0];

            foreach (Teglalap teglalap in teglalapok)
            {
                if (minimalisTeruletuTeglalapObjektum.NagyobbTeruletuMint(teglalap))
                {
                    minimalisTeruletuTeglalapObjektum = teglalap;
                }
            }

            Console.WriteLine(minimalisTeruletuTeglalapObjektum);

            Console.Write("Teglalap a oldala: ");
            int aOldalHossz = Convert.ToInt32(Console.ReadLine());

            Console.Write("Teglalap b oldala: ");
            int bOldalHossz = Convert.ToInt32(Console.ReadLine());

            Teglalap vizsgalandoUjTeglalap = new Teglalap(aOldalHossz, bOldalHossz);

            Console.WriteLine("Uj teglalap");
            Console.WriteLine(vizsgalandoUjTeglalap);

            Console.WriteLine("Nagyobb teruletu teglalapok szama: " +
                        NagyobbTeruletuTeglalapokSzama(teglalapok, vizsgalandoUjTeglalap));

            if (MegegyezoOldalhosszusaguTeglalapIndexe(teglalapok, vizsgalandoUjTeglalap) < 0)
                Console.WriteLine("Nincs egyezo teglalap a vizsgalandoval.");
            else
                Console.WriteLine("Egyezo oldalhosszusagu teglalap indexe: "
                    + MegegyezoOldalhosszusaguTeglalapIndexe(teglalapok, vizsgalandoUjTeglalap));
        }

        public static int MinimalisTeruletuTeglalap(Teglalap[] teglalaptomb)
        {
            int minimalisIndex = 0;

            for (int i = 1; i < teglalaptomb.Length; i++)
            {
                //if (teglalaptomb[i].Terulet() < teglalaptomb[minimalisIndex].Terulet())
                //if (!teglalaptomb[i].NagyobbTeruletuMint(teglalaptomb[minimalisIndex]))
                if (teglalaptomb[minimalisIndex].NagyobbTeruletuMint(teglalaptomb[i]))
                {
                    minimalisIndex = i;
                }
            }

            return minimalisIndex;
        }

        public static int NagyobbTeruletuTeglalapokSzama(Teglalap[] teglalaptomb, Teglalap mintateglalap)
        {
            int nagyobbTeglalapokSzama = 0;

            //for (int i = 0; i < teglalaptomb.Length; i++)
            //{
            //    if (teglalaptomb[i].Terulet() > mintateglalap.Terulet())
            //        nagyobbTeglalapokSzama++;
            //}
            foreach (Teglalap teglalap in teglalaptomb)
            {
                //if (teglalap.Terulet() > mintateglalap.Terulet())
                //if (!mintateglalap.NagyobbTeruletuMint(teglalap))
                if (teglalap.NagyobbTeruletuMint(mintateglalap))
                    nagyobbTeglalapokSzama++;
            }

            return nagyobbTeglalapokSzama;
        }

        public static int MegegyezoOldalhosszusaguTeglalapIndexe(Teglalap[] teglalaptomb, Teglalap mintateglalap)
        {
            int egyenloOldaluTeglalapIndexe = -1;

            for (int i = 0; i < teglalaptomb.Length; i++)
            {
                //if (teglalaptomb[i].TeglalapOldalaiMegegyeznek(mintateglalap))
                if (mintateglalap.TeglalapOldalaiMegegyeznek(teglalaptomb[i]))
                {
                    egyenloOldaluTeglalapIndexe = i;
                    break;
                }
            }

            return egyenloOldaluTeglalapIndexe;
        }
#endif
    }
}

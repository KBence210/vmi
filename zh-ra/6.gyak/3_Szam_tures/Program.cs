using myNamespace.first;
using System;

namespace myNamespace
{
	namespace second
    {
		//ugyanaz, mint
		//namespace myNamespace.second
	}
}

namespace myNamespace.second
{
    class FuttathatoOsztaly
    {
		//readonly static first.Szam valosSzam = new first.Szam(0.42);

		//using myNamespace.first; hasznalata
		readonly static Szam valosSzam = new Szam(0.42);

		//const-nak konstans ertek kell
		//const Szam valosSzam = new Szam(0.42);//hibas

		static void Main(string[] args)
        {
			Random veletlenObjektum = new Random();

			int probakSzama = 0;
			bool talalt = false;

			while (!talalt)
			{
				double veletlenValoSzam = veletlenObjektum.NextDouble();

				Console.WriteLine(veletlenValoSzam);
				probakSzama++;

				if (valosSzam.ElteresTuresenBelulVan(veletlenValoSzam))
				{
					talalt = true;
				}
			}

			Console.WriteLine("Generalt szamok szama: " + probakSzama);

			//a Szam osztaly adattagjanak erteke megvaltoztathato
			valosSzam.SetValosSzam(0.5);

			//a konstans osztalyvaltozo erteket nem lehet modosotani
			//a referencia vegig ugyanarra mutat
			//valosSzam = new Szam(0.314); 
		}
	}
}

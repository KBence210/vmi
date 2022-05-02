using System;

namespace Alkalmazott
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Alkalmazottak szama:");
			int alkalmazottakSzama = Convert.ToInt32(Console.ReadLine());

			Alkalmazott[] alkalmazottak = new Alkalmazott[alkalmazottakSzama];

			for (int i = 0; i < alkalmazottak.Length; i++)
			{
				Console.WriteLine((i + 1) + ". alkalmazott: ");
				Console.Write("Nev: ");
				string nev = Console.ReadLine();

				Console.Write("Szuletes napja (ev.honap.nap.): ");
				string[] szuletesnap = Console.ReadLine().Split(".");
				int ev, honap, nap;

                if (!Int32.TryParse(szuletesnap[0], out ev))
                {
					ev = DateTime.Now.Year;
                }

				if (!Int32.TryParse(szuletesnap[1], out honap))
				{
					honap = 1;
				}

				if (!Int32.TryParse(szuletesnap[2], out nap))
				{
					nap = 1;
				}

				alkalmazottak[i] = new Alkalmazott(nev, ev, honap, nap);
				//alkalmazottak[i] = new Alkalmazott(nev, new DateTime(ev, honap, nap));
			}

			Console.WriteLine("Alkalmazottak listaja:");
			AlkalmazottakListaja(alkalmazottak);
		}

		private static void AlkalmazottakListaja(Alkalmazott[] alkalmazottak)
		{
			foreach (Alkalmazott alkalmazott in alkalmazottak)
			{
				Console.WriteLine(alkalmazott);
				Console.WriteLine(alkalmazott.ToString("kor"));
				Console.WriteLine(alkalmazott.ToString("szuletesnapja"));
			}
		}
	}
}

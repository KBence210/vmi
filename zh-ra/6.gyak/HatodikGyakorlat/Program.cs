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

				Console.Write("Kor: ");
				int kor = Convert.ToInt32(Console.ReadLine());

				Console.Write("Fizetes: ");
				long fizetes = Convert.ToInt64(Console.ReadLine());

				alkalmazottak[i] = new Alkalmazott(nev, kor, fizetes);
			}

            Console.WriteLine("Alkalmazottak listaja:");
			AlkalmazottakListaja(alkalmazottak);

			Alkalmazott.SetNyugdijkorhatar(70);

			Console.WriteLine("Alkalmazottak listaja nyugdijkorhatar modositasa utan:");
			AlkalmazottakListaja(alkalmazottak);

			int nyugdijhozKozeliEv = 15;
			//Alkalmazottak, akiknek 15 evnel kevesebb van hatra nyugdijig
			//Console.WriteLine("Nyugdijig kevesebb mint " + nyugdijhozKozeliEv + " ev van hatra:");
			Console.WriteLine($"Nyugdijig kevesebb mint {nyugdijhozKozeliEv} ev van hatra:");

			foreach (Alkalmazott alkalmazott in alkalmazottak)
            {
				if (alkalmazott.EvekszamaNyugdijig() < nyugdijhozKozeliEv)
					Console.WriteLine(alkalmazott);
			}

			//Alkalmazottak, akiknek az atlagnal tobb van hatra nyugdijig
			int atlag = AtlagEvekszamaNyugdijig(alkalmazottak);
			//Console.WriteLine("Nyugdijig hatralevo evek atlaga: " + atlag);
			Console.WriteLine($"Nyugdijig hatralevo evek atlaga: {atlag}");

			foreach (Alkalmazott alkalmazott in alkalmazottak)
			{
				if (alkalmazott.EvekszamaNyugdijig() > atlag)
					Console.WriteLine(alkalmazott);
			}

			//Nyugdijig hatralevo evek alapjan novekvo rendezes, listazas
			Console.WriteLine("Rendezett lista: ");
			AlkalmazottakRendezese(alkalmazottak);
			AlkalmazottakListaja(alkalmazottak);

			//Forditott sorrendu kiiras
			Console.WriteLine("Rendezett lista forditva:");
			for (int i = alkalmazottak.Length - 1; i >= 0; i--)
			{
				Console.WriteLine(alkalmazottak[i]);
			}
		}

		private static void AlkalmazottakListaja(Alkalmazott[] alkalmazottak)
		{
			foreach (Alkalmazott alkalmazott in alkalmazottak)
			{
				Console.WriteLine(alkalmazott);
			}
		}

		public static int AtlagEvekszamaNyugdijig(Alkalmazott[] alkalmazottak)
		{
			int atlag = 0;

			foreach (Alkalmazott alkalmazott in alkalmazottak)
			{
				atlag += alkalmazott.EvekszamaNyugdijig();
			}

			atlag = atlag / alkalmazottak.Length;
			
			return atlag;

			//return atlag / alkalmazottak.Length;
		}

		private static void AlkalmazottakRendezese(Alkalmazott[] alkalmazottak)
		{
			for (int i = 0; i < alkalmazottak.Length; i++)
			{
				int minimalisIndexe = i;

				for (int j = i + 1; j < alkalmazottak.Length; j++)
				{
					if (alkalmazottak[j].EvekszamaNyugdijig() < alkalmazottak[minimalisIndexe].EvekszamaNyugdijig())
					{
						minimalisIndexe = j;
					}
				}

				//Helycsere, ha szukseges
				if (minimalisIndexe != i)
				{
					Alkalmazott tmp = alkalmazottak[i];
					alkalmazottak[i] = alkalmazottak[minimalisIndexe];
					alkalmazottak[minimalisIndexe] = tmp;
				}
			}
		}
	}
}

using System;

namespace _3_Masodfoku_egyenlet
{
    class Program
    {
        static void Main(string[] args)
        {
			//pelda egyutthatokra
			//1 -1 -2
			//1 2 1
			//a masodfoku egyenlet konstansai 
			double a, b, c;
			//a masodfoku egyenlet valos gyokei
			double x1 = 0, x2 = 0;

			int megoldasok_szama;
			double diszkriminans;

			/*
			Console.WriteLine("Kerem adja meg az egyutthatokat!\na=");
			a = 
			Console.WriteLine("b=");
			b = 
			Console.WriteLine("c=");
			c = 
			*/

			Console.WriteLine("Kerem adja meg az egyutthatokat vesszovel elvalasztva!");
			Console.Write("egyutthatok=");

			string egyutthatok = Console.ReadLine();
			string[] eredmenytomb = egyutthatok.Split(",");

			a = Double.Parse(eredmenytomb[0]);
			b = Double.Parse(eredmenytomb[1]);
			c = Double.Parse(eredmenytomb[2]);

			if (a == 0)
			{
				megoldasok_szama = 0;
			}
			else
			{
				x2 = 2 * a;
				diszkriminans = b * b - 4 * a * c;

				if (diszkriminans > 0)
				{
					diszkriminans = Math.Sqrt(diszkriminans);
					x1 = (-b + diszkriminans) / x2;
					x2 = (-b - diszkriminans) / x2;
					megoldasok_szama = 2;
				}
				else if (diszkriminans == 0)
				{
					x1 = -b / x2;
					megoldasok_szama = 1;
				}
				else
				{
					megoldasok_szama = 0;
				}
			}

			switch (megoldasok_szama)
			{
				case 2:
					Console.WriteLine("2 megoldas van.");
					Console.WriteLine("x1= " + x1 + ", x2= " + x2);
					break;

				case 1:
					Console.WriteLine("1 megoldas van.\nx= " + x1);
					break;

				default:
					Console.WriteLine("Nincs megoldas a valos szamok halmazan.");
					break;
			}
		}
    }
}

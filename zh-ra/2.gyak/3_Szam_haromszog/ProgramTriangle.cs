using System;

namespace _3_Szam_haromszog
{
    class Program
    {
        static void Main(string[] args)
        {
			//Írja ki a számokat az értéküknek megfelelő
			//számszor egymás után:
			//1
			//2 2
			//3 3 3
			//4 4 4 4
			//5 5 5 5 5		

			int n = 5;

			for (int i = 1; i <= n; i++)
			{
				for (int j = 0; j < i; j++)
				{
					//Console.Write(i + " ");
					Console.Write($"{i,3} ");
				}

				Console.WriteLine();
			}
		}
    }
}

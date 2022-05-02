using Pontok;
using System;
using System.Drawing;
using szinezheto;
using Szinezheto;
using Termekek;

namespace Futtathato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("interface-ek");

            ISzinezheto szinespont = new Szinespont(Szinespont.Szinek.ZOLD);
            ISzinezheto toll = new Toll("Parker", 
                                Szinespont.Szinek.PIROS, 200);

            Console.WriteLine(szinespont);
            Console.WriteLine(toll);

            SetDefaultColor(szinespont);
            SetDefaultColor(toll);

            Console.WriteLine(szinespont);
            Console.WriteLine(toll);

            Console.WriteLine("\nConsoleColor.Red - enum");
            Console.WriteLine(ConsoleColor.Red);
            Console.WriteLine((int)ConsoleColor.Red);

            Console.WriteLine("\nColor.Red - struct");
            Console.WriteLine(Color.Red);
            Console.WriteLine(Color.Red.Name);
            Console.WriteLine(Color.Red.ToKnownColor());
            Console.WriteLine(Color.Red.ToArgb());
            Console.WriteLine(Color.FromArgb(Color.Red.ToArgb()));
            Console.WriteLine(Color.FromName("Red"));

            MagyarSzin magyarSzinNev = new MagyarSzin(Color.Red);
            Console.WriteLine(magyarSzinNev);

            magyarSzinNev = new MagyarSzin("RED");
            Console.WriteLine(magyarSzinNev);
        }

        static void SetDefaultColor(ISzinezheto objektum)
        {
            objektum.Szin = objektum.AlapertelmezettSzin;
        }
    }
}

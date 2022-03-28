using pontok;
using System;
using System.Drawing;
using szinezheto;
using termekek;
using static pontok.SzinesPont;

//Készítsen egy futtatható osztályt új névtérben ,
namespace futtathato
{    
    class InterfaceTest
    {
        static void Main(string[] args)
        {
            //amelyben egy ISzinezheto típusú referenciának SzinesPont példányt add értékül,
            //kiírja az adatait, majd átszínezi és kiírja az adatait!
            ISzinezheto szinesPont = new SzinesPont(1, 1, Szinek.PIROS);

            Console.WriteLine(szinesPont);
            szinesPont.Szin = Szinek.KEK;
            Console.WriteLine(szinesPont);

            //Ugyanezt próbálja ki egy Toll objektummal is!
            //Ugyanezt kipróbálja egy Toll objektummal is. 
            ISzinezheto toll = new Toll("Parker", Szinek.FEKETE, 100);

            Console.WriteLine(toll);
            toll.Szin = Szinek.SARGA;
            Console.WriteLine(toll);

            //A Main-t is egészítse ki úgy, hogy
            //használja a metódust egy SzinesPont példánnyal és egy Toll példánnyal is.
            Console.WriteLine("\nÁtszínezés");

            SetAlapertelmezettSzin(szinesPont);
            Console.WriteLine(szinesPont);

            SetAlapertelmezettSzin(toll);
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

        //Készítsen az osztályba egy statikus metódust,
        //amely paraméterként egy ISzinezheto objektumot vár és az objektumot átszínezi alapszínre!
        static void SetAlapertelmezettSzin(ISzinezheto objektum)
        {
            objektum.Szin = objektum.AlapertelmezettSzin;
        }
    }
}

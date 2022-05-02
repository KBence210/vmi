using System;

namespace Testek
{
    namespace Futtathato
    {

    }

}


namespace Testek.Futtathato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hasabok");

            Henger henger = new Henger(2, 5);
            Teglatest teglatest = new Teglatest(2, 3, 5);

            Console.WriteLine(henger);
            Console.WriteLine(teglatest);

            if (henger.NagyobbTerfogatuMint(teglatest))
            {
                Console.WriteLine("henger nagyobb terfogatu");
            }
            else if (teglatest.NagyobbTerfogatuMint(henger))
            {
                Console.WriteLine("teglatest nagyobb terfogagtu");
            }
            else
            {
                Console.WriteLine("egyforma terfogatuak");
            }

            TestekHasznalata.Hasabok hasabok = 
                                new TestekHasznalata.Hasabok(5);

            hasabok[0] = new Henger(1, 2);
            hasabok[2] = new Teglatest(1, 2, 3);

            Console.WriteLine(hasabok[0]);
            Console.WriteLine(hasabok[1] == null);
            Console.WriteLine(hasabok.NemNullErtekuTombelemekSzama);
        }
    }
}

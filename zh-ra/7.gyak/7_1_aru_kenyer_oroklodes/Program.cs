using System;

namespace Termekeink
{
    namespace Proba
    {

    }
}


namespace Termekeink.Proba
{
    class FuttathatoOsztaly
    {
        static void Main(string[] args)
        {
            Termekeink.Kenyer feherKenyer = new Termekeink.Kenyer("feher", 200, 27, 0.75);
            Kenyer barnaKenyer = new Kenyer("barna", 210, 27, 1);
            Aru aru = new Aru("altalnos aru", 100, 5);

            Console.WriteLine(feherKenyer);
            Console.WriteLine(barnaKenyer);
            Console.WriteLine(aru);

            Console.WriteLine(aru.BruttoAratOsszhasonlit(feherKenyer));
            Console.WriteLine(feherKenyer.BruttoAratOsszhasonlit(aru));
            Console.WriteLine(feherKenyer.BruttoAratOsszhasonlit(barnaKenyer));

            Console.WriteLine(Kenyer.KenyereketOsszhasonlit(feherKenyer,
                                barnaKenyer));

            Aru kenyer = new Kenyer("kenyer", 100, 27, 1);

            Console.WriteLine(kenyer);
            Console.WriteLine(   ((Kenyer)kenyer).Mennyiseg    );

            Console.WriteLine(Kenyer
                .KenyereketOsszhasonlit(feherKenyer, (Kenyer)kenyer));

            if (Kenyer
                    .KenyereketOsszhasonlit(feherKenyer, (Kenyer)kenyer))
            {
                Console.WriteLine(feherKenyer);
                Console.WriteLine("a nagyobb egysegaru");
            }


            Console.WriteLine("Hello World!");
        }
    }
}

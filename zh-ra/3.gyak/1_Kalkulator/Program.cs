using System;

namespace _1_Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kerem adja meg az 1. operandust!");
            int elso_operandus = EgeszetBeolvas("1. operandus:");

            Console.WriteLine("Kerem adja meg az 2. operandust!");
            int masodik_operandus = EgeszetBeolvas("2. operandus:");

            Console.WriteLine("Kerem adja meg a muveletet (az operatort)!");
            Console.WriteLine("a muvelet:");
            string muvelet = Console.ReadLine();

            Alapmuveletek(elso_operandus, masodik_operandus, muvelet);

            string valasz;

            do
            {
                Console.WriteLine("Kerem adja meg a kiszamitando kifejezest szokozzel elvalasztva!");
                Console.WriteLine("a kifejezes:");
                string kifejezes = Console.ReadLine();

                string[] eredmenytomb = kifejezes.Split(' ');

                elso_operandus = int.Parse(eredmenytomb[0]);
                masodik_operandus = int.Parse(eredmenytomb[2]);
                muvelet = eredmenytomb[1];

                Alapmuveletek(elso_operandus, masodik_operandus, muvelet);

                Console.WriteLine("Szeretne meg uj muveletet megadni?");
                Console.WriteLine("valasz (igen/nem): ");
                valasz = Console.ReadLine();
            } while (valasz.Equals("igen"));
        }

        public static void Alapmuveletek(int elso_operandus, int masodik_operandus, string muvelet)
        {
            switch (muvelet[0])
            {//ez egy karakter
                case '+':
                    Console.WriteLine("az osszeadas eredmenye");
                    //Console.WriteLine(elso_operandus + " + " + masodik_operandus + " = " + elso_operandus + masodik_operandus);
                    Console.WriteLine($"{elso_operandus} + {masodik_operandus} = {elso_operandus + masodik_operandus}");
                    break;

                case '-':
                    Console.WriteLine("a kivonas eredmenye");
                    Console.WriteLine(elso_operandus + " - " + masodik_operandus + " = " + (elso_operandus - masodik_operandus));
                    break;

                case '*':
                    Console.WriteLine("a szorzas eredmenye");
                    Console.WriteLine(elso_operandus + " * " + masodik_operandus + " = " + elso_operandus * masodik_operandus);
                    break;

                case '/':

                    if (masodik_operandus == 0)
                    {
                        Console.WriteLine("0-val nem lehet osztani! Vegtelent fog adni eredmenyul.");
                    }

                    Console.WriteLine("az osztas eredmenye");
                    Console.WriteLine(elso_operandus + " / " + masodik_operandus + " = " + (double)elso_operandus / masodik_operandus);
                    break;

                default:
                    Console.WriteLine("Nem a 4 alapmuvelet (+, -, *, /) egyiket adta meg!");
                    break;
            }
        }//public static void alapmuveletek

        private static int EgeszetBeolvas(string uzenet)
        {
            //controlled integer reading
            int size;
            string readString;
            bool successRead;

            do
            {
                Console.WriteLine(uzenet);

                readString = Console.ReadLine();
                successRead = Int32.TryParse(readString, out size);

                if (!successRead)
                {
                    Console.WriteLine("Nem szamot adott meg!");
                }
            } while (!successRead);

            return size;
        }
    }
}

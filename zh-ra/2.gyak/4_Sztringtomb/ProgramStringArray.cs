using System;

namespace _4_Sztringtomb
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = ReadInteger(1, 10);
            string[] nameArray = new string[size];

            Console.WriteLine("Enter names: ");

            for (int i = 0; i < nameArray.Length; i++)
            {
                nameArray[i] = Console.ReadLine();
            }

            //comparison of names
            int count = 0;

            for (int i = 0; i < nameArray.Length; i++)
            {
                for (int j = i + 1; j < nameArray.Length; j++)
                {
                    //if (string.Equals(nameArray[i], nameArray[j]))                    
                    //if (nameArray[i] == nameArray[j])
                    if (nameArray[i].Equals(nameArray[j]))
                    {
                        Console.WriteLine("Same name indexes: " + i + " and " + j);
                        count++;
                    }
                }
            }

            Console.WriteLine("Total same name: " + count);

            //they have the same initials
            count = 0;

            for (int i = 0; i < nameArray.Length; i++)
            {
                for (int j = i + 1; j < nameArray.Length; j++)
                {
                    //if (nameArray[i].Substring(0, 1) == nameArray[j].Substring(0, 1))
                    if (nameArray[i][0] == nameArray[j][0])
                    {
                        Console.WriteLine("Pair indexes of same initials: " + i + " and " + j);
                        count++;
                    }
                }
            }

            Console.WriteLine("Total same initials: " + count);
        }

        private static int ReadInteger(int lowerNumber, int upperNumber)
        {
            //controlled integer reading
            int size;
            string readString;
            bool successRead;

            do
            {
                Console.WriteLine("Enter a number between " + lowerNumber + " and " + upperNumber);

                readString = Console.ReadLine();
                successRead = Int32.TryParse(readString, out size);

                if (!successRead)
                {
                    Console.WriteLine("That's not a number");
                }
            } while (!successRead || size < lowerNumber || size > upperNumber);

            return size;
        }
    }
}

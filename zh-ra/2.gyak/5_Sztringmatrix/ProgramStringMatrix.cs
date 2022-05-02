using System;

namespace _5_Sztringmatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = 2;
            string[][] stringMatrix = new string[numberOfPeople][];

            for (int i = 0; i < stringMatrix.Length; i++)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Number of e-mail addresses: ");
                int emailNumber = Readint(0, 3);

                stringMatrix[i] = new string[emailNumber + 1];
                stringMatrix[i][0] = name;

                for (int j = 1; j < emailNumber + 1; j++)
                {
                    Console.Write(j + ". email address: ");
                    stringMatrix[i][j] = Console.ReadLine();
                }

                Console.WriteLine();
            }

            MatrixList(stringMatrix);

            Console.WriteLine();
            //Console.WriteLine(CountEmails(stringMatrix) + " people have more than one email address.");
            Console.WriteLine($"{CountEmails(stringMatrix)} people have more than one email address.");
        }

        private static int Readint(int lowerNumber, int upperNumber)
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

        private static void MatrixList(string[][] matrix)
        {
            int rows = matrix.Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    //Console.Write(matrix[i][j] + " ");
                    Console.Write($"{matrix[i][j]} ");
                }

                Console.WriteLine();
            }
        }

        private static int CountEmails(string[][] matrix)
        {
            int count = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i].Length > 2)
                {
                    count++;
                }
            }
            
            return count;
        }
    }
}

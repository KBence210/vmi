using System;

namespace KetdimenziosTomb
{
    class KetdimenziosTomb
    {
        static void Main(string[] args)
        {
            int[,] matrixEgyik = { {1, 2, 3},
                                   {4, 5, 6},
                                   {7, 8, 9}
                                 };

            Console.WriteLine("sorok szama: " + matrixEgyik.GetLength(0));
            Console.WriteLine("oszlopok szama: " + matrixEgyik.GetLength(1));
            Console.WriteLine();

            int[][] matrix =  { new int[] {1, 2, 3},
                                new int[] {4, 5, 6},
                                new int[] {7, 8, 9}
                              };

            Listaz(matrix);
            Console.WriteLine();

            int searchkey = 5;

            if (LinearisKereses(matrix, searchkey))
                Console.WriteLine("Searchkey: " + searchkey + " found.");
            else
                Console.WriteLine("Searchkey: " + searchkey + " not found.");
        }

        private static void Listaz(int[][] matrix)
        {
            int rows = matrix.Length;    //matrix sorainak szama            

            for (int i = 0; i < rows; i++)
            {
                int columns = matrix[i].Length; //matrix oszlopainak szama

                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0,3}", matrix[i][j]);
                }

                Console.WriteLine();
            }
        }

        private static bool LinearisKereses(int[][] matrix, int searchkey)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == searchkey)
                        return true;
                }
            }
         
            return false;
        }
    }
}
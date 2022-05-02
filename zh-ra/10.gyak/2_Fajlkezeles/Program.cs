using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _2_Fajlkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Jane");
            names.Add("John");

            string fileName = "group.txt";
            FileStream fileStream = null;
            StreamWriter streamWriter = null;
            StreamReader streamReader = null;

            //iras
            try
            {
                //fileStream = new FileStream(fileName, FileMode.OpenOrCreate);
                fileStream = new FileStream(fileName, FileMode.Create);

                //using hasznalata jovore
                //feluliras
                //streamWriter = new StreamWriter(fileName, false, Encoding.ASCII);
                streamWriter = new StreamWriter(fileStream, Encoding.ASCII);

                foreach (var name in names)
                {
                    streamWriter.WriteLine(name);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erron in writing file.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamWriter != null)
                    streamWriter.Close();
            }

            //olvasas
            try
            {
                streamReader = new StreamReader(fileName);

                while (!streamReader.EndOfStream)
                {
                    string readLine = streamReader.ReadLine();
                    Console.WriteLine("Name: " + readLine);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erron in reading file.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Close();
            }

            names.Remove("Jane");
            names.Add("Judy");
            names.Sort();

            Console.WriteLine("\nNew list");

            foreach (var name in names)
            {
                Console.WriteLine("Name:" + name);
            }
        }
    }
}

using System;
using System.Linq;

namespace _1_Egyetemi_alkalmazott
{
    //futtatható osztály, tartalmaz egy statikus Main metódust
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee[] employeeArray = new UniEmployee[5];

            employeeArray[0] = new UniEmployee("Feri", 30, "ME", Position.OKTATO);
            employeeArray[1] = new UniEmployee("Jani", 55, "ME", Position.PROF);
            employeeArray[2] = new UniEmployee("Misi", 50, "ME", Position.OKTATO);
            employeeArray[3] = new UniEmployee("Emese", 40, "ME", Position.OKTATO);
            employeeArray[4] = new UniEmployee("Monika", 45, "ME", Position.ADMIN);

            ListArray(employeeArray);
            Statistics(employeeArray);

            //rendezése lambda kifejezes használatával

            //Fizetés szerint növekvő rendezés
            Array.Sort(employeeArray, (a, b) => a.GetSalary().CompareTo(b.GetSalary()));
            ListArray(employeeArray);

            //Életkor szerint csökkenő rendezés
            Array.Sort(employeeArray, (a, b) => b.GetAge().CompareTo(a.GetAge()));
            ListArray(employeeArray);

            //Fizetés, majd névsor szerint rendezés
            //kátszintű rendezés
            Array.Sort(employeeArray, (a, b)
                          =>
            {
                var salaryComparison = a.GetSalary().CompareTo(b.GetSalary());
                if (salaryComparison == 0)
                    return a.GetName().CompareTo(b.GetName());
                else return salaryComparison;
            });
            ListArray(employeeArray);

            //rendezés linq használatával
            ListArray(employeeArray
                      .OrderBy(x => x.GetSalary())
                      .ThenByDescending(x => x.GetName())
                      //.Reverse()
                      .ToArray());


            //rendezés IComparer interface implementálásával
            //előnye, hogy nem kötődik szorosan az eredeti osztályhoz
            //rugalmas, mert olyan osztálynál is használhatjuk,
            //amelynek implementációjához nem férünk hozzá
            //továbbá, hogy többféle rendezés definiálható

            //IComparer interface-t implementáló osztály használatával
            Array.Sort(employeeArray, new Employee.SortAgeHelper());
            ListArray(employeeArray);

            //IComparer interface-t implementáló külső osztály használatával
            Array.Sort(employeeArray, new SortNameHelper());
            ListArray(employeeArray);

            //IComparer interface-t implementáló osztály használatával
            Array.Sort(employeeArray, Employee.SortAge());
            ListArray(employeeArray);


            //rendezése IComparable interface implementálásával		
            //általában olyan adatszerkezeteknél követelmény,
            //amelyek az elemeiken megvalósítanak valamilyen rendezést
            //a beépített típusok mindegyike megvalósítja az IComparable interface-t
            //hátránya, hogy csak egyféle rendezés definiálható

            UniEmployeeComparable[] employeeComparableArray = new UniEmployeeComparable[5];

            employeeComparableArray[0] = new UniEmployeeComparable("Feri", 30, "ME", Position.OKTATO);
            employeeComparableArray[1] = new UniEmployeeComparable("Jani", 55, "ME", Position.PROF);
            employeeComparableArray[2] = new UniEmployeeComparable("Misi", 50, "ME", Position.OKTATO);
            employeeComparableArray[3] = new UniEmployeeComparable("Emese", 40, "ME", Position.OKTATO);
            employeeComparableArray[4] = new UniEmployeeComparable("Monika", 45, "ME", Position.ADMIN);

            Array.Sort(employeeComparableArray);
            ListArray(employeeComparableArray);
        }

        public static void ListArray(Employee[] employeeArray)
        {
            foreach (Employee e in employeeArray)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();
        }

        private static void Statistics(Employee[] employeeArray)
        {
            for (int i = 0; i < employeeArray.Length; i++)
            {
                bool positionDone = false;

                Position position = ((UniEmployee)employeeArray[i]).GetPosition();

                for (int j = 0; j < i; j++)
                {
                    //Ha ezt a beosztást már számbavettük, akkor átugorjuk
                    if (((UniEmployee)employeeArray[j]).GetPosition() == position)
                    {
                        positionDone = true;
                        break;
                    }
                }

                if (positionDone)
                {
                    continue;
                }

                //Ha ez a beosztás első előfordulása
                Console.WriteLine(((UniEmployee)employeeArray[i]).GetPosition() + ": ");

                int counter = 1;

                for (int j = i + 1; j < employeeArray.Length; j++)
                {
                    if (((UniEmployee)employeeArray[i]).GetPosition() == ((UniEmployee)employeeArray[j]).GetPosition())
                    {
                        counter++;
                    }
                }

                Console.WriteLine(counter);
            }

            Console.WriteLine();
        }
    }
}

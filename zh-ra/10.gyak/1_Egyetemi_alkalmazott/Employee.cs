using System;
using System.Collections.Generic;

namespace _1_Egyetemi_alkalmazott
{
	public class Employee : Person
	{
		private string workplace;
		private int salary;

		public Employee(string name, int age, string workplace, int salary) : base(name, age)
		{
			this.workplace = workplace;
			this.salary = salary;
		}

		public String GetWorkplace()
		{
			return workplace;
		}

		public void SetWorkplace(String workplace)
		{
			this.workplace = workplace;
		}

		public int GetSalary()
		{
			return salary;
		}

		public void SetSalary(int salary)
		{
			this.salary = salary;
		}

		public override string ToString()
		{
			return "Employee [workplace=" + workplace + ", salary=" + salary + ", " + base.ToString() + "]";
		}

		//Nested class
		public class SortAgeHelper : IComparer<Employee>
		{
			public int Compare(Employee e1, Employee e2)
			{
				return e1.GetAge() - e2.GetAge();
			}
		}

		public static IComparer<Employee> SortAge()
		{
			return (IComparer<Employee>)new SortAgeHelper();
		}
	}

}

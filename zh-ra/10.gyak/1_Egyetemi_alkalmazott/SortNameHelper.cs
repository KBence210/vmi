using System.Collections.Generic;

namespace _1_Egyetemi_alkalmazott
{
    public class SortNameHelper : IComparer<Employee>
	{
		public int Compare(Employee e1, Employee e2)
		{
			return e1.GetName().CompareTo(e2.GetName());
		}
	}
}

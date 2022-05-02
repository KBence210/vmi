namespace _1_Egyetemi_alkalmazott
{
	public class Person
	{
		private string name;
		private int age;

		public Person(string name, int age)
		{
			this.name = name;
			this.age = age;
		}

		public string GetName()
		{
			return name;
		}

		public void SetName(string name)
		{
			this.name = name;
		}

		public int GetAge()
		{
			return age;
		}

		public void SetAge(int age)
		{
			this.age = age;
		}

		public override string ToString()
		{
			return "Person [name=" + name + ", age=" + age + "]";
		}
	}

}

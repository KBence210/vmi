namespace _1_Egyetemi_alkalmazott
{
	public enum Position
	{
		PROF, OKTATO, ADMIN
	}

	public class UniEmployee : Employee
	{
		private Position position;
		private static int basesalary = 500000;

		//Példányszintű adattag értéke másik példányszintű adattag értékétől függ
		//Itt: a fizetés a beosztástól függ
		public UniEmployee(string name, int age, string workplace, Position position) : base(name, age, workplace, 0)
		{
			this.position = position;

			switch (position)
			{
				case Position.PROF:
					SetSalary(basesalary);
					break;

				case Position.OKTATO:
					SetSalary(basesalary * 50 / 100);
					break;

				case Position.ADMIN:
					SetSalary(basesalary * 30 / 100);
					break;
			}
		}

		public Position GetPosition()
		{
			return position;
		}

		public void SetPosition(Position position)
		{
			this.position = position;
		}

		public static int GetBasesalary()
		{
			return basesalary;
		}

		public static void SetBasesalary(int basesalary)
		{
			UniEmployee.basesalary = basesalary;
		}

		public override string ToString()
		{
			return "UniEmployee [position=" + position + ", " + base.ToString() + "]";
		}
	}
}

using System.Drawing;

namespace szinezheto
{
	class MagyarSzin
	{
		string szin;

		public MagyarSzin(Color szin)
		{
			this.szin = szin.Name.ToUpper();
		}

		public MagyarSzin(string szin)
		{
			this.szin = szin;
		}

		public override string ToString()
		{
			if (szin.Equals("BLACK"))
				return "fekete";
			else if (szin.Equals("BLUE"))
				return "kék";
			else if (szin.Equals("GREEN"))
				return "zöld";
			else if (szin.Equals("ORANGE"))
				return "narancssarga";
			else if (szin.Equals("PINK"))
				return "rózsaszín";
			else if (szin.Equals("RED"))
				return "piros";
			else if (szin.Equals("WHITE"))
				return "fehér";
			else if (szin.Equals("YELLOW"))
				return "citromsarga";
			else
				return "nem definialt";
		}
	}
}

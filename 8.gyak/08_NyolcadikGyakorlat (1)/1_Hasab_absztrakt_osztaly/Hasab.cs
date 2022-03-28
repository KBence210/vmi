namespace testek
{
	//tartalmaz abstract metódust, ezért az osztály is abstract
	abstract class Hasab
	{
		//- magassag adattag
		private double magassag;

		//- Magassag tulajdonság (csak olvasható) (getter metódus helyett)
		public double Magassag
		{
			get { return magassag; }
		}

		//- konstruktor, amely paraméterben kapott értékkel inicializálja a magasságot!
		public Hasab(double magassag)
		{
			this.magassag = magassag;
		}

		//- abstract metódus az alapterület visszaadására
		abstract public double Alapterulet();

		//- metódus a térfogat visszaadására
		public double Terfogat()
		{
			return Alapterulet() * magassag;
		}

		//- metódus, amely igazat ad ha a hasábom nagyobb térfogatú,
		//mint egy paraméterben kapott másik hasáb!
		public bool NagyobbTerfogatuMint(Hasab masikHasab)
		{
			return Terfogat() > masikHasab.Terfogat();
		}
	}
}

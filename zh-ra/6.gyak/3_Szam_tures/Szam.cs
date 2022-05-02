using System;
using System.Collections.Generic;
using System.Text;

namespace myNamespace.first
{
    class Szam
    {
		//private static readonly double tures = 0.001;
		private const double tures = 0.001;
		private double valosSzam;

		public Szam(double valosSzam)
		{
			this.valosSzam = valosSzam;
		}

		public bool ElteresTuresenBelulVan(double szam)
		{
			if (Math.Abs(valosSzam - szam) < tures)
			{
				return true;
			}
			else
				return false;
		}

		public double GetValosSzam()
		{
			return valosSzam;
		}

		public void SetValosSzam(double valosSzam)
		{
			this.valosSzam = valosSzam;
		}
	}
}

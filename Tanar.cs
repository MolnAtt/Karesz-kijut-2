using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Karesz
{
	public partial class Form1 : Form
	{
		static Random r = new Random();
		string betöltendő_pálya = "palya01.txt";
		void TANÁR_ROBOTJAI()
		{
			Robot karesz = new Robot("Karesz", 1000, 1000, 1000, 1000, 0, r.Next(1,39), r.Next(1,29), r.Next(4), false, false);
			Betölt(betöltendő_pálya);
			Vektor[] kijáratok = new Vektor[]
			{
				new Vektor(0, 1),
				new Vektor(1, 0),
				new Vektor(39, 0),
				new Vektor(40, 1),
				new Vektor(1, 30),
				new Vektor(0, 29),
				new Vektor(39, 30),
				new Vektor(40, 29),
			};
			Vektor kijárat = kijáratok[r.Next(8)];
			pálya[kijárat] = 0;
			Frissít();

		}
	}
}
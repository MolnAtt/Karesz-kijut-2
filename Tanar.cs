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

			Vektor kijárat;
			switch (r.Next(4))
			{
				case 0:
					kijárat = new Vektor(r.Next(1, 39), 0);
					break;
				case 1:
					kijárat = new Vektor(r.Next(1, 39), 30);
					break;
				case 3:
					kijárat = new Vektor(0, r.Next(1, 29));
					break;
				default:
					kijárat = new Vektor(40, r.Next(1, 29));
					break;
			}
			pálya[kijárat] = 0;
			Frissít();
		}
	}
}
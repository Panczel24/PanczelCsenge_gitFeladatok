using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai
{
	internal class Program
	{
		static Random r = new Random();
		static void Main(string[] args)
		{


			f01();


            int[] szamok = {10,15,24,22,21,32,61,87 }; // lesz egy referenciacime a memóriában: hol van a tömböm
			Console.WriteLine();
			Console.WriteLine("MÁSODIK FELADAT");
			Console.WriteLine("ennyi páros szám volt:"+ f02(szamok)); //csak a cimet adom át

		}

		static void f01()
		{
			int[] szamok = new int[15];
			Console.WriteLine("eredeti szám:");
			for (int i = 0; i < szamok.Length; i++)
			{
				szamok[i] = r.Next(1, 50); ;
				Console.Write(szamok[i] + " , ");
			}
            Console.WriteLine();
            Console.WriteLine("Módosított szám");
            for (int i = 0; i < szamok.Length; i++)
			{
				int random = r.Next(1, 50);
				szamok[i] += random;
				Console.Write(szamok[i] +" , ");
			}
            Console.WriteLine();
        }

		static int f02(int[] tomb)
		{
			int szam = 0;
			for (int i = 0; i < tomb.Length; i++)
			{
				if (tomb[i] %2 == 0)
				{
					szam++;
				}
			}
			return szam;

		}










	}
}

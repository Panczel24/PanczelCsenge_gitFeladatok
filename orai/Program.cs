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
			int[] szamokk = new int[10];
			f01(szamokk);
			f05(szamokk);

			//Console.WriteLine();
			//Console.WriteLine("MÁSODIK FELADAT");
			//int[] szamok = {10,15,24,22,21,32,61,87 }; // lesz egy referenciacime a memóriában: hol van a tömböm
			//Console.WriteLine("ennyi páros szám volt:"+ f02(szamok)); //csak a cimet adom át


			//Console.WriteLine();
			//Console.WriteLine("harmadik FELADAT");
			//double[] szam1 = { 10.5, 15.6, 24.6, 22.1, 33.3, 55.6 };
			//Console.WriteLine("az átlag:" + f03(szam1));


			//Console.WriteLine();
			//Console.WriteLine("negyedik FELADAT");
			//int[] szam2 = { 10, 15, 24, 22, 33, 55 };
			//Console.WriteLine("" + f04(szam2));

		}

		static void f01(int[] tomb)
		{
            Console.WriteLine("első feladat");
            //int[] szamok = new int[15];
            //Console.WriteLine("eredeti szám:");
            //for (int i = 0; i < szamok.Length; i++)
            //{
            //	szamok[i] = r.Next(1, 50); ;
            //	Console.Write(szamok[i] + " , ");
            //}
            //         Console.WriteLine();
            //         Console.WriteLine("Módosított szám");
            //         for (int i = 0; i < szamok.Length; i++)
            //{
            //	int random = r.Next(1, 50);
            //	szamok[i] += random;
            //	Console.Write(szamok[i] +" , ");
            //}
            //         Console.WriteLine();

            for (int i = 0; i < tomb.Length; i++)
			{
				tomb[i] += r.Next(1, 51);
				Console.Write(tomb[i] + " , ");
			}
			
		}

		static int f02(int[] tomb)
		{
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("második feladat");
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

		static double f03(int[] tomb)
		{
			Console.WriteLine();
			Console.WriteLine("harmadik feladat");
			double atlag = 0;
			for (int i = 0; i < tomb.Length; i++)
			{ 			
				atlag+= tomb[i];
		
			}
			atlag /= tomb.Length;
			return atlag;
		}

		static int[] f04(int[] tomb)
		{
            int[] paratlanok =new int [tomb.Length];
			for (int i = 0; i < tomb.Length; i++)
			{
				
					if (tomb[i] % 2 == 0)
					{
						
						paratlanok[i] += tomb[i]+1;
					}
					else
					{
						paratlanok[i] += tomb[i];
					}				
			}
			return paratlanok;
		}

		static void f05(int[] tomb)
		{
			Console.WriteLine($"Ennyi db pozitív szám van a tömbben: {f02(tomb)}");
			Console.WriteLine($"A tömb elemeinek átlaga: {f03(tomb)}");
            Console.WriteLine();
            Console.WriteLine("negyedik feladat, a tömbből alkotott páratlan számok:");
			int[] paratlanok = f04(tomb);
            foreach (int szam in paratlanok)
            {
                Console.Write(szam + " , ");
            }
            Console.WriteLine();
            Console.WriteLine();


        }



	}
}





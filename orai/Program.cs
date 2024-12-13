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
            Console.WriteLine("módosított szám:");
			for (int i = 0; i < szamok.Length; i++)
			{
				int random = r.Next(1, 50);
				szamok[i] += random;
				Console.Write(szamok[i] +" , ");
			}
        }












	}
}

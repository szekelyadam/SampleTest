using System;

namespace SampleTest
{
	class MainClass
	{
		public static int[,] TombVeletlenGeneral(int hetekSzama)
		{
			int[,] array = new int[hetekSzama, 7];
			Random rnd = new Random();

			for (int i = 0; i < hetekSzama; i++)
			{
				for (int j = 0; j < 7; j++)
				{
					if (j <= 4)
						array[i, j] = rnd.Next(3, 11);
					else
						array[i, j] = rnd.Next(8, 31);
				}

				int deleted = 0;

				do
				{
					int deletableIndex = rnd.Next(0, 7);
					if (array[i, deletableIndex] != 0)
					{
						array[i, deletableIndex] = 0;
						deleted++;	
					}
					
				}
				while (deleted < 2);
			}

			return array;
		}

		public static string TombKiir(int[,] lefutottTavok)
		{
			string result = "";

			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 7; j++)
				{
					result += lefutottTavok[i, j] + "km, ";
				}
				result += "\n";
			}

			return result;
		}

		public static void TombModosit(int hetIndex, int napIndex, int ujErtek, int[,] lefutottTavok)
		{
			lefutottTavok[hetIndex, napIndex] = ujErtek;
		}

		public static int OsszesKilometer(int[,] lefutottTavok)
		{
			int sum = 0;

			foreach (var item in lefutottTavok)
			{
				sum += item;
			}

			return sum;
		}

		public static int HosszuFutasokSzama(int[,] lefutottTavok)
		{
			int longRuns = 0;

			foreach (var item in lefutottTavok)
			{
				if (item > 15)
					longRuns++;
			}

			return longRuns;
		}

		public static int[] HetiOsszesites(int[,] lefutottTavok)
		{
			int[] weeklySummaries = new int[lefutottTavok.GetLength(0)];

			for (int i = 0; i < lefutottTavok.GetLength(0); i++)
			{
				int sum = 0;

				for (int j = 0; j < lefutottTavok.GetLength(1); j++)
				{
					sum += lefutottTavok[i, j];
				}

				weeklySummaries[i] = sum;
			}

			return weeklySummaries;
		}

		public static bool NovekszikE(int[] hetiTavok)
		{
			bool ascending = true;
			int i = 1;

			do
			{
				if (hetiTavok[i] <= hetiTavok[i - 1])
					ascending = false;
				i++;
			} while (ascending == true || i == hetiTavok.Length);

			return ascending;
		}

		public static int[] CsokkenobeRendezes(int[] hetiTavok)
		{
			int[] ordered = new int[hetiTavok.Length];

			for (int i = 0; i < ordered.Length; i++)
			{
				ordered[i] = hetiTavok[i];
			}

			for (int i = (hetiTavok.Length - 1); i >= 1; i--)
			{
				for (int j = 0; j < i - 1; j++)
				{
					if (ordered[j] < ordered[j+1])
					{
						int tmp = ordered[j];
						ordered[j] = ordered[j + 1];
						ordered[j + 1] = tmp;
					}
				}
			}

			return ordered;
		}

		public static void Main(string[] args)
		{
			int[,] excercises = TombVeletlenGeneral(5);

			Console.WriteLine(TombKiir(excercises));

			TombModosit(0, 0, 10, excercises);
			Console.WriteLine(TombKiir(excercises));

			Console.WriteLine("Weekly excersised: " + OsszesKilometer(excercises) + "kms");

			Console.WriteLine("Long runs: " + HosszuFutasokSzama(excercises));

			int[] weeklySummary = HetiOsszesites(excercises);

			foreach (var item in weeklySummary)
			{
				Console.Write(item + "km, ");
			}

			Console.WriteLine("Is ascending? " + NovekszikE(weeklySummary));

			foreach (var item in CsokkenobeRendezes(weeklySummary))
			{
				Console.Write(item + "km, ");
			}


			Console.ReadLine();
		}
	}
}

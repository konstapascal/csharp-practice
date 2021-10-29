using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace cs_practice
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//List<string> list = new() { "apple", "banana" };
			//Dictionary<char, short> map = new() { { 'A', 3 }, { 'B', 3 }, { 'C', 3 } };
			//string[] strArr = { "Tim", "John", "Kevin" };

			//foreach (var el in list)
			//{
			//	Console.WriteLine(el);
			//}

			//foreach ((var key, var val) in map)
			//{
			//	Console.WriteLine($"{key}: {val}");
			//}

			//Array.ForEach(strArr, (el) => Console.WriteLine(el));

			StringManipulation();
		}

		private static void StringManipulation()
		{
			Stopwatch stopwatch = new();
			Stopwatch sb_stopwatch = new();

			StringBuilder sb = new();

			sb_stopwatch.Start();
			for (int i = 0; i < 100_000; i++)
			{
				sb.Append(i);
			}
			sb_stopwatch.Stop();

			Console.WriteLine($"StringBuilder concatination method took {sb_stopwatch.ElapsedMilliseconds} ms");

			string str = "";

			stopwatch.Start();
			for (int i = 0; i < 100_000; i++)
			{
				str += i;
			}
			stopwatch.Stop();

			Console.WriteLine($"Classic string concatination method took {stopwatch.ElapsedMilliseconds} ms");
		}
	}
}
using System;
using System.Collections.Generic;

namespace cs_practice
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			List<string> list = new List<string> { "apple", "banana" };
			Dictionary<char, short> map = new() { { 'A', 3 }, { 'B', 3 }, { 'C', 3 } };

			foreach (var el in list)
			{
				Console.WriteLine(el);
			}

			foreach (KeyValuePair<char, short> entry in map)
			{
				Console.WriteLine($"{entry.Key}: {entry.Value}");
			}
		}
	}
}
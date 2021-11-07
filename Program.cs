using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace csharp_practice
{
	internal class Program : StringPractice
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

			StringConcatination();

			Console.ReadLine();
		}
	}
}
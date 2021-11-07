using System;
using System.Diagnostics;
using System.Text;

namespace csharp_practice
{
	internal class StringPractice
	{
		public static void StringConcatination()
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
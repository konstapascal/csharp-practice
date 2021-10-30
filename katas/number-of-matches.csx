// We provide you with a List of strings and a searchPhrase. We want you to figure out how many entries contain the searchPhrase somewhere in the list
// if the searchPhrase is empty return 0.
// The searchPhrease can be anywhere inside the entry.
// Your searches should ignore casing.

public static int FindMatchCount(List<string> data, string searchPhrase)
{
	if (searchPhrase == "") return 0;

	int count = 0;

	data.ForEach((el) =>
	{
		if (el.ToLower().Contains(searchPhrase.ToLower())) count++;
	});

	return count;
}

List<string> data = new();

data.Add("abc");
data.Add("abcd");
data.Add("bcd");
data.Add("cde");

System.Console.WriteLine(FindMatchCount(data, "ab"));
System.Console.WriteLine(FindMatchCount(data, "abc"));
System.Console.WriteLine(FindMatchCount(data, ""));
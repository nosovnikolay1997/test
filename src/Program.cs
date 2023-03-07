string[] CreateArray()
{
	return new string[]{ "hello", "2", "world", ":-)" };
}

void PrintArray(string[] inp)
{
	Console.WriteLine(String.Join("\n", inp));
}

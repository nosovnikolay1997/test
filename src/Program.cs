string[] CreateArray()
{
	return new string[]{ "hello", "2", "world", ":-)" };
}

void PrintArray(string[] inp)
{
	Console.WriteLine(String.Join("\n", inp));
}

string[] FilterArray(string[] inp)
{
	string[] output = new string[inp.Length];
	int count = 0;
	for (int i = 0; i < inp.Length; i++)
		if (inp[i].Length <= 3)
			output[count++] = inp[i];
	Array.Resize(ref output, count);
	return output;
}

Console.WriteLine("Input array:");
string [] source = CreateArray();
PrintArray(source);
Console.WriteLine("\nOutput array:");
PrintArray(FilterArray(source));

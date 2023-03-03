
string[] words = Console.ReadLine().ToLower().Split().ToArray();

Dictionary<string, int> wordsCount = new Dictionary<string, int>();

foreach (var word in words)
{
	if (!wordsCount.ContainsKey(word))
	{
		wordsCount.Add(word, 0);
	}
	wordsCount[word]++;
}

wordsCount = wordsCount.Where(x => x.Value % 2 != 0).ToDictionary(x => x.Key,x => x.Value);

foreach (var word in wordsCount)
{
	Console.Write("{0} ", word.Key);
}

//List<string> result = wordsCount.Where(x => x.Value % 2 != 0).Select(x => x.Key).ToList();
//Console.WriteLine(string.Join(" ", result));

//foreach (var word in wordsCount.Where(x => x.Value % 2 != 0))
//{
//	Console.Write("{0} ", word.Key);
//}
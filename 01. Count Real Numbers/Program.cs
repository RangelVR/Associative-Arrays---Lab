List<int> numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

foreach (var number in numbers)
{
	if (!keyValuePairs.ContainsKey(number))
	{
		keyValuePairs.Add(number, 0);
	}

	keyValuePairs[number]++;
}

foreach (var item in keyValuePairs.OrderBy(x => x.Key))
{
	Console.WriteLine($"{item.Key} -> {item.Value}");
}
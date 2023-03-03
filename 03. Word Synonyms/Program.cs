int n = int.Parse(Console.ReadLine());

Dictionary<string, List<string>> dictionatyOfSynonyms = new Dictionary<string, List<string>>();

for (int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (!dictionatyOfSynonyms.ContainsKey(word))
    {
        dictionatyOfSynonyms.Add(word, new List<string>());
    }

    dictionatyOfSynonyms[word].Add(synonym);
}

foreach (var word in dictionatyOfSynonyms)
{
    Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
}

string[] words = Console.ReadLine()
    .Split()
    .Where(word => word.Length % 2 == 0)
    .ToArray();

Console.WriteLine(string.Join(Environment.NewLine, words));


//Console.ReadLine()
//   .Split()
//   .Where(word => word.Length % 2 == 0)
//   .ToList()
//   .ForEach(Console.WriteLine);


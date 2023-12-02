namespace Day01
{
    public class Part2
    {
        private readonly static string[] NumsNames = ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];

        public Part2() { }

        public static void Main()
        {
            Console.WriteLine("\nPart 2: \n");

            Console.WriteLine("Reading Input.txt");
            string[] Lines = File.ReadAllLines("..\\..\\..\\Part-2\\Input.txt");
            Console.WriteLine($"Readed {Lines.Length} lines");


            int sum = 0;
            Dictionary<int, int> unsortedLineNums = new Dictionary<int, int>();
            List<KeyValuePair<int, int>> sortedLineNums = new List<KeyValuePair<int, int>>();
            foreach (var (line, i) in Lines.Select((value, i) => (value, i)))
            {
                unsortedLineNums.Clear();
                sortedLineNums.Clear();
                Console.WriteLine($"{i}: {line}");

                for (int n=1; n<10; n++)
                {
                    var x = line.IndexOf(n.ToString());
                    while (x > -1)
                    {
                        unsortedLineNums.Add(x, n);
                        x = line.IndexOf(n.ToString(), x+1);
                    }
                    x = line.IndexOf(NumsNames[n-1]);
                    while (x > -1)
                    {
                        unsortedLineNums.Add(x, n);
                        x = line.IndexOf(NumsNames[n-1], x + NumsNames[n-1].Length);
                    }
                }
                sortedLineNums = unsortedLineNums.OrderBy(x => x.Key).ToList();
                var lineNum = sortedLineNums.First().Value.ToString() + sortedLineNums.Last().Value.ToString();
                Console.WriteLine(lineNum);
                sum += int.Parse(lineNum);
            }
            Console.WriteLine(sum.ToString());
        }
    }
}

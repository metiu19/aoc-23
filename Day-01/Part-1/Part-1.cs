using System.Text;

namespace Day01
{
    public class Part1
    {
        public Part1() { }

        public static void Main()
        {
            Console.WriteLine("Part 1\n");

            Console.WriteLine("Reading input.txt");
            string[] Lines = File.ReadAllLines($"..\\..\\..\\Part-1\\Input.txt");
            Console.WriteLine($"Readed {Lines.Length} lines");

            int Sum = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var (line, i) in Lines.Select((value, i) => (value, i)))
            {
                sb.Clear();
                Console.WriteLine($"{i}: {line}");

                sb.Append(line.First(char.IsNumber));
                sb.Append(line.Last(char.IsNumber));
                Sum += int.Parse(sb.ToString());
                Console.WriteLine($"Number: {sb}");
            }

            Console.WriteLine($"Sum: {Sum}");
        }
    }
}
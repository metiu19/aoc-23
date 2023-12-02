using System.Text;

namespace Day02
{
    public class Part1
    {
        private static readonly int MaxRed = 12;
        private static readonly int MaxGreen = 13;
        private static readonly int MaxBlue = 14;

        public Part1() { }

        public static void Main()
        {
            Console.WriteLine("Part 1\n");

            Console.WriteLine("Reading input.txt");
            string[] lines = File.ReadAllLines($"..\\..\\..\\Part-1\\Input.txt");
            Console.WriteLine($"Readed {lines.Length} lines");

            int idsSum = 0;
            foreach (var line in lines)
            {
                int id = int.Parse(line[line.IndexOf(' ')..line.IndexOf(':')]);
                Console.WriteLine($"{id}: {line}");
                string[] sets = line[(line.IndexOf(':') + 1)..].Split(';');
                bool allSetsValid = true;
                foreach (var set in sets)
                {
                    Console.WriteLine(set);
                    string[] colors = set.Trim().Split(",");
                    int red = 0, green = 0, blue = 0;
                    foreach (var color in colors)
                    {
                        var fixedColor = color.Trim();
                        int wsIndex = fixedColor.IndexOf(' ');
                        Console.WriteLine(fixedColor);
                        switch (fixedColor[(wsIndex + 1)..])
                        {
                            case "red":
                                red += int.Parse(fixedColor[..wsIndex]);
                                break;
                            case "green":
                                green += int.Parse(fixedColor[..wsIndex]);
                                break;
                            case "blue":
                                blue += int.Parse(fixedColor[..wsIndex]);
                                break;
                            default:
                                Console.WriteLine($"Something Went Wrong! '{fixedColor[wsIndex..]}'");
                                break;
                        }
                    }
                    Console.WriteLine($"R: {red} | G: {green} | B: {blue}");
                    allSetsValid &= (red <= MaxRed) & (green <= MaxGreen) & (blue <= MaxBlue);
                    Console.WriteLine($"{allSetsValid}");
                }
                if (allSetsValid)
                {
                    idsSum += id;
                }
            }
            Console.WriteLine($"{idsSum}");
        }
    }
}
namespace Day02
{
    public class Part2
    {
        public Part2() { }

        public static void Main()
        {
            Console.WriteLine("\nPart 2: \n");

            Console.WriteLine("Reading Input.txt");
            string[] lines = File.ReadAllLines("..\\..\\..\\Part-2\\Input.txt");
            Console.WriteLine($"Readed {lines.Length} lines");

            int powersSum = 0;
            foreach (var line in lines)
            {
                int id = int.Parse(line[line.IndexOf(' ')..line.IndexOf(':')]);
                Console.WriteLine($"{id}: {line}");

                string[] sets = line[(line.IndexOf(':') + 1)..].Split(';');
                int red = 0, green = 0, blue = 0;
                foreach (var set in sets)
                {
                    Console.WriteLine(set);
                    string[] colors = set.Trim().Split(",");
                    foreach (var color in colors)
                    {
                        var fixedColor = color.Trim();
                        int wsIndex = fixedColor.IndexOf(' ');
                        Console.WriteLine(fixedColor);
                        int num = 0;
                        switch (fixedColor[(wsIndex + 1)..])
                        {
                            case "red":
                                num = int.Parse(fixedColor[..wsIndex]);
                                if (num > red)
                                    red = num;
                                break;
                            case "green":
                                num = int.Parse(fixedColor[..wsIndex]);
                                if (num > green)
                                    green = num;
                                break;
                            case "blue":
                                num = int.Parse(fixedColor[..wsIndex]);
                                if (num > blue)
                                    blue = num;
                                break;
                            default:
                                Console.WriteLine($"Something Went Wrong! '{fixedColor[wsIndex..]}'");
                                break;
                        }
                    }
                }
                int power = red * green * blue;
                powersSum += power;
            }
            Console.WriteLine($"{powersSum}");
        }
    }
}
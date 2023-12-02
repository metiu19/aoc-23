using Day01;

Console.WriteLine("Advent of Code 2023 | Day 01\n");

Console.WriteLine("Choose witch part to solve: ");
string? input = Console.ReadLine();

if (input == null)
{
    Console.WriteLine("ERROR: Input not valid!");
    return 1;
}

switch (input)
{
    case "1":
        Part1.Main();
        break;
    case "2":
        Part2.Main();
        break;
    default:
        return 2;
}

return 0;
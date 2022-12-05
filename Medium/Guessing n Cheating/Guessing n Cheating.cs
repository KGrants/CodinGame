using System;

class Solution
{
    static void Main(string[] args)
    {
        int R = int.Parse(Console.ReadLine());
        int toohigh = 100;
        int toolow = 1;
        for (int i = 1; i <= R; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            int number = int.Parse(line[0]);
            string call = string.Join(' ', line[1], line[2]);

            switch (call)
            {
                case "too high":
                toohigh = Math.Min(number-1,toohigh);
                break;
                case "too low":
                toolow = Math.Max(number+1,toolow);
                break;
                default:
                break;
            }

            if (toohigh < toolow || call == "right on" && !(toolow <= number && number <= toohigh))
            {
                Console.WriteLine($"Alice cheated in round {i}");
                Environment.Exit(0);
            }
        }
        Console.WriteLine("No evidence of cheating");
    }
}
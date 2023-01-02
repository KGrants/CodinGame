using System;

class Solution
{
    static void Main(string[] args)
    {
        double level = 0;
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
            level += 0.0075 * int.Parse(Console.ReadLine());

        Console.WriteLine(Math.Round(level,2,MidpointRounding.ToZero).ToString("0.00"));
    }
}
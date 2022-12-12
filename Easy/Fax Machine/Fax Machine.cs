using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int W = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        var T = Console.ReadLine().Split(' ').Select(n => int.Parse(n));
        char[] symbols = new char[] {' ', '*'};
        var answer = String.Empty;

        for (int i = 1; i <= T.Count(); i++)
        {
            for (int mult = 0; mult < T.ElementAt(i-1); mult++)
                answer += symbols[i%2];
        }

        for (int i = 0; i < H; i++)
        {
            Console.WriteLine($"|{answer.Substring(0,W)}|");
            answer = answer.Remove(0,W);
        }
    }
}
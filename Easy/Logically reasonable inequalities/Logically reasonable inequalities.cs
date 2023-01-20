using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        List<char> a = new List<char>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var r = Console.ReadLine().Split(" > ").Select(x => Convert.ToChar(x));

            if(!a.Contains(r.ElementAt(0)))
                a.Add(r.ElementAt(0));
            if(!a.Contains(r.ElementAt(1)))
                a.Add(r.ElementAt(1));

            if (a.IndexOf(r.ElementAt(0))>a.IndexOf(r.ElementAt(1)))
            {
                Console.WriteLine("contradiction");
                Environment.Exit(0);
            }
        }
        Console.WriteLine("consistent");
    }
}
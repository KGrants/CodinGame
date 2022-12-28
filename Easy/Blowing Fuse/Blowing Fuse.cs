using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int n = int.Parse(inputs[0]);
        int m = int.Parse(inputs[1]);
        int c = int.Parse(inputs[2]);
        int result = 0;

        Dictionary<int, int> power = new Dictionary<int, int>();
        inputs = Console.ReadLine().Split(' ');
        for (int i = 1; i <= n; i++)
            power.Add(i,int.Parse(inputs[i-1]));

        List<int> maxpower = new List<int>();
        inputs = Console.ReadLine().Split(' ');
        for (int i = 0; i < m; i++)
        {
            result += power[int.Parse(inputs[i])];
            maxpower.Add(result);
            power[int.Parse(inputs[i])] *= -1;
        }

        if(maxpower.Max()>c)
            Console.WriteLine("Fuse was blown.");
        else
        {
            Console.WriteLine($"Fuse was not blown.");
            Console.WriteLine($"Maximal consumed current was {maxpower.Max()} A.");
        }
    }
}
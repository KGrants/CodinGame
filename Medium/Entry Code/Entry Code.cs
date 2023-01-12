using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    private static int x;
    private static int n;
    private static int maxNumber;
    private static int maxPower;
    private static readonly HashSet<int> Visited = new HashSet<int>() {0};

    static void Main()
    {
        x = int.Parse(Console.ReadLine()!);
        n = int.Parse(Console.ReadLine()!);
        maxNumber = x - 1;
        maxPower = 1;
        for (var i = 0; i < n - 1; i++)
        {
            maxNumber *= x;
            maxPower *= x;
            maxNumber += x - 1;
        }

        int len = n + maxNumber;
        int[] array = new int[len];
        Dfs(n, 0, array);

        Console.WriteLine(string.Join("", array));
    }

    private static bool Dfs(int pos, int previous, int[] array)
    {
        if (pos == n + maxNumber)
            return true;

        int nextBase = (previous - array[pos - n] * maxPower) * x;

        for (var i = 0; i < x; i++)
        {
            var current = nextBase + i;

            if (!Visited.Add(current)) 
                continue;

            array[pos] = i;
            
            if (Dfs(pos + 1, current, array))
                return true;

            Visited.Remove(current);
        }
        return false;
    }
}
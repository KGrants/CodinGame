using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int next_num = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        var a = new Dictionary<int,int>();

        for (int i = 0; i<N-1; i++)
        {
            int distance = 0;
            if (a.ContainsKey(next_num))
                distance = i- a[next_num];
            else 
                distance = 0;

            a[next_num] = i;
            next_num = distance;
        }
        Console.WriteLine(next_num);
    }
}
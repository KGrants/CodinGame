using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int X = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split(' ');
        List<int> weights = new List<int>(N);
        double answer = 0;

        for (int i = 0; i < N; i++)  
        weights.Add(int.Parse(inputs[i]));
        
        weights.Sort((a, b) => b.CompareTo(a));

        for (int i = 0; i < weights.Count; i++) 
        answer += ((((i/X)+1)-1) * 6.5 / 100) * 10 * weights[i];

        Console.WriteLine(answer.ToString("0.000"));
    }
}
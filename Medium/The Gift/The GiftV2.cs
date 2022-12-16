using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int[] budget = new int[N];

        for (int i = 0; i < N; i++)
            budget[i] = int.Parse(Console.ReadLine());

        Array.Sort(budget);

        if (budget.Sum()<C)
            Console.WriteLine("IMPOSSIBLE");
        else
        {              
            for (int i = 0; i < budget.Length; i++)
            {
                var split = C/(N-i);

                if (split>=budget[i])
                {
                    C -= budget[i];
                    Console.WriteLine(budget[i]);
                }
                else
                {
                    C -= split;
                    Console.WriteLine(split);
                }
            }   
        }
    }
}
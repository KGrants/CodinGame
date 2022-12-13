using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var N = Math.Pow(n,2);

        for (int i = 1; i < N/2+1 ; i++)
        {
            double x = n+N/i, y = n+i;
            if (x < y) 
                break;
            if (N % i == 0)
                Console.WriteLine($"1/{n} = 1/{x} + 1/{y}");   
        }
    }
}
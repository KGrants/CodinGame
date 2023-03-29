using System;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        int product = 1;
        
        for (int i = 1; i <= N; i++)
        {
            sum += i;
            product *= i;

        }
        Console.WriteLine(product);
        Console.WriteLine(sum);
    }
}
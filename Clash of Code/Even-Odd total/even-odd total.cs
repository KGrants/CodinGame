using System;

class Solution
{
    static void Main(string[] args)
    {
        int total = 0;

        for (int i = 0; i < 3; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x%2 ==0)
                total += x;
            else 
                total -= x;
        }
        Console.WriteLine(total);
    }
}
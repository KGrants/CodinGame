using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int res = 0;
        int cpy = n;
        int p = 2;

        while (p <= cpy)
        {
            while (cpy % p == 0)
            {
                cpy = cpy/p;
                res += n/p;
            }
            p += 1;
        }
        Console.WriteLine(res);
    }
}
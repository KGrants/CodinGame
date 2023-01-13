using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        double min = double.MaxValue;
        for (int i = 0; i < N; i++)
        {
            double nums = int.Parse(Console.ReadLine());
            double sqrt = Math.Sqrt(nums);
            if (sqrt % 1 == 0 && sqrt < min)
                min = sqrt;
        }

        if (min % 1 == 0 && min != double.MaxValue)
            Console.WriteLine(min);
        else 
            Console.WriteLine(0);
    }
}
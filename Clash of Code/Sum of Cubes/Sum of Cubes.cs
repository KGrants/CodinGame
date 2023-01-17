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
        int n = int.Parse(Console.ReadLine());
        double answer = 0;
        for (double i = 1; i <= n; i++ )
        {
            answer += Math.Pow(i,3);
            Console.WriteLine(answer);
        }
    }
}
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
        string[] inputs = Console.ReadLine().Split(' ');
        int Result = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(inputs[i]);
            if (Math.Abs(t)<Math.Abs(Result)) Result = t;
            if (t == Math.Abs(Result)) Result = t;
        }

        if (n==0) Result = 0;
        
        Console.WriteLine(Result);
    }
}
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
        char[] e = "9876543210".ToCharArray();
        for (int i = 0; i < N; i++)
            Console.WriteLine(e[int.Parse(Console.ReadLine())]);
    }
}
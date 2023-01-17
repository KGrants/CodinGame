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
        string TEXT = Console.ReadLine();
        for (int i = 0; i <= TEXT.Length-N; i++)
        {
            Console.WriteLine(TEXT.Substring(i,N));
        }
    }
}
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
        string w = Console.ReadLine();

        for (int i = 1; i < w.Length; i++)
        {
            if (w[i]<=w[i-1]) Console.WriteLine(w[i]);
        }
    }
}
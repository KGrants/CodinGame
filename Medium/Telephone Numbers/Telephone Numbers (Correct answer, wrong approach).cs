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
        HashSet<string> result = new HashSet<string>(); //unordered collection of unique elements
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string number = Console.ReadLine();
            for (int u = 1; u <= number.Length; u++)
            {
                result.Add(number.Substring(0,u));
            }
        }
        Console.WriteLine(result.Count);
    }
}
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
        int[] arr = Console.ReadLine().Split(" ").Select(x => int.Parse(x.ToString())).ToArray();
        Array.Sort(arr);

        
        int minsum = arr.Take(arr.Length - 1).Sum();
        int maxsum = arr.Skip(1).Sum();

        Console.WriteLine($"{minsum} {maxsum}");
    }
}
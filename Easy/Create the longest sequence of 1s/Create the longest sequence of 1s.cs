using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        string[] b = Console.ReadLine().Split('0');
        int maxseq = int.MinValue;

        for (int i = 0; i < b.Count()-1; i++)
        {
            if (b[i].Length+b[i+1].Length>maxseq)
            maxseq = b[i].Length+b[i+1].Length;
        }
        Console.WriteLine(maxseq+1);
    }
}
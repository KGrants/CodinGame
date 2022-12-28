using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        var T = Console.ReadLine().Split(' ');
        string answer = "";
        string draw = "";

        for (int i = 0; i < T.Length; i++)
        {
            if (T[i].EndsWith("sp"))
                draw = String.Concat(Enumerable.Repeat(" ", int.Parse(T[i].Remove(T[i].Length-2))));
            else if (T[i].EndsWith("bS"))
                draw = String.Concat(Enumerable.Repeat("\\", int.Parse(T[i].Remove(T[i].Length-2))));
            else if (T[i].EndsWith("sQ"))
                draw = String.Concat(Enumerable.Repeat("'", int.Parse(T[i].Remove(T[i].Length-2))));
            else if (T[i] == "nl")
                draw = "\n";
            else
                draw = String.Concat(Enumerable.Repeat(T[i].Last(), int.Parse(T[i].Remove(T[i].Length-1))));
            
            Console.Write(draw);
        }
    }
}
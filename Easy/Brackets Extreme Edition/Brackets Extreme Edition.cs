using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        string e = string.Join("",Console.ReadLine().Where("{([])}".Contains));
        while (e.Contains("[]") || e.Contains("{}") || e.Contains("()"))
            e = e.Replace("{}", String.Empty).Replace("()", String.Empty).Replace("[]", String.Empty);
        
        if (e.Length == 0)
            Console.WriteLine("true");
        else
            Console.WriteLine("false");
    }
}
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
        string S = Console.ReadLine();
        int i = S.Length%2!=0?0:1;
        foreach(var c in S)
        {
            i++;
            Console.Write(i%2!=0?c.ToString().ToLower(): c.ToString().ToUpper());
        }
    }
}
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

        S = S.ToLower();
        string S2 = S.ToUpper();

        for (int i = 0; i < S.Length; i++)
        {
            if (i == 0)
            {
                S = S.Remove(i, 1).Insert(i, S2[i].ToString());
            }

            else if (S[i - 1] == ' ')
            {
                S = S.Remove(i, 1).Insert(i, S2[i].ToString());
            }
        }
        Console.WriteLine(S);
    }
}
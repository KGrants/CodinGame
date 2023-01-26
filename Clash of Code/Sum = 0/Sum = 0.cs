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
        var numb = new int[5];
        for (int i = 0; i < 5; i++)
        {
            numb[i] = int.Parse(Console.ReadLine());            
        }
        
        for (int t = 0; t < 5; t++)
        {
            for (int u = (t+1)>4?t:t+1; u < 5; u++)
            {
                for (int y = (u+1)>4?u:u+1; y < 5; y++)
                {
                    if (numb[t]+numb[u]+numb[y]  == 0)
                    {
                        Console.WriteLine(numb[t]);
                        Console.WriteLine(numb[u]);
                        Console.WriteLine(numb[y]);
                        System.Environment.Exit(0);
                    }
                }
            }
        }
    }
}
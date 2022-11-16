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
        char[] sqr = (Console.ReadLine() + Console.ReadLine() + Console.ReadLine()).Replace(" ", "").ToCharArray();
        char[] press = Console.ReadLine().ToCharArray();
        char[] result = new char[] {'*','*','*','*','~','*','*','*','*'};
        string[] indexes = new string[] {"0134", "012", "1245", "036", "13457", "258", "3467", "678", "4578"};
        string diff = "";

        for (int i = 0; i<press.Length; i++)
        {   
            foreach(char index in indexes[Convert.ToInt32(char.GetNumericValue(press[i])-1)])
            sqr[Convert.ToInt32(char.GetNumericValue(index))] = switchchar(sqr[Convert.ToInt32(char.GetNumericValue(index))]);
        }

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i]!=sqr[i])
            diff += i;
        }

        Console.WriteLine(Array.IndexOf(indexes, diff)+1);        
    }

    static char switchchar(char input)
    {
        char x = input;
        if (x=='*')
        x = '~';
        else
        x = '*';
        return x;
    }
}
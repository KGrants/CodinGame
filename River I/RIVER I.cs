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
        int r1value = int.Parse(Console.ReadLine());
        int r2value = int.Parse(Console.ReadLine());


        while (r1value != r2value)
        {
            if (r1value > r2value)
                r2value = r2value + getnextnumber(r2value);
            else if (r2value > r1value)
                r1value = r1value + getnextnumber(r1value);
        }
        Console.WriteLine(r1value);
    }

    static int getnextnumber(int input)
    {
        int result = 0;
        for ( int i = 0; i < Convert.ToString(input).Length; i++)
        {
            result += int.Parse(Convert.ToString(input).Substring(i,1));
        }
        return result;
    }
}
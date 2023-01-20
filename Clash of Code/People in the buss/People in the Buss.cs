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
        int n = int.Parse(Console.ReadLine());
        int result = 1;
        for (int i = 0; i < n; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            result += int.Parse(inputs[0]);
            result -= int.Parse(inputs[1]);
        }
        Console.WriteLine(result);
    }
}
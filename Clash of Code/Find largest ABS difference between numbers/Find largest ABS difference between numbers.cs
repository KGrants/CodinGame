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
        string[] inputs = Console.ReadLine().Split(' ');
        int answer = 0;
        for (int i = 0; i < n-1; i++)
        {
            if (Math.Abs(int.Parse(inputs[i])-int.Parse(inputs[i+1]))>answer)
                answer = Math.Abs(int.Parse(inputs[i])-int.Parse(inputs[i+1]));

        }
        Console.WriteLine(answer);
    }
}
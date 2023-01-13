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
        int A = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split(' ');
        int[] answer = new int[A];
        for (int i = 0; i < A; i++)
            answer[i] = int.Parse(inputs[int.Parse(inputs[i])]);

        Console.WriteLine(string.Join(" ", answer));
    }
}
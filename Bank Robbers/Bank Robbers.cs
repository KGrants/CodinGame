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
        int R = int.Parse(Console.ReadLine());
        int V = int.Parse(Console.ReadLine());
        int[] MaxSec = new int[R]; 
        //The number of k-element variations of n-elements with repetition allowed, is Vn,k = n^k


        for (int i = 0; i < V; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int C = int.Parse(inputs[0]);
            int N = int.Parse(inputs[1]);

            MaxSec[0] += Convert.ToInt32((Math.Pow(10, N) * Math.Pow(5, C - N))); 
            Array.Sort(MaxSec);
        }
        Console.WriteLine(MaxSec[R-1]);
    }
}
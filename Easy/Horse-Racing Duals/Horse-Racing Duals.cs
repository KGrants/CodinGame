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
        int result = int.MaxValue;
        List<int> lst=new List<int>(); 

        for (int i = 0; i < n; i++)
        lst.Add(int.Parse(Console.ReadLine()));
        
        lst.Sort();
        
        for (int i = 1; i < n; i++)
        if (Math.Abs(lst[i]-lst[i-1])<result) result = Math.Abs(lst[i]-lst[i-1]);

        Console.WriteLine(result);
    }
}
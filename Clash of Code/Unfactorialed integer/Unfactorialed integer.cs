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
        long n = long.Parse(Console.ReadLine());
        int number = FindNumberByFactorial(n);
        if(number!=-1){
            Console.WriteLine(number);
        }
    }

    static int FindNumberByFactorial(long factorial)
    {
        if(factorial <= 0)
            return -1;
        int i = 1;
        while (true)
        {
            long temp = factorial;
            for (int j = i; j > 1; j--)
                temp /= j;
            if (temp == 1)
                return i;
            i++;
        }
    }
}
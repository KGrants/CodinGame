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
        int r1 = int.Parse(Console.ReadLine());

        for (int i = r1 - 1; i > 0; i--)
        {
            int check = getnextnumber(i);
            if (check == r1)
            {
                Console.WriteLine("YES");
                break;
            }
            else if (i == 1)
            Console.WriteLine("NO");
        };

    }

static int getnextnumber(int input)
    {
        int result = input;

        while (input > 0)
        {
            result += input % 10;
            input -= input % 10;
            input /= 10;
        }
        return result;
    }
}
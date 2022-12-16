using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        List<int> R = new List<int> {int.Parse(Console.ReadLine())};
        int L = int.Parse(Console.ReadLine());

        for (int i = 1; i<L; i++)
            R = generatenumbers(R);

        Console.WriteLine(String.Join(" ",R));
    }

    public static List<int> generatenumbers(List<int> R)
    {
        int count = 0;
        int number = R[0];
        List<int> ret = new List<int>();

        for (int i = 0; i<R.Count(); i++)
        {
            if (number == R[i])
                count += 1;

            else
            {
                ret.Add(count);
                ret.Add(number);
                number = R[i];
                count = 1;
            }
        }
        ret.Add(count);
        ret.Add(number);

        return ret;
    }
}
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
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int orbSizeMin = int.Parse(inputs[0]);
        int orbSizeMax = int.Parse(inputs[1]);
        inputs = Console.ReadLine().Split(' ');
        int g1 = int.Parse(inputs[0]);
        int g2 = int.Parse(inputs[1]);
        double gsum = calc(g1) + calc(g2);

        int p1 = g1;
        int p2 = g2;
        double pdiff = calc(g1) - calc(g2);

        for (int i = orbSizeMin; i <= orbSizeMax; i++)
        {
            double v1 = calc(i);
            for (int u = i; u <= orbSizeMax; u++)
            {
                double v2 = calc(u);
                if (compare(v1 + v2, gsum))
                {
                    if (p1 == g1 || calc(u) - calc(i) > pdiff)
                    {
                        p1 = i;
                        p2 = u;
                        pdiff = calc(u) - calc(i);
                    }
                    break;
                }
                if (v1 + v2 > gsum)
                    break;
            }
        }

        if (p1 == g1)
            Console.WriteLine("VALID");
        else
            Console.WriteLine($"{p1} {p2}");
        
    }

    public static double calc(int a)
    {
        return 4*(Math.PI*(Math.Pow(((double)a/2),3)))/3;
    }

    public static bool compare(double v1, double v2)
    {
        if (v1 - 0.001 <= v2 && v2 <= v1 + 0.001)
            return true;
        else
            return false;       
    }
}
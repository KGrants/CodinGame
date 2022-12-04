using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<int> pointvalue = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
        
        int totalcost = 0;
        
        while (pointvalue.Count() > 1)
        {
            pointvalue.Sort();
            int minSum = pointvalue.ElementAt(0) + pointvalue.ElementAt(1);
            
            totalcost += minSum;

            pointvalue.RemoveAt(0);
            pointvalue.RemoveAt(0);
            pointvalue.Add(minSum);
        }
    Console.WriteLine(totalcost);
    }
}
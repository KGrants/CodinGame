using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        Dictionary<string,long> start = new Dictionary<string, long>();
        Dictionary<string,long> end = new Dictionary<string, long>();
        SortedDictionary<string,int> answer = new SortedDictionary<string,int>();

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string plate = inputs[0];
            string radarname = inputs[1];
            long timestamp = long.Parse(inputs[2]);

            if (radarname == "A21-42")
            start.Add(plate,timestamp);
            else
            end.Add(plate,timestamp);
        }

        for (int i = 0; i < start.Count; i++)
        {
            long timediff = end[start.ElementAt(i).Key]-start[start.ElementAt(i).Key];
            if (timediff/(3.6e+6)<0.099236641)                                            //////t=d/s --> t=13/131
            answer.Add(start.ElementAt(i).Key, Convert.ToInt32(13/(timediff/(3.6e+6))));  //////s=d/t --> 13/timediff
        }
        for (int i = 0; i < answer.Count; i++)
        Console.WriteLine($"{answer.ElementAt(i).Key} {answer.ElementAt(i).Value}");
    }
}
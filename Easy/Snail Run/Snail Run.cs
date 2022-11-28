using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int numberSnails = int.Parse(Console.ReadLine());
        int[] SnailSpeeds = new int[numberSnails];

        for (int i = 0; i < numberSnails; i++)
        SnailSpeeds[i] = int.Parse(Console.ReadLine());

        int mapHeight = int.Parse(Console.ReadLine());
        int mapWidth = int.Parse(Console.ReadLine());
        
        Dictionary<int, int[]> finloc = new Dictionary<int, int[]>();
        Dictionary<int, int[]> snailloc = new Dictionary<int, int[]>();
        int fincount = 1;

        for (int i = 0; i < mapHeight; i++)
        {
            string input = Console.ReadLine();
            foreach (char u in input)
            {
                if (!u.Equals('*') && u.Equals('#'))
                {
                    finloc.Add(fincount, new int[] {input.IndexOf(u),i});
                    fincount++;
                }
                else if (!u.Equals('*') && !u.Equals('#'))
                {
                    snailloc.Add(int.Parse(u.ToString()), new int[] {input.IndexOf(u),i});
                }
            }
        }

        int answer = 0;
        int finturns = int.MaxValue;

        for (int i = 1; i <= numberSnails; i++)
        {
            for (int f = 1; f <= finloc.Count; f++)
            {
                if (Math.Abs(Math.Ceiling((decimal)(finloc[f][0]-snailloc[i][0])/SnailSpeeds[i-1]))
                    +Math.Abs(Math.Ceiling((decimal)((finloc[f][1]-snailloc[i][1])/SnailSpeeds[i-1])))<finturns)
                    {  
                        finturns = Convert.ToInt32(Math.Abs(Math.Ceiling((decimal)(finloc[f][0]-snailloc[i][0])/SnailSpeeds[i-1]))
                                    +Math.Abs(Math.Ceiling((decimal)((finloc[f][1]-snailloc[i][1])/SnailSpeeds[i-1]))));
                        answer = i;
                    }
            }
        }
        Console.WriteLine(answer);
    }
}
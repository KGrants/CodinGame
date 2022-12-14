using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        Dictionary<int, char> signs = new Dictionary<int, char>();
        Dictionary<int, string> won = new Dictionary<int, string> ();

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            signs.Add(int.Parse(inputs[0]),Convert.ToChar(inputs[1]));
        }
        
        while (signs.Count()>1)
        {
            for (int i = 0; i < N/2; i++)
            {   
                int[] result = battleresult(signs.ElementAt(i).Key,
                                        signs.ElementAt(i).Value,
                                        signs.ElementAt(i+1).Key,
                                        signs.ElementAt(i+1).Value);
                
                if (won.ContainsKey(result[1]))
                    won[result[1]] += " " + Convert.ToString(result[0]);
                else
                    won.Add(result[1], Convert.ToString(result[0]));

                signs.Remove(result[0]);
            }
        N/=2;
        }
 
        Console.WriteLine(signs.ElementAt(0).Key);
        Console.WriteLine(won[signs.ElementAt(0).Key]);
    }

static int[] battleresult(int p1, char p1m, int p2, char p2m)
{
    if (p2m ==p1m)
    {
        if (p1<p2)
            return new int[] {p2,p1};
        else
            return new int[] {p1,p2};
    }

    if ((p1m == 'R' && (p2m == 'L' || p2m == 'C')) ||
        (p1m == 'P' && (p2m == 'R' || p2m == 'S')) ||
        (p1m == 'C' && (p2m == 'L' || p2m == 'P')) ||
        (p1m == 'L' && (p2m == 'S' || p2m == 'P')) ||
        (p1m == 'S' && (p2m == 'C' || p2m == 'R')))
        return new int[] {p2,p1};
    else 
        return new int[] {p1,p2};
}                
}
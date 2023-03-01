using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int h = int.Parse(Console.ReadLine());
        string[] ret = new String[h];
        
        for (int i = 0; i < h; i++)
        {
            string answer = "";
            int[] row = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            for (int u = 0; u<row.Length; u++)
            {
                if (u%2==0)
                    answer += new String('.', row[u]);
                else
                    answer += new String('O', row[u]);;
            }
            ret[i] = answer;
        }
        int check = ret[0].Length;
                for (int i = 0; i < h; i++)
        {
            if (ret[i].Length!=check)
            {
                Console.WriteLine("INVALID");
                System.Environment.Exit(0);
            }
        }
        for (int i = 0; i < h; i++)
            Console.WriteLine(ret[i]);
    }
}
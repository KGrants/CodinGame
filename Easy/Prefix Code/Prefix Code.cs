using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {   
        Dictionary<int,string> decode = new Dictionary<int, string>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            decode.Add(int.Parse(inputs[1]),inputs[0]);
        }
        string s = Console.ReadLine();
        string answer = "";
        int indexcount = 0;
        int check = 0;

        while(s.Length>0)
        {
            check = s.Length;

            foreach(KeyValuePair<int, string> entry in decode)
            {
                if (s.StartsWith(entry.Value))
                {
                    answer += (char)entry.Key;
                    s = s.Substring(entry.Value.Length);
                    indexcount+=entry.Value.Length;
                }
            }

            if (check == s.Length)
            {
            answer = "DECODE FAIL AT INDEX " + Convert.ToString(indexcount);
            break;
            }
        }
        Console.WriteLine(answer);
    }
}
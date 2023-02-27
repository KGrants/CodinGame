using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(string[] args)
    {
        char point = '.';
        int lengthofline = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int subcheck = 0;
        int aa = 0;
        Dictionary<int,int> ch = new Dictionary<int, int>();

        for (int i = 0; i < N; i++)
        {
            string[] entry = Console.ReadLine().Split();
            StringBuilder answer = new StringBuilder();
            ch[subcheck]=aa;

            if(Regex.Matches(entry[0], '>'.ToString()).Count > subcheck)
            {
                subcheck = Regex.Matches(entry[0], '>'.ToString()).Count;
                ch[subcheck]=1;
                aa = 1;
            }
            else if (Regex.Matches(entry[0], '>'.ToString()).Count == subcheck)
            {
                ch[Regex.Matches(entry[0], '>'.ToString()).Count] += 1;
                aa = ch[Regex.Matches(entry[0], '>'.ToString()).Count];
            }
            else
            {
                ch[Regex.Matches(entry[0], '>'.ToString()).Count] += 1;  
                foreach(KeyValuePair<int, int> u in ch)
                {
                    if (u.Key > Regex.Matches(entry[0], '>'.ToString()).Count)
                    {
                        ch[u.Key] = 0;
                    }
                }
                subcheck = Regex.Matches(entry[0], '>'.ToString()).Count;
                aa = ch[Regex.Matches(entry[0], '>'.ToString()).Count];
            }

            while(entry[0][0]=='>')
            {
                answer.Append("    ");
                entry[0] = entry[0].Substring(1);
            }

            answer.Append(aa + " ");
            answer.Append(entry[0]);
            int count = lengthofline - entry[1].Length - answer.Length;
            answer.Append(string.Concat(Enumerable.Repeat(point, count)));
            answer.Append(int.Parse(entry[1]));
            Console.WriteLine(answer);
        }
    }
}
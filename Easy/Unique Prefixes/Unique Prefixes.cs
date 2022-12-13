using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] words = new string[N];
        for (int i = 0; i < N; i++)
        {
            string word = Console.ReadLine();
            words[i] = word;
        }

        for (int i = 0; i < N; i++)
        {
            int n = 1;
            string answer = Convert.ToString(words[i][0]);
            while (words.Where(w => w.StartsWith(answer)).Count()>1 && words[i].Length > n)
            {
                answer += words[i][n];
                n += 1;
            }
            Console.WriteLine(answer);
        }
    }
}
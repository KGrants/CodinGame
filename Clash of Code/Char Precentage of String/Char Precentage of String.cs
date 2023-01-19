using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        double answer = 0;
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            if (s.Length > 0)
            {
                char c = Convert.ToChar(Console.ReadLine());
                int freq = s.ToLower().Count(x => (x == c));
                answer = (Math.Ceiling((double)freq*100/s.Length));
                Console.WriteLine($"{answer}%");
            }
            else
            Console.WriteLine("0%");
        }
    }
}
using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        string confusingWord = Console.ReadLine();
        string answer = "";

        for (int i = 0; i < confusingWord.Length; i++)
        {
            char ch = confusingWord[i];
            int freq = confusingWord.Count(f => (f == ch));
            if (freq==1)
                answer+=ch;
        }
        Console.WriteLine(answer);
    }
}
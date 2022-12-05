using System;
using System.Text.RegularExpressions;

public class Solution
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] input = new string[N];

        for (int i = 0; i < N; i++)
            input[i] = Console.ReadLine();

        string fulllines = string.Join("\n", input); 

        int a = 0;
        string answer = Regex.Replace(fulllines, @"\([^\)]*\)", (choices) => 
                                                      
        {
            string[] answer = choices.Value.Substring(1, choices.Value.Length - 2).Split('|');
            a+=1;
            return answer[(a -1) % answer.Length];
            
        });

        Console.WriteLine(answer);
    }
}
using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        string answer = "";
        var N = Console.ReadLine()
                          .Replace("[", "")
                          .Replace("]","")        
                          .Split(',')
                          .Select(c => int.Parse(c))
                          .Distinct()
                          .OrderBy(c => c)
                          .ToArray();

        for (int i=1, j=0; i <= N.Length; i++)
		{
			if (i == N.Length || N[i]-N[i-1] != 1)
			{
				if (i - j >= 3)
                {
					answer += string.Format($",{N[j]}-{N[i-1]}");
                    j = i;
                }
				else
					for(; j < i; j++)
                        answer += string.Format($",{N[j]}");
			}
		}
        Console.WriteLine(answer.Substring(1));
    }
}
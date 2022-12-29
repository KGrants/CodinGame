using System;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < N; i++)
        {
            int answer = 0;
            char[] line = Console.ReadLine().ToCharArray();
            for (int j = 0; j < line.Length; j++)
            {
                if (line[j] == 'f')
                {
                    answer+=1;
                    j+=2;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
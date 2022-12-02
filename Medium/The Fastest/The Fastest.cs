using System;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] inputs = new string[N];
        DateTime compare = DateTime.MaxValue;
        int answer = 0;

        for (int i = 0; i < N; i++)
        {
            inputs[i] = Console.ReadLine();
            DateTime check = DateTime.Parse(inputs[i]);
            if (DateTime.Compare(check, compare)==-1)
            {
                compare = check;
                answer = i;
            }
        }
    Console.WriteLine(inputs[answer]);    
    }
}
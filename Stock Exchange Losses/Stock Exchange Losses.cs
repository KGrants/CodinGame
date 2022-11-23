using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split(' ');
        int answer = 0;
        int buyprice = int.Parse(inputs[0]);

        for (int i = 0; i < n; i++)
        {   
            if (int.Parse(inputs[i])>buyprice)
            buyprice = int.Parse(inputs[i]);

            if (int.Parse(inputs[i])<buyprice && answer>(0 - (buyprice - int.Parse(inputs[i]))))
            answer = 0 - (buyprice - int.Parse(inputs[i]));
        }
        Console.WriteLine(answer);
    }
}
using System;

class Solution
{
    static void Main(string[] args)
    {
        string[] keywords = new string[] {"FATAL","ERROR","WARNING","INFO","DEBUG"};
        int lvl = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        string [] key_lvl = new string[lvl+1];
        for (int i = 0; i <= lvl; i++)
            key_lvl[i] = keywords[i];

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j <= lvl; j++)
                if (line.Contains("> "+key_lvl[j]))
                    Console.WriteLine(line);
        }
    }
}
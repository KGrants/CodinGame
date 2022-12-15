using System;

class Solution
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int width = int.Parse(inputs[0]);
        int height = int.Parse(inputs[1]);
        int[] stacks = new int[width];
        for (int i = 0; i < height; i++)
        {
            char[] line = Console.ReadLine().ToCharArray();
            for (int a = 0; a < width; a++)
            {
                if (line[a] == '#')
                    stacks[a] += 1;
            }
        }

        for (int i = 0; i < height; i++)
        {
            for (int a = 0; a < width; a++)
            {
                if (stacks[a] >= height - i)
                    Console.Write("#");
                else
                    Console.Write(".");
            }
        Console.WriteLine("");
        }
    }
}
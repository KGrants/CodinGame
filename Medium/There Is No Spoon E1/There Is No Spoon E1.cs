using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


class Player
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine()); 
        int height = int.Parse(Console.ReadLine()); 
        char[,] grid = new char[width, height];

        for (int i = 0; i < height; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < width; j++)
                grid[j, i] = line[j];
        }

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                string RN = "";
                string DN = "";
                int temp = 0;

                if (grid[j, i] == '.') 
                    continue;

                temp = j;
                while (++temp < width && grid[temp, i] == '.');
                if (temp < width && (grid[temp, i] != '.'))
                    RN = $"{temp} {i}";
                else
                    RN = "-1 -1";

                temp = i;
                while (++temp < height && grid[j, temp] == '.');
                if (temp < height && (grid[j, temp] != '.'))
                    DN = $"{j} {temp}";
                else
                    DN = "-1 -1";

                Console.WriteLine($"{j} {i} {RN} {DN}");
            }
        }
    }
}
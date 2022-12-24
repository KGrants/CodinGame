using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int [,] grid = new int[9,9];
        string answer = "true";
        for (int i = 0; i < 9; i++)
        {
            int[] line = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            for (int j = 0; j < 9; j++)
            {
                grid[i,j] = line[j];
            }
        }
        for (int i = 0; i < 9; i++)
        {
        ///If any row contains any number twice, return false
            if (Enumerable.Range(0, grid.GetLength(0))
                .Select(x => grid[i, x])
                .GroupBy(x => x)
                .Select(x => x.Count())
                .Any(x => x>1))
            answer = "false";

        ///If any column contains any number twice, return false
            if (Enumerable.Range(0, grid.GetLength(0))
                .Select(x => grid[x, i])
                .GroupBy(x => x)
                .Select(x => x.Count())
                .Any(x => x>1))
            answer = "false";
        }

        ///If any subgrid contains any number twice, return false
        for (int j = 0; j<3; j++)
        {   
            for (int i = 0; i<3; i++)
            {
                if (Enumerable.Range(j*3, 3).Select(x => grid[(i*3), x])
                .Concat(Enumerable.Range(j*3, 3).Select(x => grid[(i*3)+1, x]))
                .Concat(Enumerable.Range(j*3, 3).Select(x => grid[(i*3)+2, x]))
                .GroupBy(x => x)
                .Select(x => x.Count())
                .Any(x => x>1))
                answer = "false";
            }
        }
        Console.WriteLine(answer);
    }
}
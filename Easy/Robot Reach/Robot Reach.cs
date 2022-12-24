using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int R = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int T = int.Parse(Console.ReadLine());
        int counter = 0;
        int[,] grid = new int[R,C];

        ///This creates and fills 2D array. After each cell is filled it is checked with markway procedure
        ///and marked as 0 if it is a valid position and -1 if it is not.
        for (int i = 0; i < R; i++)
        {
            for (int j = 0; j < C; j++)
            {
                grid[i,j] = i.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray().Sum() 
                          + j.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray().Sum();
                grid[i,j] = markway(grid,i,j,T);
            }
        }

        ///Counts zeros and returns count as answer
        foreach (int i in grid)
            if (i == 0)
                counter++;

        Console.WriteLine(counter);
    }

    public static int markway(int[,] grid, int i, int j, int T)
    {
        ///Starting point to be returned as 0
        if (grid[i,j] == 0)                                                 return 0;

        ///This is added to handle first row and first column
        if (i == 0 || j == 0)
        {
            /// if cell value is <=T and it has 0 to left or on top, mark with 0
            if (i == 0 && grid[i,j]<=T && grid[i,j-1] == 0)                 return 0;
            else if (j == 0 && grid[i,j]<=T && grid[i-1,j] == 0)            return 0;
        }
        ///if current cell value is <=T and it has 0 to left or on top, mark with 0
        else if (grid[i,j]<=T && (grid[i-1,j] == 0 || grid[i,j-1] == 0))    return 0;

        return -1;
    }
}
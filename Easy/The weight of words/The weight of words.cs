using System;
using System.Linq;
using System.Text;

class Solution
{
    static void Main(string[] args)
    {
        int steps = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int w = int.Parse(Console.ReadLine());

        char[,] grid = new char[h,w];
        for (int i = 0; i < h; i++)
        {
            string row = Console.ReadLine();
            for (int j = 0; j < w; j++)
            {
                grid[i,j] = row[j];
            }
        }

        while (steps>0)
        {
            for (int i = 0; i < w; i++)
            {
                var check = Enumerable.Range(0, grid.GetLength(0)).Select(x => grid[x, i]);
                int rotate = calculateweight(String.Join("", check))%h;
                grid = rotatecolumn(grid, rotate, i, h);
            }

            for (int i = 0; i < h; i++)
            {
                var check = Enumerable.Range(0, grid.GetLength(1)).Select(x => grid[i, x]);
                int rotate = calculateweight(String.Join("", check))%w;
                grid = rotaterow(grid, rotate, i, w);     
            }
            steps--;
        }
        showgrid(grid);
    }

    public static int calculateweight(string a)
    {
        int result = 0;
        byte[] bytes = Encoding.ASCII.GetBytes(a);
        foreach(byte b in bytes)
            result += b;
        
        return result;
    }

    public static char[,] rotatecolumn(char[,] grid, int rotate, int column, int h)
    {
        char[,] result = grid.Clone() as char[,];

        for (int i = 0; i < h; i++)
            result[(i + rotate)%h,column] = grid[i,column];

        return result;
    }

    public static char[,] rotaterow(char[,] grid, int rotate, int row, int w)
    {
        char[,] result = grid.Clone() as char[,];

        for (int i = 0; i < w; i++)
            result[row,(i + rotate)%w] = grid[row,i];

        return result;
    }

    public static void showgrid(char[,] grid)
    {
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                Console.Write(grid[i,j]);
            }
            Console.WriteLine();
        }
    }
}
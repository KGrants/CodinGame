using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        ///Create two arrays and a list or arrays to store all input data
        int[] inp = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        int[] pos = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        char[][] grid = new char[inp[1]][];

        /// Fill 2D array with input lines
        for (int i = 0; i < inp[1]; i++)
            grid[i] = Console.ReadLine().ToCharArray(); 

        ///Note down starting position to be able to jump out of loop and create counter to return result
        (int, int) start = (pos[0], pos[1]);
        int counter = 0;

        ///Loop through till position is out of bounds of 2D array or we are back at starting point
        while (pos[0] >= 0 && pos[0] < inp[0] && pos[1] >= 0 && pos[1] < inp[1])
        {
            ++counter;
            grid[pos[1]][pos[0]] = roratechar(grid[pos[1]][pos[0]]);
            int x = getnextpos(pos[0], pos[1], grid[pos[1]][pos[0]]).Item1;
            int y = getnextpos(pos[0], pos[1], grid[pos[1]][pos[0]]).Item2;

            pos[0] = x;
            pos[1] = y;

            if (start == (x, y))
                break;
        }
        Console.WriteLine(counter);
    }

    ///Return new position based on input position and direction
    public static (int, int) getnextpos(int x, int y, char c)
    {
        if (c == '>')       return (x+1,y);
        else if (c == '<')  return (x-1,y);
        else if (c == '^')  return (x, y-1);
        else                return (x,y+1);
    }

    ///Return new character that is rotated clockwise
    public static char roratechar(char a)
    {
        char[] direction = new char[] {'>','v','<','^'};

        if (Array.IndexOf(direction,a)==3)  return direction[0];
        else                                return direction[Array.IndexOf(direction,a)+1];
    }
}
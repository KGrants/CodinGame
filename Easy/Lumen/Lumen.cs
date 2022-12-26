using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int L = int.Parse(Console.ReadLine());
        int[,] grid = new int[N,N];
        int answer = 0;
        

        for (int i = 0; i < N; i++)
        {
            char[] line = Console.ReadLine().Replace(" ", "").ToCharArray();
            for (int j = 0; j < N; j++)
                grid[i, j] = line[j] == 'C' ? L : 0;
        }

        while (L>0)
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (grid[i,j] == L)
                        for (int x = Math.Max(0,i-1); x <= Math.Min(i+1,N-1); x++)
                            for (int y = Math.Max(0,j-1); y <= Math.Min(j+1,N-1); y++)
                                if (grid[x,y] < L)
                                    grid[x,y] = L-1;
            L--;
        }
            
        for (int i = 0; i < N; i++)
            answer += Enumerable.Range(0, grid.GetLength(0))
                                .Select(x => grid[i, x])
                                .Count(x => x == 0);
        Console.WriteLine(answer);
    }     
}
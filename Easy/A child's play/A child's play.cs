using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int w = int.Parse(inputs[0]);
        int h = int.Parse(inputs[1]);
        long n = long.Parse(Console.ReadLine());
        int posx = 0, posy = 0, counter = 0, obst = 0;
        List<char[]> rows = new List<char[]>();
        char[] direct = new char[] {'U','R','D','L'};
        Dictionary<string, int> circle = new Dictionary<string, int>();

        for (int i = 0; i < h; i++)
        {
            char[] line = Console.ReadLine().ToCharArray();
            rows.Add(line);
            if (Array.IndexOf(line, 'O') != -1)
                {
                    posy = i;
                    posx = Array.IndexOf(line, 'O');
                }
            obst += line.Count(x=> x == '#');
        }

        int catchloop = w*h - obst;
        string startstring = String.Join(" ",posx,posy);

        ////First I loop through till the point when I know that robot is in the loop
        while (counter<catchloop && catchloop < n) 
        {
            while (rows[getcoord(posx,posy,direct[0]).Item2][getcoord(posx,posy,direct[0]).Item1] == '#')
                direct = (String.Join("",direct[1..])+direct[0]).ToCharArray();

            posy = getcoord(posx,posy,direct[0]).Item2;
            posx = getcoord(posx,posy,direct[0]).Item1;
            counter++;
        }

        ////Reset all counters, decrease n and start to iterate again, this time noting down each position
        n -= counter;
        counter = 0;
        startstring = String.Join(" ",posx,posy);
        
        while (counter < n)
        {
            ///This changes directions till valid move
            while (rows[getcoord(posx,posy,direct[0]).Item2][getcoord(posx,posy,direct[0]).Item1] == '#')
                direct = (String.Join("",direct[1..])+direct[0]).ToCharArray();

            posy = getcoord(posx,posy,direct[0]).Item2;
            posx = getcoord(posx,posy,direct[0]).Item1;

            if (!circle.TryGetValue(startstring, out int c) && n > 100)
            {
                if (!circle.TryGetValue(String.Join(" ",posx,posy), out int d))
                    circle.Add(String.Join(" ",posx,posy),counter);
                else if (!circle.TryGetValue(String.Join(" ",posx,posy, string.Empty), out int r))
                    circle.Add(String.Join(" ",posx,posy, string.Empty),counter);
                else if (circle.TryGetValue(String.Join(" ",posx,posy, string.Empty), out int q))
                    {
                        Console.WriteLine(circle.FirstOrDefault(x => x.Value == (n%counter)-1).Key.Trim());
                        Environment.Exit(0);
                    }
            }
            else if (circle.TryGetValue(startstring, out int d) && n > 100)
            {
                Console.WriteLine(circle.FirstOrDefault(x => x.Value == (n%counter)-1).Key);
                Environment.Exit(0);
            }
            counter++;
        }
        Console.WriteLine(String.Join(" ",posx,posy));
    }

public static (int,int) getcoord(int x, int y, char direct)
{
    if (direct == 'U')
        return (x,y-1);
    else if (direct == 'R')
        return (x+1,y);
    else if (direct == 'D')
        return (x,y+1);
    else 
        return (x-1,y);
}
}
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
        char[] direct = new char[] {'U','R','D','L'};
        List<char[]> rows = new List<char[]>();

        for (int i = 0; i < h; i++)
        {
            char[] line = Console.ReadLine().ToCharArray();
            rows.Add(line);
            obst += line.Count(x=> x == '#');

            if (Array.IndexOf(line, 'O') != -1)
            {
                posy = i;
                posx = Array.IndexOf(line, 'O');
            }
        }

        int catchloop = w * h - obst;
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

        ////Reset all counters, decrease n and start to iterate again till we hit the starting point again
        ////Then decrease n (n%counter), reset counter and finish off the loop
        n -= counter;
        counter = 0;
        startstring = String.Join(" ",posx,posy);
        
        while (counter < n)
        {
            while (rows[getcoord(posx,posy,direct[0]).Item2][getcoord(posx,posy,direct[0]).Item1] == '#')
                direct = (String.Join("",direct[1..])+direct[0]).ToCharArray();

            posy = getcoord(posx,posy,direct[0]).Item2;
            posx = getcoord(posx,posy,direct[0]).Item1;            
            counter++;

            if (startstring.Equals(String.Join(" ",posx,posy)))
            {
                n = n%counter;
                counter = 0;
            }
        }
        Console.WriteLine(String.Join(" ",posx,posy));
    }

    public static (int,int) getcoord(int x, int y, char direct)
    {
        if (direct == 'U')  return (x,y-1);
        else if (direct == 'R') return (x+1,y);
        else if (direct == 'D') return (x,y+1);
        else return (x-1,y);
    }
}
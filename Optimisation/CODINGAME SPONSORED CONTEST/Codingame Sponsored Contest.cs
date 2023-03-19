using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

///Things that can be improved:
/// 1) Finding closest unvisited location and more to that direction (have to take into account walls)
/// 3) There are some random fields that gives you 100 points

class Player
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());      //Grid width
        int height = int.Parse(Console.ReadLine());     //Grid height 
        int players = int.Parse(Console.ReadLine());    //Player count
        char[,] grid = new char[height,width];          //Initialised with  
        var moves = new Dictionary<char, char>();       //To be used to track roads and walls
        Random rnd = new Random();                      //Will be used if we don't know where to go

        while (true)
        {
            //'#' is wall, '_' is a valid road
            moves['C'] = Convert.ToChar(Console.ReadLine());    //LEFT
            moves['A'] = Convert.ToChar(Console.ReadLine());    //DOWN
            moves['D'] = Convert.ToChar(Console.ReadLine());    //RIGHT
            moves['E'] = Convert.ToChar(Console.ReadLine());    //UP

            int x = 0;
            int y = 0;
            
            for (int i = 0; i < players; i++) //Cooridinates for each player 
            {
                string[] inputs = Console.ReadLine().Split(' ');
                x = int.Parse(inputs[0]);
                y = int.Parse(inputs[1]);
                if (grid[x,y] =='X' || grid[x,y] =='0')
                  grid[x,y] = '0';
                else
                grid[x,y] = 'O';
            }
            if (grid[(x+1)>height-1?0:x+1,y]!='X' && grid[(x+1)>height-1?0:x+1,y]!='O')
                grid[(x+1)>height-1?0:x+1,y]=moves['A'];
            if (grid[(x-1)<0?height-1:x-1,y]!='X' && grid[(x-1)<0?height-1:x-1,y]!='O')
                grid[(x-1)<0?height-1:x-1,y]=moves['E'];
            if (grid[x,(y+1)>width-1?0:y+1]!='X' && grid[x,(y+1)>width-1?0:y+1]!='O')
                grid[x,(y+1)>width-1?0:y+1]=moves['D'];
            if (grid[x,(y-1)<0?width-1:y-1]!='X' && grid[x,(y-1)<0?width-1:y-1]!='O')
                grid[x,(y-1)<0?width-1:y-1]=moves['C'];

            //drawing map for debugging
            for (int u = 0; u < height; u++)
            {
                for (int o = 0; o < width; o++)
                {
                    Console.Error.Write(grid[u,o]);
                }
                Console.Error.WriteLine();
            }
            //end of map drawing

            grid[x,y] = 'X';  //Marking player location as visited
            var check = MovesAvailable(moves, grid, x, y, false); // Creating initial available move list
            Console.Error.WriteLine($"First list = {String.Join(" ",check)}");
            
            if(check.Count < 1) //If there are no good moves available, we look also for visited locations
            {
                check = MovesAvailable(moves, grid, x, y, true);
                Console.Error.WriteLine($"Second list = {String.Join(" ",check)}");
            }

            if(check.Count < 1) //If we are here then we are trapped, just make a move and loose
            {
                check = MovesAvailable(moves);
                Console.Error.WriteLine($"Last list = {String.Join(" ",check)}");
            }
            Console.Error.WriteLine(getXcount(grid));
            /////////////Actual Move//////////////

            Console.WriteLine(check[rnd.Next(check.Count)]);
            
            for (int i = 0; i < players; i++)
            {
                if (EnemyLoc(grid).Equals(Tuple.Create(-1, -1)))
                    continue;
                if (grid[EnemyLoc(grid).Item1, EnemyLoc(grid).Item2] == '0')
                    grid[EnemyLoc(grid).Item1, EnemyLoc(grid).Item2] = 'X';
                else
                    grid[EnemyLoc(grid).Item1, EnemyLoc(grid).Item2] = '_';
            }
        }
    }

    //We create a list of directions where we:
    // - don't hit the wall (#) 
    // - are not in the danger zone
    // - go to loaction that we haven't visited
    public static List<char> MovesAvailable(Dictionary<char,char> moves,char[,] grid,int x, int y, bool visited)
    {
        var direct = new List<char>();
        int h = grid.GetLength(0)-1; 
        int w = grid.GetLength(1)-1; 

        for (int i = 0; i<moves.Count; i++)
        {
            (int,int) coord;
            switch (moves.ElementAt(i).Key)
            {
                case 'C': coord = (x,(y-1)<0?w:y-1); break;
                case 'A': coord = ((x+1)>h?0:x+1,y); break;
                case 'D': coord = (x,(y+1)>w?0:y+1); break;
                default:  coord = ((x-1)<0?h:x-1,y); break;
            }
            if (visited)
            {
                if (dangerzone(grid,coord.Item1,coord.Item2))
                    continue;
            }
            else
            {
                if (grid[coord.Item1, coord.Item2] == 'X' || dangerzone(grid,coord.Item1,coord.Item2))
                    continue;
            }

            if (moves.ElementAt(i).Value != '#')
                direct.Add(moves.ElementAt(i).Key);
        }
        return direct;
    }

    public static List<char> MovesAvailable(Dictionary<char,char> moves)
    {
        List<char> direct = new List<char>();
        char[] a = new char[] {'C', 'A', 'D', 'E'};
        foreach (char c in a)
        {
            if (moves[c] != '#')
                direct.Add(c);       
        }
        return direct;
    }

    public static Tuple<int, int> EnemyLoc(char[,] grid)
    {
        int h = grid.GetLength(0); // width
        int w = grid.GetLength(1); // height

        for (int x = 0; x < h; x++)
        {
            for (int y = 0; y < w; y++)
            {
                if(grid[x, y].Equals('O') || grid[x, y].Equals('0'))
                    return Tuple.Create(x, y);
            }
        }
        return Tuple.Create(-1, -1);
    }

    public static bool dangerzone(char[,] grid, int x, int y)
    {
        int h = grid.GetLength(0)-1; 
        int w = grid.GetLength(1)-1; 

        if (grid[(x+1)>=h?x:x+1, y]=='O'||grid[(x-1)<=0?x:x-1, y]=='O'||
            grid[(x+2)>=h?x:x+2, y]=='O'||grid[(x-2)<=0?x:x-2, y]=='O'||
            grid[(x+1)>=h?x:x+1, (y-1)<=0?y:y-1]=='O'||grid[(x+1)>=h?x:x+1, (y+1)>=w?y:y+1]=='O'||
            grid[(x-1)<=0?x:x-1, (y-1)<=0?y:y-1]=='O'||grid[(x-1)<=0?x:x-1, (y+1)>=w?y:y+1]=='O'||
            grid[x, (y+1)>=w?y:y+1]=='O'||grid[x, (y-1)<=0?y:y-1]=='O'||
            grid[x, (y+2)>=w?y:y+2]=='O'||grid[x, (y-2)<=0?y:y-2]=='O'||
            grid[(x+1)>=h?x:x+1, y]=='0'||grid[(x-1)<=0?x:x-1, y]=='0'||
            grid[(x+2)>=h?x:x+2, y]=='0'||grid[(x-2)<=0?x:x-2, y]=='0'||
            grid[(x+1)>=h?x:x+1, (y-1)<=0?y:y-1]=='0'||grid[(x+1)>=h?x:x+1, (y+1)>=w?y:y+1]=='0'||
            grid[(x-1)<=0?x:x-1, (y-1)<=0?y:y-1]=='0'||grid[(x-1)<=0?x:x-1, (y+1)>=w?y:y+1]=='0'||
            grid[x, (y+1)>=w?y:y+1]=='0'||grid[x, (y-1)<=0?y:y-1]=='0'||
            grid[x, (y+2)>=w?y:y+2]=='0'||grid[x, (y-2)<=0?y:y-2]=='0')
            return true;
        
        return false;
    }

    public static int getXcount(char[,] grid)
    {
        int h = grid.GetLength(0); 
        int w = grid.GetLength(1); 
        int sumX = 0;

        for (int u = 0; u < h; u++)
        {
            for (int o = 0; o < w; o++)
            {
                if(grid[u,o]=='X')
                    sumX++;
            }
        }
        return sumX;
    }
}
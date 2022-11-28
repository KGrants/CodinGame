using System;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int Xcor = int.Parse(inputs[0])-int.Parse(inputs[2]);
        int Ycor = int.Parse(inputs[1])-int.Parse(inputs[3]);

        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.
            string move = getdirection(Xcor, Ycor);
            if (move.Contains('W')) Xcor += 1;
            if (move.Contains('E')) Xcor -= 1;
            if (move.Contains('N')) Ycor += 1;
            if (move.Contains('S')) Ycor -= 1;
            Console.WriteLine(move);
        }
    }
    static string getdirection(int x, int y)
    {
        string result = "";
        if (y<0) result += 'N';
        if (y>0) result += 'S';
        if (x<0) result += 'W';
        if (x>0) result += 'E';
        return result;
    }
}
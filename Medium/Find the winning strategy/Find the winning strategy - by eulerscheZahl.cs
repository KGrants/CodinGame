using System;
using System.Linq;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine()); // Number of rows
        int columns = int.Parse(Console.ReadLine()); // Number of columns

        while (true)
        {
            int nimSum = 0;
            List<int> lengths = new List<int>();
            List<int> enemyPos = new List<int>();
            
            for (int i = 0; i < rows; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int xPlayer = int.Parse(inputs[0]); // Position of the first player's token
                int xBoss = int.Parse(inputs[1]); // Position of the second player's token
                enemyPos.Add(xBoss);
                lengths.Add(xBoss - xPlayer - 1);
                nimSum ^= lengths.Last();
            }
            
            for (int i = 0; i < rows; i++) {
                int target = lengths[i] ^ nimSum;
                if (lengths[i] > target) {
                    Console.WriteLine(i + " " + (enemyPos[i] - target - 1));
                    break;
                }
            }
        }
    }
}
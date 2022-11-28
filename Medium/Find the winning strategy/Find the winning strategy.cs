using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

//I have to end my turn with NimSum != 0
class Player
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine()); // Number of rows
        int columns = int.Parse(Console.ReadLine()); // Number of columns
        int NimSum = 0;
        List<int> Pos = new List<int> (rows);
        List<int> NimSum_Pos = new List<int> (rows);

        // game loop
        while (NimSum>-1)
        {
            Pos.Clear();
            NimSum_Pos.Clear();
            NimSum = 0;

            for (int i = 0; i < rows; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int xPlayer = int.Parse(inputs[0]); // Position of the first player's token
                int xBoss = int.Parse(inputs[1]); // Position of the second player's token
                NimSum ^= (xBoss-1-xPlayer);
                Pos.Add(xBoss-1-xPlayer);
                NimSum_Pos.Add(xPlayer);
            }

            if (NimSum !=0)
            {
                for (int i = 0; i < rows; i++)
                {
                    if ((Pos[i]^NimSum)<Pos[i])
                    {
                        int Row = i;
                        int Move = NimSum_Pos[i] + Pos[i]-(Pos[i]^NimSum); 
                        Console.WriteLine($"{Row} {Move}");
                        break;
                    }
                }
            }
        }
    }
}
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int ROUNDS = int.Parse(Console.ReadLine());
        int CASH = int.Parse(Console.ReadLine());
        for (int i = 0; i < ROUNDS; i++)
        {
            string[] play = Console.ReadLine().Split(" ".ToCharArray());
            int ball = int.Parse(play[0]);
            int bet = Convert.ToInt32(Math.Ceiling(CASH * 0.25));
            switch (play[1])
                {
                    case "PLAIN":
                        if (ball == int.Parse(play[2]))
                            CASH += bet *35;
                        else 
                            CASH -= bet;
                        break;
                    case "EVEN":
                        if (ball % 2 == 0 && ball != 0)
                            CASH += bet;
                        else
                            CASH -= bet;
                        break;
                    case "ODD":
                        if (ball % 2 == 1 && ball != 0)
                            CASH += bet;
                        else
                            CASH -= bet;
                        break;
                }    
        }
        Console.WriteLine(CASH);
    }
}
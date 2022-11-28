using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        Dictionary<char,int[]> move = new Dictionary<char, int[]>
        {
            {'R', new int[] {4,0,3,5,1,2}},
            {'L', new int[] {4,5,1,0,3,2}},
            {'U', new int[] {4,1,0,3,5,2}},
            {'D', new int[] {4,3,5,1,0,2}},
        };

        char[] temp = new char[6];
        char[] dice = (Console.ReadLine().Substring(1,1)
                     +Console.ReadLine()
                     +Console.ReadLine().Substring(1,1)).ToCharArray();

        char[] commands = Console.ReadLine().ToCharArray();

        for (int i = 0; i < commands.Length; i++)
        {
            for (int u = 0; u < dice.Length; u++)
            temp[u] = dice[u];

            for (int u = 0; u < dice.Length; u++)
            dice[u] = temp[move[commands[i]][u]];
        }
        Console.WriteLine(dice[2]);
    }
}
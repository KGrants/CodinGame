using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        char[] T = Console.ReadLine().ToCharArray();
        StringBuilder Answer = new StringBuilder();

        for (int i = 0; i < H; i++)
        {
            Answer.Clear();
            string ROW = Console.ReadLine();
            for (int l = 0; l<T.Length; l++)
            {
                if (char.IsLetter(T[l]))
                {
                    int Order = (int)((char.ToUpper(T[l]) - 64)-1);
                    Answer.Append(ROW.Substring(((Order*L)),L));
                }
                else
                {
                    Answer.Append(ROW.Substring(ROW.Length-L));
                }
            }
        Console.WriteLine(Answer);
        }
    }
}
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
        string operation = Console.ReadLine();
        int pseudoRandomNumber = int.Parse(Console.ReadLine());

        char[] Rotor1 = Console.ReadLine().ToCharArray();
        char[] Rotor2 = Console.ReadLine().ToCharArray();
        char[] Rotor3 = Console.ReadLine().ToCharArray();
        char[] Message = Console.ReadLine().ToCharArray();
        char[] Default = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        string Answer = "";

        if (operation.Equals("ENCODE"))
        {
            for (int i = 0; i<Message.Length; i++)
            {
                int Pos = 0;
                if (Array.IndexOf(Default,Message[i])+(i+pseudoRandomNumber)>=(Default.Length*2))
                {
                    Pos = Array.IndexOf(Default,Message[i])+(i+pseudoRandomNumber-(Default.Length*2));
                }
                else if (Array.IndexOf(Default,Message[i])+(i+pseudoRandomNumber)>=Default.Length)
                {
                    Pos = Array.IndexOf(Default,Message[i])+(i+pseudoRandomNumber-Default.Length);
                }
                else
                {
                    Pos = Array.IndexOf(Default,Message[i])+(i+pseudoRandomNumber);
                }
                char letterR1 = Rotor1[Pos];
                char letterR2 = Rotor2[Array.IndexOf(Default,letterR1)];
                char letterR3 = Rotor3[Array.IndexOf(Default,letterR2)];
                Answer += letterR3;
            }
        Console.WriteLine(Answer);
        }
        else
        {
            for (int i = 0; i<Message.Length; i++)
            {
                char letterR1 = Default[Array.IndexOf(Rotor3,Message[i])];
                char letterR2 = Default[Array.IndexOf(Rotor2,letterR1)];
                char letterR3;

                if (Array.IndexOf(Rotor1,letterR2)-(i+pseudoRandomNumber)>=0)
                {
                    letterR3 = Default[Array.IndexOf(Rotor1,letterR2)-(i+pseudoRandomNumber)];
                    Answer += letterR3;
                }

                for (int u = 0; u<=(Message.Length+pseudoRandomNumber)/Default.Length; u++)
                {
                    if (Array.IndexOf(Rotor1,letterR2)-(i+pseudoRandomNumber)<(0-Default.Length*u) && Array.IndexOf(Rotor1,letterR2)-(i+pseudoRandomNumber)>=(0-(Default.Length*(u+1))))
                    {
                        letterR3 = Default[Array.IndexOf(Rotor1,letterR2)-(i+pseudoRandomNumber)+(Default.Length*(u+1))];
                        Answer += letterR3;
                        break;
                    }
                }
            }
        Console.WriteLine(Answer);
        }
    }
}
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
        string[] inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]);
        int H = int.Parse(inputs[1]);
        string[] lines = new string[H-2];
        string[] start = Console.ReadLine().Split(new char[] { ' ', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < H-2; i++) lines[i]= Console.ReadLine();
        string[] finish = Console.ReadLine().Split(new char[] { ' ', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int u = 0; u < start.Length; u++)
        {   
            int answer = u;
            for (int i = 0; i < lines.Length; i++) answer = processline(answer,lines[i]);
            Console.WriteLine(start[u]+finish[answer]);
        }
    }

static int processline(int input, string line)
{
    int endline = input;
    if (input > 0) 
    {
        if (line.Substring(((input*3)-3)).IndexOf('-')>2 && line.Substring(((input*3)-3)).IndexOf('-')<6)
        endline = input+1;
        else if (line.Substring((input*3)-3).IndexOf('-')>=0 && line.Substring((input*3)-3).IndexOf('-')<3)
        endline = input-1;
    }
    else
    {
        if (line.Substring(0,3).IndexOf('-')>=0)
        endline = input+1;
    }
    return endline;
}
}
using System;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        int c(string x) {return int.Parse(x);}

        string[] inputs = Console.ReadLine().Split(' ');
        int exitPos = c(inputs[4]);
        int elCount = c(inputs[7]);
        int exitFloor = c(inputs[3]);

        Dictionary<int,int> elev = new Dictionary<int,int>();
        for (int i = 0; i < elCount; i++){
            inputs = Console.ReadLine().Split(' ');
            elev.Add(c(inputs[0]), c(inputs[1]));
        }

        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int cloneFloor = c(inputs[0]);
            int clonePos = c(inputs[1]);
            string d = inputs[2];
            int currentExitPos = (cloneFloor == exitFloor || cloneFloor == -1) ? exitPos : elev[cloneFloor];
            
            string order = "WAIT";
            if(d == "RIGHT") {
                order = clonePos > currentExitPos ? "BLOCK" : "WAIT";
            } else if(d == "LEFT"){
                order = clonePos < currentExitPos ? "BLOCK" : "WAIT";
            }        
            Console.WriteLine(order);
        }
    }
}
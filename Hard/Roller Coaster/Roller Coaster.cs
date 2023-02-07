using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int Places = int.Parse(inputs[0]);
        int Rides = int.Parse(inputs[1]);
        int Groups = int.Parse(inputs[2]);

        int[] groupsize = new int[Groups]; 
        for (int i = 0; i < Groups; i++)
            groupsize[i] = int.Parse(Console.ReadLine());

        var earnings = new Dictionary<int,int>();
        var group_seq = new Dictionary<int,int>();

        for (int i = 0; i < Groups; i++)
        {
            int next_in_line = i;
            earnings[i] = 0;

            while(true)
            {
                int ready_to_ride = groupsize[next_in_line];

                if (earnings[i]+ready_to_ride>Places)
                    break;
        
                earnings[i] += ready_to_ride;

                next_in_line += 1;
        
                if (next_in_line == Groups)
                    next_in_line = 0;
        
                if (next_in_line == i)
                    break;
            }    
        group_seq[i] = next_in_line;
        }

        Int64 answer = 0;
        int group = 0;

        for (int i = 0; i < Rides; i++)
        {
            answer += earnings[group];
            group = group_seq[group];
        }
        Console.WriteLine(answer);
    }
}
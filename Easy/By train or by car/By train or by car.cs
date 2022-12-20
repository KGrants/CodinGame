using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        string[] T = Console.ReadLine().Split(" ");
        string start = T[0], end = T[1];
        double car = 0, train = 65; // walking from and to train added already, car starts at 0;

        int N = int.Parse(Console.ReadLine());
        Dictionary<string[],double> stops = new Dictionary<string[], double>();

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            stops.Add(new string[] {input[0],input[1]}, double.Parse(input[2]));
        }

        for (int i = 0; i < stops.Count(); i++)
        {
            var distance = stops.FirstOrDefault(x=>x.Key[0].Contains(start)).Value;
            start =  stops.FirstOrDefault(x=>x.Key[0].Contains(start)).Key[1];
            
            if (distance < 14)
                car += distance * 60 / 50;
            else
                car += (distance-14)*60/105 + 16.8;

            if (distance < 6)
                train += distance * 60 / 50;
            else
                train += (distance - 6) * 60 / 284 + 7.2;

            if (start == end)
                break;

            train += 8;
        }

        var timeSpan = TimeSpan.FromMinutes(train).ToString("c");

        if (train<car)
            Console.WriteLine($"TRAIN {TimeSpan.FromMinutes(train).ToString(@"h\:mm")}");
        else 
            Console.WriteLine($"CAR {TimeSpan.FromMinutes(car).ToString(@"h\:mm")}");
    }
}
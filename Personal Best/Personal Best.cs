using System;
using System.Collections.Generic;
using System.Linq;

class Solution
    {
        static void Main(string[] args)
        {
            var catIndex = new Dictionary<string, int> {{"bars", 0}, {"beam", 1}, {"floor", 2}};

            var gymnasts = Console.ReadLine().Split(',').ToDictionary(name => name, name => new double[3]);
            var categories = Console.ReadLine().Split(',').Select(name => catIndex[name]).ToList();

            var N = int.Parse(Console.ReadLine());
            for (var i = 0; i < N; i++)
            {
                var data = Console.ReadLine().Split(',');
                if (gymnasts.ContainsKey(data[0]))
                {
                    for (var j = 0; j < 3; j++)
                        gymnasts[data[0]][j] = Math.Max(gymnasts[data[0]][j], double.Parse(data[j + 1]));
                }
            }

            foreach (var gymnastsValue in gymnasts.Values)
            {
                Console.WriteLine(string.Join(",", categories.Select(category => gymnastsValue[category])));
            }
        }
    }
using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int[] inputs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        int c = (inputs.Sum()/4)-inputs[0]-inputs[9];
        int a = inputs[1]-c;
        int b = inputs[0]-(inputs[1]-c);
        int e = inputs[8]-c;
        int d = inputs[9]-(inputs[8]-c);

        Console.WriteLine($"{a} {b} {c} {d} {e}");
    }
}
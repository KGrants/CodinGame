using System;

class Solution
{
    static void Main(string[] args)
    {
        double LON = double.Parse(Console.ReadLine().Replace(',','.'));
        double LAT = double.Parse(Console.ReadLine().Replace(',','.'));
        int N = int.Parse(Console.ReadLine());
        string answer = String.Empty;
        double closest = double.MaxValue;

        for (int i = 0; i < N; i++)
        {
            string[] DEFIB = Console.ReadLine().Split(';');

            var x = (LON-double.Parse(DEFIB[4].Replace(',', '.'))) 
                    * Math.Cos((LAT+double.Parse(DEFIB[5].Replace(',', '.'))) / 2);
            var y = LAT-double.Parse(DEFIB[5].Replace(',', '.'));
            var dist = Math.Sqrt((x * x) + (y * y)) * 6371;

            if (dist < closest)
            {
                closest = dist;
                answer = DEFIB[1];
            }
        }
        Console.WriteLine(answer);
    }
}
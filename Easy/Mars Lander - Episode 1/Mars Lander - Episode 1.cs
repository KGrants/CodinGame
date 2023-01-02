using System;

public class Solution
{
    public static void Main()
    {
        int surfaceN = int.Parse(Console.ReadLine());

        for (int i = 0; i < surfaceN; i++)
            Console.ReadLine();
        
        while (true)
        {
            int vSpeed = int.Parse(Console.ReadLine().Split(' ')[3]);

            if (vSpeed <= -40)
                Console.WriteLine("0 4");
            else
                Console.WriteLine("0 0");
         }
    }
}

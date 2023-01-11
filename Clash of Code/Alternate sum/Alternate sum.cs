using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] k = new int[n];
        for (int i = 0; i < n; i++)
            k[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < n-1; i++)
        {
            string a = "";
            if ((i+1)%2 != 0)
                a = (k[i]+k[i+1]).ToString();
            else
                a = k[i]+k[i+1].ToString();

            Console.WriteLine(a);
        }
    }
}
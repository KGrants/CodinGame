using System;

class Solution
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int n = int.Parse(inputs[0]);
        int m = int.Parse(inputs[1]);
        int[] a = new int[n];
        inputs = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(inputs[i]);
        }

        Array.Sort(a);
        int answer = int.MaxValue;
        
        for (int i = 0; i<a.Length-(m-1); i++)
        {
            if (Math.Abs(a[i+(m-1)]-a[i])<answer)
            {
                answer = Math.Abs(a[i+(m-1)]-a[i]);
            }
        }
        Console.WriteLine(answer);
    }
}
using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string inputs = Console.ReadLine().Replace(" ", string.Empty);
        int a = 0;

        while (inputs.Contains("01"))
        {
            int index1 = inputs.LastIndexOf('1');
            int index0 = inputs.IndexOf('0');

            inputs = inputs.Remove(index0,1);
            inputs = inputs.Insert(index0, "1");
            inputs = inputs.Remove(index1,1);
            inputs = inputs.Insert(index1, "0");

            a+=1;
        }
        Console.WriteLine(a);
    }
}
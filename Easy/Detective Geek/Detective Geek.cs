using System;

class Solution
{
    static void Main(string[] args)
    {
        var time = Convert.ToString(Convert.ToInt32(Console.ReadLine().Replace('#', '1').Replace('*','0'),2)).PadLeft(4,'0').Insert(2,":");
        var address = Console.ReadLine().Split(' ');
        string[] months = new string[] {"jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec"};

        for (int i = 0; i < address.Length; i++)
            address[i] = Convert.ToString(Convert.ToChar(Array.IndexOf(months, address[i].Substring(0,3))*12
                       +Array.IndexOf(months, address[i].Substring(3))));

        Console.WriteLine($"{time}\n{String.Join(String.Empty,address)}");
    }
}
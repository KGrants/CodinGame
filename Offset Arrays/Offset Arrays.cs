using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string,int[]> arrays = new Dictionary<string, int[]>();
        Dictionary<string,int> offset = new Dictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            arrays.Add(input.Substring(0,input.IndexOf('[')), input.Substring(input.IndexOf('=')+2).Split(' ').Select(n => Convert.ToInt32(n)).ToArray());
            offset.Add(input.Substring(0,input.IndexOf('[')),
                    int.Parse(input.Substring(input.IndexOf('[')+1,input.IndexOf('.')-input.IndexOf('[')-1)));
        }

        string x = Console.ReadLine();
        int counter = 0;

        foreach(char i in x)
        {
        if (i.Equals('[')) 
        counter++;
        }

        for (int i = counter; i > 1; i--)
        {
            string xarray = x.Substring(GetNthIndex(x,'[',i-1)+1,GetNthIndex(x,'[',i)-GetNthIndex(x,'[',i-1)-1);
            int xindex = int.Parse(x.Substring(GetNthIndex(x,'[',i)+1,GetNthIndex(x,']',1)-GetNthIndex(x,'[',i)-1));
            int newindex = arrays[xarray][xindex-offset[xarray]];

            x = x.Substring(0,GetNthIndex(x,'[',i-1)+1)+Convert.ToString(newindex)
                +x.Substring(GetNthIndex(x,']',1)+1);
        }

        int ansindex = int.Parse(x.Substring(x.IndexOf('[')+1,x.IndexOf(']')-x.IndexOf('[')-1));
        string ansarray = x.Substring(0,GetNthIndex(x,'[',1));
        Console.WriteLine(arrays[ansarray][ansindex-offset[ansarray]]);
    }

static int GetNthIndex(string s, char t, int n)
{
    int count = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == t)
        {
            count++;
            if (count == n)
            {
                return i;
            }
        }
    }
    return -1;
}
}
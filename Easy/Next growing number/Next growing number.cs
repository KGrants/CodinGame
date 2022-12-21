using System;

class Solution
{
    static void Main(string[] args)
    {
        char[] n = next(Console.ReadLine().ToCharArray());
        
        for (int i = 0; i < n.Length-1; i++)
        {
            while (n[i] > n[i+1])
            {
                n[i+1] = Convert.ToChar(n[i+1]+1);
                for (int a = i+1+1; a <= n.Length-1; a++)
                    n[a] = '0';
            }
        }
        
        Console.WriteLine(String.Join("",n));
    }

public static char[] next(char[] a)
{
    for (int i = a.Length-1; i >= 0; i--)
    {
        if (a[i]=='9')
        {
            a[i] = '0';
            if (i == 0)
            {
                char[] b = ("1"+string.Join("",a)).ToCharArray();
                return b;
            }
            continue;
        }
        else
        {
            a[i] = Convert.ToChar(a[i]+1);
            break;
        }
    }
    return a;
}
}
using System;

class Solution
{
    static void Main(string[] args)
    {
        string[] x = Console.ReadLine().Split('-');
        int n = int.Parse(Console.ReadLine());

        if (int.Parse(x[1])+n>999)
        {
            for (int i = 0; i < (int.Parse(x[1])+n)/999; i++)
            {
                if (x[2] == "ZZ")
                {
                    x[0] = switchLetter(x[0]);
                }
                x[2] = switchLetter(x[2]);
            }
            x[1] = Convert.ToString((int.Parse(x[1])+n)%999).PadLeft(3,'0');
        }
        else 
        {
            x[1] = Convert.ToString(int.Parse(x[1])+n).PadLeft(3,'0');
        }
        Console.WriteLine(String.Join('-',x));
    }

    static string switchLetter(string a)
    {
        string returnvalue = "";
        char[] alp = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] input = a.ToCharArray();
        if (input[1] == 'Z')
        {
            input[1] = 'A';
                if (input[0] == 'Z')
                    input[0] = 'A';
                else
                    input[0] = alp[Array.IndexOf(alp, input[0])+1];
        }
        else
        {
            input[1] = alp[Array.IndexOf(alp, input[1])+1];
        }
        returnvalue = String.Join(string.Empty, input);

        return returnvalue;  
    }
}
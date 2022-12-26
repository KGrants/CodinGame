using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<string> invalid = new List<string>();

        for (int i = 0; i < N; i++)
        {
            string ISBN = Console.ReadLine();
            if ((ISBN.Length != 10 && ISBN.Length != 13) || !Regex.IsMatch(ISBN, "[0-9]*[0-9,X]$") || !validatenumber(ISBN))
            {
                invalid.Add(ISBN);
                continue;
            }
        }

        Console.WriteLine($"{invalid.Count()} invalid:");
        invalid.ForEach(Console.WriteLine);
    }

    public static bool validatenumber (string input)
    {
        if (input.Length == 10)
        {
           var check = (11 - input.Take(9).Select((c, i) => (10 - i) * (c - '0')).Sum() % 11) % 11;
                return ('0' + check == input.Last() || check == 10 && input.Last() == 'X');
        }
        else if (input.Length == 13)
        {
            var check = (10 - input.Take(12).Select((c, i) => (i % 2 == 0 ? 1 : 3) * (c - '0')).Sum() % 10) % 10;
                return('0' + check == input.Last());
        }
        else
            return false;
    }
}
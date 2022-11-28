using System;
using System.Linq;
using System.Globalization;

class Solution
{
    private static int[] idFactors = { 3, 7, 9 };
    private static int[] dateFactors = { 5, 8, 4, 2, 1, 6 };

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
            Console.WriteLine(Validate(Console.ReadLine()));
    }

    private static string Validate(string input)
    {
        if (input?.Length != 10 || input[0] == '0' || input.Any(d => !char.IsDigit(d)))
            return "INVALID SYNTAX";

        if (!DateTime.TryParseExact(input[4..], "ddMMyy", null, DateTimeStyles.None, out var date))
            return "INVALID DATE";

        (char checkDigit, string id) = GetCheckDigit(int.Parse(input[..3]), input[4..]);

        if (input[3] != checkDigit)
            return $"{id}{checkDigit}{input[4..]}";

        return "OK";
    }

    private static (char, string) GetCheckDigit(int id, string date)
    {
        int Sum(string input, int[] factors) => input.Select((d, i) => (d - '0') * factors[i]).Sum();

        for (var validId = id; ; validId++)
        {
            var result = (Sum($"{validId}", idFactors) + Sum(date, dateFactors)) % 11;

            if (result != 10)
                return ((char)(result + '0'), $"{validId}");
        }
    }
}
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;


class Solution
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            BigInteger x = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(NumberToWords(x).Trim());
        }
    }

public static string NumberToWords(BigInteger number)
{
    if (number == 0)
        return "zero";

    if (number < 0)
        return "negative" + NumberToWords(number*-1);

    string words = "";

    if ((number / 1000000000000000000) > 0)
    {
        words += NumberToWords(number / 1000000000000000000) + " quintillion";
        number %= 1000000000000000000;
    }

    if ((number / 1000000000000000) > 0)
    {
        words += NumberToWords(number / 1000000000000000) + " quadrillion";
        number %= 1000000000000000;
    }

    if ((number / 1000000000000) > 0)
    {
        words += NumberToWords(number / 1000000000000) + " trillion";
        number %= 1000000000000;
    }

    if ((number / 1000000000) > 0)
    {
        words += NumberToWords(number / 1000000000) + " billion";
        number %= 1000000000;
    }

    if ((number / 1000000) > 0)
    {
        words += NumberToWords(number / 1000000) + " million";
        number %= 1000000;
    }

    if ((number / 1000) > 0)
    {
        words += NumberToWords(number / 1000) + " thousand";
        number %= 1000;
    }

    if ((number / 100) > 0)
    {
        words += NumberToWords(number / 100) + " hundred";
        number %= 100;
    }

    if (number > 0)
    {
        if (words != " ")
            words += " ";

        var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        if (number < 20)
            words += unitsMap[(int)number];
        else
        {
            words += tensMap[(int)number / 10];
            if ((number % 10) > 0)
                words += "-" + unitsMap[(int)number % 10];
        }
    }

    return words;
}

}
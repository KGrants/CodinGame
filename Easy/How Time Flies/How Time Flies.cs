using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        DateTime BEGIN = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
        DateTime END = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

        int days = (END-BEGIN).Days;
        int years = (DateTime.ParseExact("01.01.2022", "dd.MM.yyyy", null).AddDays(days)).Year-DateTime.ParseExact("01.01.2022", "dd.MM.yyyy", null).Year;
        int months = (DateTime.ParseExact("01.01.2022", "dd.MM.yyyy", null).AddDays(days)).Month-DateTime.ParseExact("01.01.2022", "dd.MM.yyyy", null).Month;

        if (years==1) Console.Write($"{years} year, ");
        else if (years>1) Console.Write($"{years} years, ");

        if (months>1) Console.Write($"{months} months, ");
        else if (months == 1) Console.Write($"{months} month, ");

        Console.Write($"total {days} days");
    }
}
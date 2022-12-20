using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(string[] args)
    {
        string intext = Console.ReadLine().ToLower().Trim();

        ///remove excessive spaces
        intext = Regex.Replace(intext, @"\s{2,}", " ");

        ///No spaces before punctuation marks
        intext = Regex.Replace(intext, @"\s?\p{P}\s?", (match) => match.Value.Trim());

        ///Remove repeated punctuation marks
        intext = Regex.Replace(intext, @"\p{P}+", (match) =>  match.Value.Trim()[0].ToString());

        ///First word with capital letter
        intext = string.Join(".", intext.Split('.').Select(s => WordToCapital(s)));

        ///One space after each punctuation mark in front of a letter;
        intext = Regex.Replace(intext, @"\p{P}", (match) => match.Value + " ");

        Console.WriteLine(intext.Trim());
    }
public static string WordToCapital(string i)
{
    if (i.Length>0)
        return Char.ToUpper(i[0])+ i[1..];
    else
        return String.Empty;
}
}
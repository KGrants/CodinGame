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
        string[] metr = Console.ReadLine().Split('+');
        for (int i = 0; i < metr.Length; i++)
            metr[i] = metr[i].Trim();

        Console.WriteLine(GetSmallestUnit(metr[0], metr[1]));
    }

static string GetSmallestUnit(string a, string b)
{
    int unittouse = 0;
    int aindex = 0;
    int bindex = 0;
    decimal anum = 0;
    decimal bnum = 0;
    string[] units = new string[] {"um","mm","cm","dm","m","km"};

    aindex = Array.IndexOf(units,new string(a.SkipWhile(c=>!char.IsLetter(c))
                         .TakeWhile(c=>char.IsLetter(c))
                         .ToArray()));

    bindex = Array.IndexOf(units,new string(b.SkipWhile(c=>!char.IsLetter(c))
                         .TakeWhile(c=>char.IsLetter(c))
                         .ToArray()));

    anum = decimal.Parse(a.Substring(0,a.Length-units[aindex].Length));
    bnum = decimal.Parse(b.Substring(0,b.Length-units[bindex].Length));
    unittouse = Math.Min(aindex,bindex);

    anum = anum * (decimal)Math.Pow(10,aindex-unittouse);
    bnum = bnum * (decimal)Math.Pow(10,bindex-unittouse);

    if ((unittouse == 0 && aindex-unittouse != 0) || aindex == 5)
    anum = anum * 100;

    if ((unittouse == 0 && bindex-unittouse != 0) || bindex == 5)
    bnum = bnum * 100;

    return String.Format("{0:0.####}",(anum+bnum))+units[unittouse];
    }
}
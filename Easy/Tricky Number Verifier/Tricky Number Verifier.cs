using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<string> NUM = new List<string>();

        for (int i = 0; i < N; i++)
        {
            string number = Console.ReadLine();
            NUM.Add(number);
        }

        for (int i = 0; i < N; i++)
        {
            ///First: Check syntax with checknumb();
            if (checksyntax(NUM[i])==false)
            {
                Console.WriteLine("INVALID SYNTAX");
                continue;
            }

            ///Second: Check date with checkdate();
            if (checkdate(NUM[i])==false)
            {
                Console.WriteLine("INVALID DATE");
                continue;
            }

            ///Third: Check X value, if it's 10 or higher increment unique identifier and recalculate x;
            if (calcx(NUM[i])>=10)
            {
                int check = 1+ Convert.ToInt32(NUM[i].Substring(0,3));
                int x = calcx(Convert.ToString(check)+'0'+NUM[i].Substring(4));
                Console.WriteLine($"{check}{x}{NUM[i].Substring(4)}");                
                continue;
            }
            ///Forth: Check X value, if it's below 10, but doesn't match the input - swap it
            else if (calcx(NUM[i])<10 && NUM[i].Substring(3,1) != Convert.ToString(calcx(NUM[i])))
            {
                int x = calcx(NUM[i]);
                Console.WriteLine($"{NUM[i].Substring(0,3)}{x}{NUM[i].Substring(4)}");
                continue;
            }
            ///Last: If no problems found - write OK
            Console.WriteLine("OK");
        }
    }

    static int calcx(string idnumber)
    {
        char[] chrarr = idnumber.ToCharArray();
        int[] ints = Array.ConvertAll(chrarr, c => (int)Char.GetNumericValue(c));
        int[] factors = new int[] {3,7,9,0,5,8,4,2,1,6};
        int x = 0;

        for (int i = 0; i<factors.Length; i++)
        {
            x += ints[i]*factors[i];
        }
        
        return x%11;
    }

    static bool checksyntax(string idnumber)
    {
        bool result = true;
    
        if (idnumber.Length!=10 || idnumber.StartsWith('0') || idnumber.Any(d => !char.IsDigit(d)))
        result = false;

        return result;
    }

    static bool checkdate(string idnumber)
    {
        bool status = false;
        DateTime val;
        if (DateTime.TryParseExact(idnumber.Substring(4), "ddMMyy",
                           CultureInfo.InvariantCulture,
                           DateTimeStyles.None,
                           out val))
        status = true;
        else
        status = false;
        
        return status;
    }
}
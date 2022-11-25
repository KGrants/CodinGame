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
        string sb = "";
        StringBuilder Answer = new StringBuilder();
        string MESSAGE = Console.ReadLine();

        foreach (char c in MESSAGE.ToCharArray())
        {
            sb += (Convert.ToString(c, 2).PadLeft(7, '0'));
        }
        char[] test = sb.ToCharArray();
        int Count = 1;

        for (int i = 0; i<test.Length; i++)
        {
            if (i==0)
            {
                Answer.Append(InsStart(test[i]));
            }
            else if (i>0 && i<test.Length-1)
            {
                if (test[i]==test[i-1])
                {
                    Count += 1;
                }
                else
                {
                    for (int u = 0; u<Count; u++)
                    {
                        Answer.Append("0");
                    }
                    Count = 1;
                    Answer.Append(" ");
                    Answer.Append(InsStart(test[i]));
                }
            }
            else
            {   
                if (test[i]==test[i-1])
                {
                    Count += 1;
                    for (int u = 0; u<Count; u++)
                    {
                        Answer.Append("0");
                    }
                }
                else
                {   
                    for (int u = 0; u<Count; u++)
                    {
                        Answer.Append("0");
                    }
                    Count = 1;
                    Answer.Append(" ");
                    Answer.Append(InsStart(test[i]));
                    Answer.Append("0");
                }
            }
        }        
        Console.WriteLine(Answer);
    }
    
    public static string InsStart(char x)
    {
        string a;
        if (x.Equals('1'))
        {
            a = "0 ";
        }
        else 
        {
            a = "00 ";
        }
        return a;
    }
}
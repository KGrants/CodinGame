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
        try{
            int sentNum = int.Parse(Console.ReadLine().Replace("8","").Replace(" ",""));

            int test = 0;

            while(test!=sentNum)
            {
                test=sentNum;
                var temp = sentNum.ToString().ToCharArray();
                for(int i = 0; i < temp.Length-1 ;i++)
                {
                    if(temp[i]=='9' && temp[i+1]=='7')
                        temp[i]='*';
                    else if(temp[i]=='7'&&temp[i+1]=='9')
                        temp[i+1]='*';
                }

                sentNum = int.Parse(string.Concat(temp).Replace("*",""));

            }

            Console.WriteLine(sentNum);
        }
        catch
        {
            Console.WriteLine("Nothing!");
        }
    }
}

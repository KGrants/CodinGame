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
        string MESSAGE = Console.ReadLine();
        string result = "";
        bool is_v = false;

        for (int i = 0; i < MESSAGE.Length; i++){
            if ((MESSAGE[i] == 'v') &&(!(is_v))){
                result += "w";
                is_v = true;
            }
            if ((MESSAGE[i] == 'v')&& !(is_v)){
                    is_v = false;
                }
            if (MESSAGE[i] != 'v'){
            result += MESSAGE[i];}
        }
        Console.WriteLine(result);
    }
}
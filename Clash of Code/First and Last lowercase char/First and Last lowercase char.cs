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
        string message = Console.ReadLine();
        string x1 = "";
        foreach(var x in message)
	{
            if(char.IsLower(x))
	    {
            	x1 += x;
            	break;
	    }
        }
        x1 += "-";

        var y = message.Reverse();
        foreach(var z in y)
	{
            if(char.IsLower(z))
	    {
            	x1 += z;
            	break;
	    }
        }
        Console.WriteLine(x1);
    }
}
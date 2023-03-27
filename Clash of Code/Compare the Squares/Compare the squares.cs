using System;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < N; i++)
	{
		string[] input = Console.ReadLine().split(" ");
		double a = int.parse(input[0]);
        	double b = int.parse(input[1]);

        	double f = pow(a,2) + pow(b,2);
        	double s = pow(a+b,2);
	        if(f>s)
        	    Console.WriteLine(">");
	        else if(f==s)
        	    Console.WriteLine("=");
        	else
            	    Console.WriteLine("<");
        }
    }
}
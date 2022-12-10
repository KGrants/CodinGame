using System;

class Solution
{
    static void Main(string[] args)
    {
        long P = long.Parse(Console.ReadLine());
        char[] C = Console.ReadLine().ToCharArray();
        string answer = String.Empty;

        while ( P >= 0 ) 
        { 
            answer += C[ P % C.Length ]; 
            P = P / C.Length - 1; 
        } 
    Console.WriteLine(answer);
    }
}
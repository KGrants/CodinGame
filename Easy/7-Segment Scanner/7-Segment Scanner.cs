using System;

class Solution
{
    static void Main(string[] args)
    {
        string line1 = Console.ReadLine();
        string line2 = Console.ReadLine();
        string line3 = Console.ReadLine();

        for (int i = 0; i<line1.Length/3; i++)
        {   
            string num1 = line1.Substring(i*3,3); 
            string num2 = line2.Substring(i*3,3); 
            string num3 = line3.Substring(i*3,3); 

            if (num1.Trim() == string.Empty)
                if (num2[1] == '_')
                    Console.Write(4);
                else 
                    Console.Write(1);

            else if (num2[0] == ' ')
                if (num2[1] == ' ')
                    Console.Write(7);
                else if (num3[0] == ' ')
                    Console.Write(3);
                else 
                    Console.Write(2);

            else if (num3[0] == ' ')
                if (num2[2] == ' ')
                    Console.Write(5);
                else
                    Console.Write(9);

            else if (num2[1] == ' ')
                Console.Write(0);
            else if (num2[2] == ' ')
                Console.Write(6);
    
            else
                Console.Write(8);
        }
    }
}
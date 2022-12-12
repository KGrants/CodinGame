using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < N; i++)
        {   
            List<int> existed = new List<int>();
            string x = Console.ReadLine();
            int tempsum = 0;

            Console.Write(x + " ");

            while(x!= "1")
            {      
                tempsum = 0;
                int[] tempx = Array.ConvertAll(x.ToCharArray(), c => (int)Char.GetNumericValue(c));
                foreach(int num in tempx)
                    tempsum += num*num;

                x = Convert.ToString(tempsum);
                if (existed.Contains(tempsum))
                    break;

                existed.Add(tempsum);
            }

            if (x == "1")
                Console.WriteLine(":)");
            else 
                Console.WriteLine(":(");
        }
    }
}
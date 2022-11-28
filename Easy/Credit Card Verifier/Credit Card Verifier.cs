using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int[] intarray =  Array.ConvertAll(Console.ReadLine().Replace(" ","").ToCharArray(), c => (int)Char.GetNumericValue(c));
            int sum = 0;

            for (int a = 0; a<intarray.Length; a++)
            {   
                if (a%2 == 1)
                sum += intarray[a];
                else if (a%2 ==0 && intarray[a]*2>=10)
                sum += (intarray[a]*2)-9;
                else
                sum += intarray[a]*2;
            }

            if (sum % 10 ==0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");        
        }
    }
}
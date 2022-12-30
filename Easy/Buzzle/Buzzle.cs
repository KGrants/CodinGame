using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int n = int.Parse(inputs[0]);

        int[] numbers = Enumerable.Range(int.Parse(inputs[1]), 
                        int.Parse(inputs[2]) - int.Parse(inputs[1]) + 1).ToArray();

        int k = int.Parse(Console.ReadLine());
        List<int> nums = Console.ReadLine().Split(' ').Select(x => int.Parse(x.ToString())).ToList();

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int u = 0; u < nums.Count(); u++)
            {
                char lastchar = Convert.ToChar(convertbase(nums[u],n));


                if (numbers[i]%nums[u] == 0 ||
                    convertbase(numbers[i],n).Last().Equals(lastchar) || 
                    getdigitsum(convertbase(numbers[i],n))%nums[u] == 0 ||
                    convertbase(getdigitsum(convertbase(numbers[i],n)),n).Last().Equals(lastchar) ||
                    getdigitsum(convertbase(getdigitsum(convertbase(numbers[i],n)),n))%nums[u] == 0 ||
                    convertbase(getdigitsum(convertbase(getdigitsum(convertbase(numbers[i],n)),n)),n).Last().Equals(lastchar))
                {    
                    Console.WriteLine("Buzzle");
                    break;
                }

                if (u == nums.Count()-1)
                    Console.WriteLine(numbers[i]);
            }
        }
    }

    static string convertbase(int n, int b)
    {
        string result = "";
        string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz+-";

        while (n != 0)
        {
            result = digits[n % b] + result;
            n /= b;
        }
        return result;
    }

    public static int getdigitsum(string num)
    {
        List<int> sumnum = new List<int>();
        for (int i = 0; i < num.Length; i++)
        {
            if (int.TryParse(num[i].ToString(), out int res))
                sumnum.Add(res);
            else
                sumnum.Add(int.Parse((num[i]-55).ToString()));
        }
        return sumnum.Sum();
    }
}
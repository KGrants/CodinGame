using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        Dictionary <string, decimal> resist = new Dictionary<string, decimal>();
        string resistors = "";

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            resist[inputs[0]] = decimal.Parse(inputs[1]);
        }

        string circuit = Console.ReadLine();
 
        while (!decimal.TryParse(circuit,out decimal result))
        {
            for (int i = 0; i < circuit.Length; i++) 
            {
                if (circuit[i] == '(' || circuit[i] == '[')
                    resistors = "";

                resistors += circuit[i];

                if (circuit[i] == ')' || circuit[i] == ']')
                    break;
            }
            circuit = circuit.Replace(resistors,Convert.ToString(getresistance(resistors,resist)));
        }
        Console.WriteLine(string.Format("{0:F1}", Math.Round(decimal.Parse(circuit),1)));
    }

    public static decimal getresistance(string i, Dictionary <string, decimal> resist)
    {
        string[] bin = i.Substring(2,i.Length-4).Split(' ');
        decimal[] nums = new decimal[bin.Length];

        for (int x = 0; x < bin.Length; x++)
        {
            if (decimal.TryParse(bin[x], out decimal number))
                nums[x] = number;
            else
                nums[x] = resist[bin[x]];
        }

        if (i[0].Equals('('))
            return Math.Round(nums.Sum(x=>x),1);

        if (i[0].Equals('['))
            return Math.Round(1/nums.Sum(x=>1/x),1);

        return 0;
    }
}
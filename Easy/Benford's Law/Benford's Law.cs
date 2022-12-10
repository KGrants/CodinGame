using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {   
        int N = int.Parse(Console.ReadLine());
        double[] numbers = new double[9];
        double[] limits = new double[] {30.1, 17.6, 12.5, 9.7, 7.9, 6.7, 5.8, 5.1, 4.6};
        string answer = "false";

        for (int i = 0; i < N; i++)
        {
            int transaction = int.Parse(new string(Console.ReadLine().Where(n => char.IsNumber(n)).Where(n => !n.Equals('0')).First(),1));
            numbers[transaction-1]++;
        }

        for (int i = 0; i < 9; i++)
            {   
                if (numbers[i]/N*100 < limits[i] - 10 || numbers[i]/N*100 > limits[i] + 10)
                {
                    answer = "true";
                    break;
                }
            }
        Console.WriteLine(answer);   
    }
}
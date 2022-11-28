using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string display, oper, operbackup;
        display = oper = operbackup = "";
        double a = 0;
        double b = 0;

        for (int i = 0; i < n; i++)
        {
            string key = Console.ReadLine();
            if (key == "AC") //// If AC - display 0 and reset numbers and operands.
            {
                Console.WriteLine("0");
                display = oper = "";
                continue;
            }
            else if (char.IsNumber(Convert.ToChar(key))) /// If it's a number - concatinate.
            {
                display += Convert.ToChar(key);
                Console.WriteLine(display);
                continue;
            }
            else
            {   
                if (display.Length > 0) ////Calculates results and resets calculator
                {
                    b = int.Parse(display);
                    Console.WriteLine(Math.Round(calculator(b,a,oper),3));
                    a = calculator(b,a,oper);
                    operbackup = oper;
                    oper = key;
                    display = "";
                    continue;
                }
                else if (display.Length <1 && key == "=") /// This handles multiple = in a row
                {
                    Console.WriteLine(Math.Round(calculator(b,a,operbackup),3));
                    a = calculator(b,a,operbackup);
                    continue;
                }
                else /// This part handles two or more different operators - just use that last one
                {
                    oper = key;
                    Console.WriteLine(a);
                    continue;
                }
            }
        }
    }

    static double calculator(double a, double b, string oper) => oper switch
    {
        "+" => a+b,
        "-" => b-a,
        "x" => a*b,
        "/" => (double)b/a,
        _ => a
    };
}
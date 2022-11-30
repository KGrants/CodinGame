using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int L = int.Parse(inputs[0]);
        int H = int.Parse(inputs[1]);
        List<string> MayanNumbers = new List<string>(); ///Reading in Mayan numbers
        for (int i = 0; i < H; i++)
            MayanNumbers.Add(Console.ReadLine());

        int S1 = int.Parse(Console.ReadLine());         ///Reading first number to work with
        List<string> numb1 = new List<string>();
        for (int i = 0; i < S1; i++)
            numb1.Add(Console.ReadLine());

        int S2 = int.Parse(Console.ReadLine());         ///Reading second number to work with
        List<string> numb2 = new List<string>();
        for (int i = 0; i < S2; i++)
            numb2.Add(Console.ReadLine());

        string operation = Console.ReadLine();
        long numbertoconvertback = Calculate(ConvertNumb(numb1, H, L, MayanNumbers, S1), 
                                             ConvertNumb(numb2, H, L, MayanNumbers, S2), 
                                             operation); ///Decoding to decimal and calcuating result
        IEnumerable<long> finish = calculate20base(numbertoconvertback); ///Calculating 20base numbers 

        for (int i = 0; i<finish.Count(); i++)
        {
            for (int a = 0; a < H; a++)
            Console.WriteLine(MayanNumbers[a].Substring((int)finish.ElementAt(i)*L,L)); ///Using 20base numbers to write output from Mayan numbers
        }
    }

static int ConvertNumb(List<string> input, int H, int L, List<string> MayanNumbers, int S)
{
    int result = 0;
    string[] MayanString = new string[20];

    for (int a = 0; a<20; a++)
    {
        for (int i = 0; i < H; i++)
            MayanString[a] += MayanNumbers[i].Substring(a*L,L);
    }

    for (int a = 0; a<input.Count()/H; a++)
    {
        double sum = 0;
        string[] findstring = new string[20];

        for (int i = 0; i <= H-1; i++) 
            findstring[a] += input.ElementAt(i+(L*a));

        sum = Array.IndexOf(MayanString,findstring[a]);
        sum = sum * Math.Pow(20.0,(input.Count()/H)-1-a);
        result+=(int)sum;
    }
    return result;
}

static long Calculate(long a, long b, string oper) 
{
    long result = 0;

    switch (oper)
    {
        case "+": result = a+b; break;
        case "-": result=a-b; break;
        case "*": result = a*b; break;
        case "/": result = a/b; break;
        default: result = 0; break;
    }
    return result;
}

static IEnumerable<long> calculate20base(long input)
{
    var result = new Stack<long>();
    if (input == 0) result.Push(0);

    while (input != 0)
    {
        result.Push(input % 20);
        input /= 20;
    }
    return result;
}
}
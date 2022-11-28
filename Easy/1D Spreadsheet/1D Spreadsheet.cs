using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());
        string [] test0 = new string[N];
        string [] test1 = new string[N];
        string [] test2 = new string[N];
        int[] answer = new int[N];
        int ContCheck;
        int[] check0 = new int[N];

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            test0[i] = inputs[0];
            test1[i] = inputs[1];
            test2[i] = inputs[2];

            if (test0[i] == "VALUE" && !test1[i].StartsWith('$'))
            {
            answer[i] = int.Parse(test1[i]);
            check0[i] = 1;
            }
        }

        do
        {  
        ContCheck = 0;
        for (int i = 0; i < N; i++)
        {
            int N1;
            int N2;

            if (test1[i].StartsWith('$') && answer[int.Parse(test1[i].Substring(1))] == 0 && check0[int.Parse(test1[i].Substring(1))] != 1)
            {
            ContCheck = 1;
            continue;
            }
            else if (test1[i].StartsWith('$'))
            N1 = answer[int.Parse(test1[i].Substring(1))];
            else
            N1 = int.Parse(test1[i]);

            if (test0[i] == "VALUE")
            N2 = 0;
            else if (test2[i].StartsWith('$') && answer[int.Parse(test2[i].Substring(1))] == 0 && check0[int.Parse(test2[i].Substring(1))] != 1)
            {
            ContCheck = 1;
            continue;
            }
            else if (test2[i].StartsWith('$'))
            N2 = answer[int.Parse(test2[i].Substring(1))];
            else
            N2 = int.Parse(test2[i]);
        
            answer[i] = calc(test0[i],N1,N2);
            if (answer[i] == 0)
            check0[i] = 1;
        }
        } while(ContCheck == 1);

            for (int i = 0; i<N;i++)
            {
                Console.WriteLine(answer[i]);
            }    
    }

    static int calc(string operation, int A, int B)
    {
        int number = 0;
        switch(operation)
        {
            case "VALUE":
            number = A;
            break;

            case "ADD":
            number = A+B;
            break;

            case "SUB":
            number = A-B;
            break;

            case "MULT":
            number = A*B;
            break;
        }

        return number;
    }
}
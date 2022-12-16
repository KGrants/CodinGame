using System;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int[] budget = new int[N];
        int[] contr = new int[N];
        int tot = 0;

        for (int i = 0; i < N; i++)
        {
            budget[i] = int.Parse(Console.ReadLine());
            tot += budget[i];
        }

        if (tot<C)
        {   
            Console.WriteLine("IMPOSSIBLE");
            return;
        }
        
        while (C>N)
        {
            var split = C/N;
            
            for (int i = 0; i < budget.Length; i++)
            {
                if (budget[i] ==0)
                    continue;

                int payup = Math.Min(split,budget[i]);
                budget[i] -= payup;
                C -= payup;
                contr[i] += payup;

                if (budget[i] ==0)
                    N -= 1;
            }
        }

        int count = 0;
        while (C>0)
        {
            if (budget[count] ==0)
            {
                count += 1;
                continue;
            }
                
                budget[count] -= 1;
                C -= 1;
                contr[count] += 1;
                count += 1;
        }
        Array.Sort(contr);

        foreach (var i in contr)
            Console.WriteLine(i);
    }
}
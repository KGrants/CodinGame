using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        List<string> bankCards = Console.ReadLine().Split(' ').ToList();
        List<string> playerCards = Console.ReadLine().Split(' ').ToList();

        int bankresult = calculatescore(bankCards);
        int playerresult = calculatescore(playerCards);

        if (playerCards.Count() == 2 && playerresult ==21 && bankresult ==21 && bankCards.Count() ==2)
            Console.WriteLine("Draw");
        else if (playerCards.Count() == 2 && playerresult ==21)
            Console.WriteLine("Blackjack!");
        else if (playerresult>21)
            Console.WriteLine("Bank");
        else if (bankresult>21)
            Console.WriteLine("Player");
        else if (bankresult<playerresult)
            Console.WriteLine("Player");
        else if (bankresult>playerresult)
            Console.WriteLine("Bank");
        else
            Console.WriteLine("Draw");
    }

    public static int calculatescore(List<string> a)
    {
        int[] scores = new int[a.Count];
        for (int i = 0; i < a.Count(); i++)
        {
            if (!int.TryParse(a[i], out int r))
            {
                if (a[i] == "A")
                    scores[i] = 11;
                else
                    scores[i] = 10;
            }
            else
                scores[i] = r;
        }
        while (scores.Sum() > 21 && Array.IndexOf(scores,11)!=-1)
            scores[Array.IndexOf(scores,11)] = 1;

        return scores.Sum();
    }
}
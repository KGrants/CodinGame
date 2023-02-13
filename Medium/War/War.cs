using System;
using System.Collections;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); 
        Queue player_one = new Queue(); 
        for (int i = 0; i < n; i++)
            player_one.Enqueue(Console.ReadLine());

        int m = int.Parse(Console.ReadLine());
        Queue player_two = new Queue(); 
        for (int i = 0; i < m; i++)
            player_two.Enqueue(Console.ReadLine());
        int counter = 0;
        Queue c1 = new Queue();
        Queue c2 = new Queue();
        

        while(true)
        {
            string a = player_one.Dequeue().ToString();
            string b = player_two.Dequeue().ToString();
            c1.Enqueue(a);
            c2.Enqueue(b);
            counter++;
            int round_winner = compare(a,b);

            if (round_winner ==3)
            {
                while (true)
                {
                    if (player_one.Count<4 || player_two.Count<4)
                    {
                        Console.WriteLine("PAT");
                        Environment.Exit(0);
                    }
                    for (int i = 0; i < 3; i++)
                        c1.Enqueue(player_one.Dequeue());
                    for (int i = 0; i < 3; i++)
                        c2.Enqueue(player_two.Dequeue());

                    a = player_one.Dequeue().ToString();
                    b = player_two.Dequeue().ToString();
                    c1.Enqueue(a);
                    c2.Enqueue(b);
                    round_winner = compare(a,b);
                    if (round_winner != 3)
                        break;
                }
            }
            int cc = c1.Count;
            if (round_winner == 1)
            {
                for (int i = 0; i < cc; i++)
                    player_one.Enqueue(c1.Dequeue());
                for (int i = 0; i < cc; i++)
                    player_one.Enqueue(c2.Dequeue());
            }
            else if (round_winner == 2)
            {
                for (int i = 0; i < cc; i++)
                    player_two.Enqueue(c1.Dequeue());
                for (int i = 0; i < cc; i++)
                    player_two.Enqueue(c2.Dequeue());
            }
            if (player_one.Count<1 || player_two.Count<1)
            {
                int h = player_two.Count<1 ? 1 : 2;
                Console.WriteLine($"{h} {counter}");
                break;
            }
        }
    }
    public static int convert(string a)
    {
        switch(a[0])
        {
            case '1': return 10;
            case 'J': return 11;
            case 'Q': return 12;
            case 'K': return 13;
            case 'A': return 14;
            default : return int.Parse(a[0].ToString());
        }
    }
    public static int compare(string a, string b)
    {
        int aa = convert(a);
        int bb = convert(b);
        if (aa>bb)
            return 1;
        else if (aa<bb)
            return 2;
        else
            return 3;
    }
}
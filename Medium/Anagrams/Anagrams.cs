using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        string phrase = Console.ReadLine();
        phrase = DECODE1(phrase);
        phrase = DECODE2(phrase);
        phrase = DECODE3(phrase);
        phrase = DECODE4(phrase);
        Console.WriteLine(phrase);
    }

    public static string DECODE1(string phrase) // Reversing length
    {
        string[] input = phrase.Split(" ");
        Array.Reverse(input);
            
        phrase = phrase.Replace(" ", string.Empty);
        string result = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            result += phrase.Substring(0, input[i].Length) + " ";
            phrase = phrase.Substring(input[i].Length);
        }
        return result.Trim();
    }

    public static string DECODE2(string phrase) // 4th letter of the alphabet
    {
        IEnumerable<char> fourth = Enumerable.Range(0, 26).Where(i => i % 4 == 3).Select(i => (char)(i + 65));
        Queue<char> swap = new Queue<char>();
        IEnumerable<char> swapletters = phrase.Where(c => fourth.Contains(c));

        if (swapletters.Count() >= 2)
        {
            swap.Enqueue(swapletters.Last()); // need to shift to the right so all +1. First add last as first in queue
            for (int i = 0; i < swapletters.Count() - 1; i++) 
                swap.Enqueue(swapletters.ElementAt(i)); // then add all the rest
        }

        string result = SWAP(phrase,fourth,swap);
        return result;
    }

    public static string DECODE3(string phrase) // 3rd letter of the alphabet
    {
        IEnumerable<char> third = Enumerable.Range(0, 26).Where(i => i % 3 == 2).Select(i => (char)(i + 65));
        Queue<char> swap = new Queue<char>();
        IEnumerable<char> swapletters = phrase.Where(c => third.Contains(c));
        
        foreach (var character in swapletters.Skip(1))  // Need to shift all to the left so all -1
            swap.Enqueue(character);                    // First add last as first in queue 

        if (swapletters.Count() >= 2)                   // Then add all the rest to the queue
            swap.Enqueue(swapletters.First());

        var result = SWAP(phrase,third,swap);
        return result;
    }


    public static string DECODE4(string phrase) // 2nd letter of the alphabet
    {
        IEnumerable<char> second = Enumerable.Range(0, 26).Where(i => i % 2 == 1).Select(i => (char)(i + 65));
        Queue<char> swap = new Queue<char>();

        foreach (var character in phrase.Reverse().Where(c => second.Contains(c)))
            swap.Enqueue(character);

        var result = SWAP(phrase,second,swap);
        return result;
    }

    static string SWAP(string phrase, IEnumerable<char> input, Queue<char> swap)
    {
        for (int i = 0; i < phrase.Length; i++)
        {
            if (input.Contains(phrase.ElementAt(i)))
            {
                phrase = phrase.Remove(i, 1);
                phrase = phrase.Insert(i, swap.Dequeue().ToString());
            }
        }
        return phrase;
    }
}
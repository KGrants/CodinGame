using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<Word> dict = new List<Word>();
        for (int i = 0; i < N; i++)
        {
            string input = Console.ReadLine();
            dict.Add(new Word() {word = input, score = calculatescore(input)});
        }

        char[] LETTERS = Console.ReadLine().ToCharArray();

        foreach (Word i in dict.OrderByDescending(x => x.score))
        {
            if (checkword(i.word,LETTERS))
            {
                Console.WriteLine(i.word);
                break;
            }
        }
    }

public class Word
{
    public string word { get; set; }
    public int score { get; set; }
}

static int calculatescore(string input)
{
    int result = 0;

    foreach (char c in input)
    {
        if(c=='q' || c=='z')
            result += 10;
        else if (c=='j' || c=='x')
            result += 8;
        else if (c=='k')
            result += 5;
        else if (c=='f' || c=='h' || c=='v' || c=='w' || c=='y')
            result += 4;
        else if (c=='b' || c=='c' || c=='m' || c=='p')
            result += 3;
        else if (c=='d' || c=='g')
            result += 2;
        else
            result += 1;
    }
    return result;
}

static bool checkword(string word, char[] abc)
{
    if (word.Length>abc.Length) 
        return false;

    foreach (char i in word)
    {
        if (abc.Contains(i))
        {
            int numIndex = Array.IndexOf(abc, i);
            abc = abc.Where((val, idx) => idx != numIndex).ToArray();
            continue;
        }
        else if(!abc.Contains(i))
            return false;
    }     
    return true;       
}
}
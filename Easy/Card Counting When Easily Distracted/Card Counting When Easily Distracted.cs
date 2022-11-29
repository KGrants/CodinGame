using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {   
        char[] cards = new char[] {'A','2','3','4','5','6','7','8','9','T','J','Q','K'};    //Chars, that are valid cards
        string[] s = Console.ReadLine().Split('.');                                         //Create array with all thoughts
        string cardsonly = "";                                                              //This will be populated with valid thoughts
        for (int i = 0; i < s.Length; i++)                                                  //Filter out only card related thoughts
            if (s[i].All(cards.Contains)) cardsonly += s[i];

        string bustThreshold = Console.ReadLine();                                          //Treshhold as string and 
        if (bustThreshold == "10") bustThreshold = "T";                                     //convert to T if 10 

        int belowbust = 0;                                                                  //Will be used to count cards left in the deck
        int abovebust = 0;

        foreach(char i in cards)                                                            //Count each cards in string and
        {                                                                                   // if less than 4 compare to treshhold and add to calc
            if (cardsonly.Count(t => t == i)<4 && Array.IndexOf(cards,i)<Array.IndexOf(cards,Convert.ToChar(bustThreshold)))
            belowbust += 4-cardsonly.Count(t => t == i);
            else if (cardsonly.Count(t => t == i)<4 && Array.IndexOf(cards,i)>=Array.IndexOf(cards,Convert.ToChar(bustThreshold)))
            abovebust += 4-cardsonly.Count(t => t == i);
        }
        Console.WriteLine($"{Math.Round((decimal)belowbust/(belowbust+abovebust)*100)}%");  //Calculate and display result
    }
}
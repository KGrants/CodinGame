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
        string[] inputs;
        int nbturns = int.Parse(Console.ReadLine());

        /////PLayer One input
        inputs = Console.ReadLine().Split(' ');
        int n = int.Parse(inputs[0]);   ////strategy count
        string AI1 = inputs[1];         ////Player name
        string[] PL1_strat = new string[n];
        for (int i = 0; i < n; i++) PL1_strat[i] = Console.ReadLine();

        /////Player two input
        inputs = Console.ReadLine().Split(' ');
        int m = int.Parse(inputs[0]);
        string AI2 = inputs[1];
        string[] PL2_strat = new string[m];
        for (int i = 0; i < m; i++) PL2_strat[i] = Console.ReadLine();

        ////Variables
        int rotor =0;
        int CountC1 =0;
        int CountD1 =0;
        int CountC2 =0;
        int CountD2 =0; //// Up to this all will be used to count C's and D's for for players.
        int x = 12;     //// Start for random sequence
        char?[ , ] turns = new char?[nbturns,2]; ///Creating 2D array to store each turn of each player

        //// Start to write each turn results to "turns" array
        while (rotor<nbturns)
            {
                if (rotor ==0)
                {
                    ////Start with checking for START strategy for both players
                    if (PL1_strat.Any(s => s.Contains("START")))
                    {
                        string input = PL1_strat[Array.FindIndex(PL1_strat, s => s.StartsWith("START", StringComparison.OrdinalIgnoreCase))].Substring(6);
                        turns[rotor,0]= GetCharToAdd(input,x).RetChar;
                        x= GetCharToAdd(input,x).x;
                    }

                    if (PL2_strat.Any(s => s.Contains("START")))
                    {
                        string input = PL2_strat[Array.FindIndex(PL2_strat, s => s.StartsWith("START", StringComparison.OrdinalIgnoreCase))].Substring(6);
                        turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                        x= GetCharToAdd(input,x).x;
                    }

                    //// if no value has been added (so no start strategy) continue with * strategies
                    if (!turns[rotor,0].HasValue)
                    {   
                        string input = PL1_strat[Array.FindIndex(PL1_strat, s => s.StartsWith("*", StringComparison.OrdinalIgnoreCase))].Substring(2);
                        turns[rotor,0]= GetCharToAdd(input,x).RetChar;
                        x= GetCharToAdd(input,x).x;
                    }

                    if (!turns[rotor,1].HasValue)
                    {   
                        string input = PL2_strat[Array.FindIndex(PL2_strat, s => s.StartsWith("*", StringComparison.OrdinalIgnoreCase))].Substring(2);
                        turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                        x= GetCharToAdd(input,x).x;
                    }
                } //////Ends first entries (other strategies would not work for first turn)

                if (rotor>0)
                {   
                    ////////TURNS FOR PLAYER ONE//////////////

                    ///P1 "ME-1" Rules
                    if (Array.FindIndex(PL1_strat, s => s.StartsWith("ME -1", StringComparison.OrdinalIgnoreCase))>0)
                    {
                        var indexlist = Array.FindAll(PL1_strat,s => s.StartsWith("ME -1"));
                        for (int i = 0; i < indexlist.Length; i++)
                        {
                            if (Convert.ToChar(indexlist[i].Substring(6,1)) == turns[rotor-1,0])
                            {
                                string input = indexlist[i].Substring(8);
                                turns[rotor,0]= GetCharToAdd(input,x).RetChar;
                                x= GetCharToAdd(input,x).x;
                            }
                        }
                    }

                    ///P1 "OPP LAST N" Rules
                    if (Array.FindIndex(PL1_strat, s => s.StartsWith("OPP LAST", StringComparison.OrdinalIgnoreCase))>0)
                    {
                        var indexlist = Array.FindAll(PL1_strat,s => s.StartsWith("OPP LAST"));
                        for (int i = 0; i < indexlist.Length; i++)
                        {   
                            int SmallCountD = 0;
                            int SmallCountC = 0;

                            for (int u = 1; u <= int.Parse(indexlist[i].Substring(9,1)); u++)
                            {
                                if (rotor-u<0) {} else if(turns[rotor-u,1]=='D') SmallCountD++; else if (turns[rotor-u,1]=='C') SmallCountC++;
                            }

                            if (SmallCountD>SmallCountC && Convert.ToChar(indexlist[i].Substring(11,1))=='D')
                            {
                                string input = indexlist[i].Substring(13);
                                turns[rotor,0]= GetCharToAdd(input,x).RetChar;
                                x= GetCharToAdd(input,x).x;
                            }

                            if (SmallCountD<SmallCountC && Convert.ToChar(indexlist[i].Substring(11,1))=='C')
                            {
                                string input = indexlist[i].Substring(13);
                                turns[rotor,0]= GetCharToAdd(input,x).RetChar;
                                x= GetCharToAdd(input,x).x;
                            }
                        }
                    }

                    ///P1 "ME LAST N" Rules
                    if (Array.FindIndex(PL1_strat, s => s.StartsWith("ME LAST", StringComparison.OrdinalIgnoreCase))>0)
                    {
                        var indexlist = Array.FindAll(PL1_strat,s => s.StartsWith("ME LAST"));
                        for (int i = 0; i < indexlist.Length; i++)
                        {   
                            int SmallCountD = 0;
                            int SmallCountC = 0;

                            for (int u = 1; u <= int.Parse(indexlist[i].Substring(8,1)); u++)
                            {
                                if (rotor-u<0) {} else if(turns[rotor-u,0]=='D') SmallCountD++; else if (turns[rotor-u,0]=='C') SmallCountC++;
                            }

                            if (SmallCountD>SmallCountC && Convert.ToChar(indexlist[i].Substring(10,1))=='D')
                            {
                                string input = indexlist[i].Substring(12);
                                turns[rotor,0]= GetCharToAdd(input,x).RetChar;
                                x= GetCharToAdd(input,x).x;
                            }

                            if (SmallCountD<SmallCountC && Convert.ToChar(indexlist[i].Substring(10,1))=='C')
                            {
                                string input = indexlist[i].Substring(12);
                                turns[rotor,0]= GetCharToAdd(input,x).RetChar;
                                x= GetCharToAdd(input,x).x;
                            }
                        }
                    }

                    ////P1 "OPP -1 D" Rule
                    if (Array.FindIndex(PL1_strat, s => s.StartsWith("OPP -1 D", StringComparison.OrdinalIgnoreCase))>0
                    && turns[rotor-1,1].Equals('D'))
                    {
                    string input = PL1_strat[Array.FindIndex(PL1_strat, s => s.StartsWith("OPP -1 D", StringComparison.OrdinalIgnoreCase))].Substring(9);
                    turns[rotor,0]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ////P1 "OPP -1 C" Rule
                    if (Array.FindIndex(PL1_strat, s => s.StartsWith("OPP -1 C", StringComparison.OrdinalIgnoreCase))>0
                    && turns[rotor-1,1].Equals('C'))
                    {
                    string input = PL1_strat[Array.FindIndex(PL1_strat, s => s.StartsWith("OPP -1 C", StringComparison.OrdinalIgnoreCase))].Substring(9);
                    turns[rotor,0]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ///P1 "OPP MAX D" Rules
                    if (Array.FindIndex(PL1_strat, s => s.StartsWith("OPP MAX D", StringComparison.OrdinalIgnoreCase))>0 
                    && CountD2>CountC2)
                    {
                    string input = PL1_strat[Array.FindIndex(PL1_strat, s => s.StartsWith("OPP MAX D", StringComparison.OrdinalIgnoreCase))].Substring(10);
                    turns[rotor,0]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ///P1 "OPP MAX C" Rules
                    if (Array.FindIndex(PL1_strat, s => s.StartsWith("OPP MAX C", StringComparison.OrdinalIgnoreCase))>0
                    && CountD2<CountC2)
                    {
                    string input = PL1_strat[Array.FindIndex(PL1_strat, s => s.StartsWith("OPP MAX C", StringComparison.OrdinalIgnoreCase))].Substring(10);
                    turns[rotor,0]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ///P1 "ME MAX D" Rules
                    if (Array.FindIndex(PL1_strat, s => s.StartsWith("ME MAX D", StringComparison.OrdinalIgnoreCase))>0
                    && CountD1>CountC1)
                    {
                    string input = PL1_strat[Array.FindIndex(PL1_strat, s => s.StartsWith("ME MAX D", StringComparison.OrdinalIgnoreCase))].Substring(9);
                    turns[rotor,0]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ///P1 "ME MAX C" Rules
                    if (Array.FindIndex(PL1_strat, s => s.StartsWith("ME MAX C", StringComparison.OrdinalIgnoreCase))>0
                    && CountD1<CountC1)
                    {
                    string input = PL1_strat[Array.FindIndex(PL1_strat, s => s.StartsWith("ME MAX C", StringComparison.OrdinalIgnoreCase))].Substring(9);
                    turns[rotor,0]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ///P1 "ME WIN" Rule
                    if (Array.FindIndex(PL1_strat, s => s.StartsWith("ME WIN", StringComparison.OrdinalIgnoreCase))>0
                    && CalculateResults(turns)==1)
                    {
                    string input = PL1_strat[Array.FindIndex(PL1_strat, s => s.StartsWith("ME WIN", StringComparison.OrdinalIgnoreCase))].Substring(7);
                    turns[rotor,0]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ///P1 "OPP WIN" Rule
                    if (Array.FindIndex(PL1_strat, s => s.StartsWith("OPP WIN", StringComparison.OrdinalIgnoreCase))>0
                    && CalculateResults(turns)==2)
                    {
                    string input = PL1_strat[Array.FindIndex(PL1_strat, s => s.StartsWith("OPP WIN", StringComparison.OrdinalIgnoreCase))].Substring(8);
                    turns[rotor,0]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ////////TURNS FOR PLAYER TWO//////////////

                    ///P2 "ME -1 D" Rule
                    if (Array.FindIndex(PL2_strat, s => s.StartsWith("ME -1 D", StringComparison.OrdinalIgnoreCase))>0
                    && turns[rotor-1,1].Equals('D'))
                    {
                    string input = PL2_strat[Array.FindIndex(PL2_strat, s => s.StartsWith("ME -1 D", StringComparison.OrdinalIgnoreCase))].Substring(8);
                    turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ///P2 "ME -1 C" Rule
                    if (Array.FindIndex(PL2_strat, s => s.StartsWith("ME -1 C", StringComparison.OrdinalIgnoreCase))>0
                    && turns[rotor-1,1].Equals('C'))
                    {
                    string input = PL2_strat[Array.FindIndex(PL2_strat, s => s.StartsWith("ME -1 C", StringComparison.OrdinalIgnoreCase))].Substring(8);
                    turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ///P2 "OPP -1 D" Rule
                    if (Array.FindIndex(PL2_strat, s => s.StartsWith("OPP -1 D", StringComparison.OrdinalIgnoreCase))>0
                    && turns[rotor-1,0].Equals('D'))
                    {
                    string input = PL2_strat[Array.FindIndex(PL2_strat, s => s.StartsWith("OPP -1 D", StringComparison.OrdinalIgnoreCase))].Substring(9);
                    turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ///P2 "OPP -1 C" Rule
                    if (Array.FindIndex(PL2_strat, s => s.StartsWith("OPP -1 C", StringComparison.OrdinalIgnoreCase))>0
                    && turns[rotor-1,0].Equals('C'))
                    {
                    string input = PL2_strat[Array.FindIndex(PL2_strat, s => s.StartsWith("OPP -1 C", StringComparison.OrdinalIgnoreCase))].Substring(9);
                    turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ///P2 "OPP LAST N" Rules
                    if (Array.FindIndex(PL2_strat, s => s.StartsWith("OPP LAST", StringComparison.OrdinalIgnoreCase))>0)
                    {
                        var indexlist = Array.FindAll(PL2_strat,s => s.StartsWith("OPP LAST"));
                        for (int i = 0; i < indexlist.Length; i++)
                        {   
                            int SmallCountD = 0;
                            int SmallCountC = 0;

                            for (int u = 1; u <= int.Parse(indexlist[i].Substring(9,1)); u++)
                            {
                                if (rotor-u<0) {} else if(turns[rotor-u,0]=='D') SmallCountD++; else if (turns[rotor-u,0]=='C') SmallCountC++;
                            }

                            if (SmallCountD>SmallCountC && Convert.ToChar(indexlist[i].Substring(11,1))=='D')
                            {
                                string input = indexlist[i].Substring(13);
                                turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                                x= GetCharToAdd(input,x).x;
                            }

                            if (SmallCountD<SmallCountC && Convert.ToChar(indexlist[i].Substring(11,1))=='C')
                            {
                                string input = indexlist[i].Substring(13);
                                turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                                x= GetCharToAdd(input,x).x;
                            }
                        }
                    }

                    ///P2 "ME LAST N" Rules
                    if (Array.FindIndex(PL2_strat, s => s.StartsWith("ME LAST", StringComparison.OrdinalIgnoreCase))>0)
                    {
                        var indexlist = Array.FindAll(PL2_strat,s => s.StartsWith("ME LAST"));
                        for (int i = 0; i < indexlist.Length; i++)
                        {   
                            int SmallCountD = 0;
                            int SmallCountC = 0;

                            for (int u = 1; u <= int.Parse(indexlist[i].Substring(8,1)); u++)
                            {
                                if (rotor-u<0) {} else if(turns[rotor-u,1]=='D') SmallCountD++; else if (turns[rotor-u,1]=='C') SmallCountC++;
                            }

                            if (SmallCountD>SmallCountC && Convert.ToChar(indexlist[i].Substring(10,1))=='D')
                            {
                                string input = indexlist[i].Substring(12);
                                turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                                x= GetCharToAdd(input,x).x;
                            }

                            if (SmallCountD<SmallCountC && Convert.ToChar(indexlist[i].Substring(10,1))=='C')
                            {
                                string input = indexlist[i].Substring(12);
                                turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                                x= GetCharToAdd(input,x).x;
                            }
                        }
                    }

                    ///P2 "ME WIN" Rule
                    if (Array.FindIndex(PL2_strat, s => s.StartsWith("ME WIN", StringComparison.OrdinalIgnoreCase))>0
                    && CalculateResults(turns)==2)
                    {
                    string input = PL2_strat[Array.FindIndex(PL2_strat, s => s.StartsWith("ME WIN", StringComparison.OrdinalIgnoreCase))].Substring(7);
                    turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ///P2 "OPP WIN" Rule
                    if (Array.FindIndex(PL2_strat, s => s.StartsWith("OPP WIN", StringComparison.OrdinalIgnoreCase))>0
                    && CalculateResults(turns)==1)
                    {
                    string input = PL2_strat[Array.FindIndex(PL2_strat, s => s.StartsWith("OPP WIN", StringComparison.OrdinalIgnoreCase))].Substring(8);
                    turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ///P2 "ME MAX D" Rule
                    if (Array.FindIndex(PL2_strat, s => s.StartsWith("ME MAX D", StringComparison.OrdinalIgnoreCase))>0
                    && CountD2>CountC2)
                    {
                    string input = PL2_strat[Array.FindIndex(PL2_strat, s => s.StartsWith("ME MAX D", StringComparison.OrdinalIgnoreCase))].Substring(9);
                    turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ///P2 "ME MAX C" Rule
                    if (Array.FindIndex(PL2_strat, s => s.StartsWith("ME MAX C", StringComparison.OrdinalIgnoreCase))>0
                    && CountD2<CountC2)
                    {
                    string input = PL2_strat[Array.FindIndex(PL2_strat, s => s.StartsWith("ME MAX C", StringComparison.OrdinalIgnoreCase))].Substring(9);
                    turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ///P2 "OPP MAX D" Rule
                    if (Array.FindIndex(PL2_strat, s => s.StartsWith("OPP MAX D", StringComparison.OrdinalIgnoreCase))>0
                    && CountD1>CountC1)
                    {
                    string input = PL2_strat[Array.FindIndex(PL2_strat, s => s.StartsWith("OPP MAX D", StringComparison.OrdinalIgnoreCase))].Substring(10);
                    turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    ///P2 "OPP MAX C" Rule
                    if (Array.FindIndex(PL2_strat, s => s.StartsWith("OPP MAX C", StringComparison.OrdinalIgnoreCase))>0
                    && CountD1<CountC1)
                    {
                    string input = PL2_strat[Array.FindIndex(PL2_strat, s => s.StartsWith("OPP MAX C", StringComparison.OrdinalIgnoreCase))].Substring(10);
                    turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                    x= GetCharToAdd(input,x).x;
                    }

                    //// Check if value for this turn has been added, if no, go to * strategies\\
                    //// P1 
                    if (!turns[rotor,0].HasValue)
                    {   
                        string input = PL1_strat[Array.FindIndex(PL1_strat, s => s.StartsWith("*", StringComparison.OrdinalIgnoreCase))].Substring(2);
                        turns[rotor,0]= GetCharToAdd(input,x).RetChar;
                        x= GetCharToAdd(input,x).x;
                    }

                    //// P2
                    if (!turns[rotor,1].HasValue)
                    {   
                        string input = PL2_strat[Array.FindIndex(PL2_strat, s => s.StartsWith("*", StringComparison.OrdinalIgnoreCase))].Substring(2);
                        turns[rotor,1]= GetCharToAdd(input,x).RetChar;
                        x= GetCharToAdd(input,x).x;
                    }   
                }

                if (turns[rotor,0].Equals('C')){CountC1+=1;}
                if (turns[rotor,0].Equals('D')){CountD1+=1;}
                if (turns[rotor,1].Equals('C')){CountC2+=1;}
                if (turns[rotor,1].Equals('D')){CountD2+=1;} 
                rotor+=1;
        }

        ///// Display results
        if (CalculateResults(turns) == 1)
        Console.WriteLine(AI1);
        else if (CalculateResults(turns) == 2)
        Console.WriteLine(AI2);
        else if (CalculateResults(turns) ==0)
        Console.WriteLine("DRAW");
    }

/////Used to convert X to binary and assing turn value 
public static string GetRandString(int x)
{    
    string ReturnString = Convert.ToString(x,2);
    int ResNum = ReturnString.Count(f => (f == '1'));

    if (ResNum % 2 == 0)
    ReturnString = "D";
    else
    ReturnString = "C";
    
    return ReturnString;
}

/////Used to Calculate score of both players and return ID of winner.
public static int CalculateResults(char?[,] turns)
{       
    int ResultFirst =0;
    int ResultSecond =0;
    int Winner;
    for (int i = 0; i<turns.GetLength(0); i++)
    {
        if (turns[i,0]==turns[i,1])
            {
                if (turns[i,0]=='C')
                    {
                        ResultFirst += 2;
                        ResultSecond += 2;
                    }
                else
                    {
                        ResultFirst += 1;
                        ResultSecond += 1;
                    }
            }

        else if(turns[i,0]=='C' && turns[i,1]=='D')
        ResultSecond += 3;
        
        else if(turns[i,0]=='D' && turns[i,1]=='C')
        ResultFirst += 3;
    }

    if (ResultFirst>ResultSecond)
    Winner = 1;

    else if (ResultFirst<ResultSecond)
    Winner = 2;

    else
    Winner = 0;
    
return Winner;
} 

public static (char RetChar, int x) GetCharToAdd(string tt, int x)
{
    char RetChar;
    //// If C or D passed convert and pass back
    if (tt.Length<2)
    RetChar = Convert.ToChar(tt);

    //// If Rand passed then GetRandString()
    else 
    {
        x = ((137*x)+187)%256;
        RetChar= Convert.ToChar(GetRandString(x));
    }
    return (RetChar, x);
}
}
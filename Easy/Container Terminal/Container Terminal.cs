using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<char> stacks = new List<char>();
        for (int i = 0; i < N; i++)
        {               
            stacks.Clear();                                     /// Clear List at the start
            string line = Console.ReadLine();                   /// Read incoming containers
            stacks.Add(line[0]);                                /// Add first character (container) to List
            for (int u = 1; u<line.Length; u++)                 /// To through each character (container) that is left 
            {
                for (int l = 0; l<stacks.Count; l++)            /// Compare each char to list members
                {
                    if (line[u]<=stacks[l])                     /// if char is "smaller" (first in abc) update list member
                    {
                    stacks[l] = line[u];
                    break;
                    }
                    if (line[u]>stacks[l] && l == stacks.Count-1)
                    {
                    stacks.Add(line[u]);                        /// if there are no list members that are larger than char
                    break;                                      /// create new list member
                    }
                }
            }
        Console.WriteLine(stacks.Count);                        /// Count and return list member count
        }
    }
}
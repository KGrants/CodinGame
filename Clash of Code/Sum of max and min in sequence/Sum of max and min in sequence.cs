using System;using System.Linq;using System.Collections.Generic;
class Solution{
static void Main(string[] args){int n = int.Parse(Console.ReadLine());
string[] inputs = Console.ReadLine().Split(' ');var l = new List<int>();
for (int i = 0; i < n; i++){l.Add(int.Parse(inputs[i]));}Console.WriteLine(l.Max() + l.Min());}}
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
        TelTree tree = new TelTree();
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string telephone = Console.ReadLine();
            tree.AddPhoneNumber(telephone.ToCharArray());
        }
        Console.WriteLine(tree.Count());
    }
}

class TelTree
{
    private char data;
    private LinkedList<TelTree> children;

    public TelTree(char data)
    {
        this.data = data;
        children = new LinkedList<TelTree>();
    }
    
    public TelTree()
    {
        children = new LinkedList<TelTree>();
    }

    public void AddPhoneNumber(char[] telephone) {
        var firstChar = telephone[0];
        var leftchars = telephone.Length > 1 ? telephone.Skip(1).ToArray() : new char[0];
            var child = GetChild(firstChar);
            if(child == null){
                child = AddChild(firstChar);
            }
            
            if(telephone.Length > 0 && leftchars.Length > 0){
                child.AddPhoneNumber(leftchars);
            }
    }
    public TelTree AddChild(char data)
    {
        var tree = new TelTree(data);
        children.AddFirst(tree);
        return tree;
    }

    public TelTree GetChild(char i)
    {
        return children.FirstOrDefault(x => x.data == i);;
    }
    public long Count(){         
        return children.Count + children.Sum(x => x.Count());
    }
}
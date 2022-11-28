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
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        Dictionary<string, string> mimeTypes = new Dictionary<string, string>();

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string EXT = inputs[0]; // file extension
            string MT = inputs[1]; // MIME type.
            mimeTypes.Add("." + EXT.ToLower(), MT);
        }

        for (int i = 0; i < Q; i++)
        {
            string FNAME = Console.ReadLine();
            string FEXT = Path.GetExtension(FNAME).ToLower();

            if (mimeTypes.ContainsKey(FEXT))
            Console.WriteLine(mimeTypes[FEXT]);
            else
            Console.WriteLine("UNKNOWN");
        }
    }
};
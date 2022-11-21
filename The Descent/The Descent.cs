using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


class Player
{
    static void Main(string[] args)
    {
        while (true)
        {
            int HMIndex = BombMountain();
            Console.WriteLine(HMIndex);
        }        
    }

    public static int BombMountain()
    {
        int HMIndex = -1;
        int HignMountain =0;
        for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                if (mountainH > HignMountain)
                {
                    HignMountain = mountainH;
                    HMIndex = i;
                }  
            }
            return HMIndex;
    }
}

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;


class Solution
{
    static void Main(string[] args)
    {
        
        string[] inputs;
        int N = int.Parse(Console.ReadLine());
        Point[] cornerXY = new Point[N];

        for (int i = 0; i < N; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            cornerXY[i] = new Point(x,y);
        }

        int M = int.Parse(Console.ReadLine());
        for (int i = 0; i < M; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);

            if (PointInPolygon(cornerXY, x, y))
            {
                Console.WriteLine("hit");
            }
            else
            {
                Console.WriteLine("miss");
            }
        }
    }

    private static bool PointInPolygon(Point[] polygon, double px, double py)
    {
        bool check = false;
        
        for (int i = 0; i < polygon.Length; i++) 
        {
            Point vc = polygon[i];
            Point vn = polygon[(i + 1) % polygon.Length];
            
            bool btv = (vc.Y > py) != (vn.Y > py);
            bool jct = px < (vn.X - vc.X) * (py - vc.Y) / (vn.Y - vc.Y) + vc.X;
    
            if (btv && jct)
            {
                check = !check;
            }
        }
        
        return check;
    }
}
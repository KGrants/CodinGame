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
        string[] inputs;

        // game loop
        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            Dictionary <int, int[]> humans = new Dictionary<int, int[]>();
            Dictionary <int, int[]> zombies = new Dictionary<int, int[]>();
            Dictionary <int, int[]> zombies_next = new Dictionary<int, int[]>();

            int humanCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < humanCount; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                humans.Add(i, new int[] {int.Parse(inputs[1]),int.Parse(inputs[2])});
            }

            int zombieCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < zombieCount; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                zombies.Add(i, new int[] {int.Parse(inputs[1]), int.Parse(inputs[2])});
                zombies_next.Add(i, new int[] {int.Parse(inputs[3]), int.Parse(inputs[4])});
            }

            int xx = 0;
            int yy = 0;
            int min = int.MaxValue;

            
            for (int i = zombieCount-1; i>=0; i--)
            {
                for ( int u = humanCount-1; u >=0; u--)
                {

                    if (humanCount==1)
                    {
                        xx=humans[0][0];
                        yy=humans[0][1];
                        break;                   
                    }

                    if (Math.Abs(humans[u][0]-zombies[i][0])+Math.Abs(humans[u][1]-zombies[i][1])<min
                    && (((((decimal)Math.Abs(x-humans[u][0])+Math.Abs(y-humans[u][1]))-2000)/1000))
                    <=
                    (((((decimal)Math.Abs(zombies[i][0]-humans[u][0])+Math.Abs(zombies[i][1]-humans[u][1])))/400)))
                    {
                        min = Math.Abs(humans[u][0]-zombies[i][0])+Math.Abs(humans[u][1]-zombies[i][1]);
                        xx=humans[u][0];
                        yy=humans[u][1];
                        break;
                    }

                    if (xx==0 && yy==0)
                    {
                        xx=humans[u][0];
                        yy=humans[u][1];
                    }




                }
            }
            Console.WriteLine($"{xx} {yy}");
        }
        
    }
}
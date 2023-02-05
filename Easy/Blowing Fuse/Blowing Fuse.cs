using System;

class Solution
{
    static void Main(string[] args)
    {
        Func<int[]> getinput = () => Array.ConvertAll(Console.ReadLine().Trim().Split(' '),Convert.ToInt32);;
        int [] inputs   = getinput();
        int n           = inputs[0];
        int m           = inputs[1];
        int c           = inputs[2];
        int power       = 0;
        int max_power   = 0;

        //Read and create an array of Appliances
        inputs = getinput();
        Appliance[] app_list = new Appliance[n];
        for (int i = 0; i < n; i++)
            app_list[i] = new Appliance(inputs[i], false);

        //Read and press power buttons
        inputs = getinput();
        for (int i = 0; i < m; i++)
        {
            Appliance x = app_list[inputs[i]-1];
            power += x.turned_on_ind == false ?  x.power : -x.power;
            app_list[inputs[i]-1].turned_on_ind = x.turned_on_ind == false ? true : false;
            max_power = power > max_power ? power : max_power;

            if(max_power>c)
            {
                Console.WriteLine("Fuse was blown.");
                System.Environment.Exit(0);  
            }
        }
        Console.WriteLine($"Fuse was not blown.");
        Console.WriteLine($"Maximal consumed current was {max_power} A.");
    }

    class Appliance
    {   
        public int power {get; set;}
        public bool turned_on_ind {get; set;}

        public Appliance(int pow, bool turned_on)
        {
            power = pow;
            turned_on_ind = turned_on;
        }
    }
}
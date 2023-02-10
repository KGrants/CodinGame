using System;

class Player
{
    static void Main(string[] args)
    {
        int catSpeed = int.Parse(Console.ReadLine());
        double mouse_speed = 10.0;
        double radius = 500.0;
        double pi = Math.PI;
        double circumference = 2.0 * radius * pi;
        double cat_speed = catSpeed / circumference;
        circumference = mouse_speed / cat_speed;
        double radius_mouse = circumference / 2.0 / pi;
        double ratio = (radius_mouse - 5.0) / radius;
        bool escaping = false;
        double dist_to_escape = 0.0;

        while (true)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int mouseX = int.Parse(inputs[0]);
            int mouseY = int.Parse(inputs[1]);
            int catX = int.Parse(inputs[2]);
            int catY = int.Parse(inputs[3]);
            double point_x = Math.Floor((-catX * ratio));
            double point_y = Math.Floor((-catY * ratio));

            if (escaping)
                Console.WriteLine($"{(int)Math.Ceiling(mouseX * 2.0)} {Math.Ceiling(mouseY * 2.0)}");
            else
                Console.WriteLine($"{point_x} {point_y}");

            dist_to_escape = Math.Sqrt(Math.Pow((point_x - mouseX),2) + Math.Pow((point_y - mouseY),2));
            
            if (ratio < 0.5)
            {
                if (dist_to_escape < 10.0)
                    escaping = true;
            }
            else
            {
                if (dist_to_escape < 80.0)
                    escaping = true;
            }
        }
    }
}
using System;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int nbFloors = int.Parse(inputs[0]); // number of floors
        int width = int.Parse(inputs[1]); // width of the area
        int nbRounds = int.Parse(inputs[2]); // maximum number of rounds
        int exitFloor = int.Parse(inputs[3]); // floor on which the exit is found
        int exitPos = int.Parse(inputs[4]); // position of the exit on its floor
        int nbTotalClones = int.Parse(inputs[5]); // number of generated clones
        int nbAdditionalElevators = int.Parse(inputs[6]); // ignore (always zero)
        int nbElevators = int.Parse(inputs[7]); // number of elevators
        int[] elevatorPos = new int[nbFloors];

        for (int i = 0; i < nbElevators; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int elevatorFloor = int.Parse(inputs[0]); // floor on which this elevator is found
            elevatorPos[elevatorFloor] = int.Parse(inputs[1]); // position of the elevator on its floor
        }
        elevatorPos[exitFloor] = exitPos; // Adding exit position as the last floor's elevator

        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int cloneFloor = int.Parse(inputs[0]); // floor of the leading clone
            int clonePos = int.Parse(inputs[1]); // position of the leading clone on its floor
            string direction = inputs[2]; // direction of the leading clone: LEFT or RIGHT
            string answer = "WAIT";

            if (ShouldWeBlock(cloneFloor,clonePos,direction,elevatorPos))
            answer = "BLOCK";

            Console.WriteLine(answer);    
        }
    }

static bool ShouldWeBlock(int cloneFloor, int clonePos, string direction, int[] elevatorPosition)
    {
        if (cloneFloor == -1)
            return false;

        int elevator = elevatorPosition[cloneFloor];
        if (clonePos == elevator)
            return false;

        if (clonePos < elevator)
        {
            if (direction == "RIGHT")
                return false;
            else
                return true;
        }

        if (clonePos > elevator)
        {
            if (direction == "RIGHT")
                return true;
            else
                return false;
        }
            return false;
    }
}
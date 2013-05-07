using System;

class IfPointsAreInCircle
{
    static void Main()
    {
        Console.WriteLine("Please enter 'x' coordinates!");
        int xCoordinate = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter 'y' coordinates!");
        int yCoordinate = int.Parse(Console.ReadLine());
        bool check = (xCoordinate * xCoordinate) + (yCoordinate * yCoordinate) < 5 * 5;
        Console.WriteLine("The point is in the circle - {0}", check);
    }
}


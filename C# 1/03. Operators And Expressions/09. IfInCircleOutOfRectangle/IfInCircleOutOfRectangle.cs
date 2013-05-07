using System;

class IfInCircleOutOfRectangle
{
    static void Main()
    {
        Console.WriteLine("Please enter 'x' coordinates!");
        int xCoordinate = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter 'y' coordinates!");
        int yCoordinate = int.Parse(Console.ReadLine());
        bool checkCircle = ((xCoordinate-1) * (xCoordinate-1)) + ((yCoordinate-1) * (yCoordinate-1)) < 3*3;
        bool checkRectangle = ((1<xCoordinate)&(xCoordinate<7)&(-1>yCoordinate)&(yCoordinate>-3));
        bool finalCheck = checkCircle==true & checkRectangle==false;
        Console.WriteLine("The point is in the circle and out of the rectangle - {0}", finalCheck);
    }
}


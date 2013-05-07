using System;

class PrintPerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Please enter radius of a circle!");
        double radius = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double perimeter = 2 * pi * radius;
        double area = pi * radius * radius;
        Console.WriteLine("The perimeter of the circle is {0} and the area is {1}", perimeter, area);
    }
}


using System;

class TrapezoidsArea
{
    static void Main()
    {
        Console.WriteLine("Please enter trapezoid's side a, side b and height h:");
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = 0.5 * (sideA + sideB) * height;
        Console.WriteLine("The area of the trapezoid is {0}", area);
    }
}


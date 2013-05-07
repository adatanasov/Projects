using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle width as integer, please!");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter rectangle height as integer, please!");
        int height = int.Parse(Console.ReadLine());
        int area = width * height;
        Console.WriteLine("The rectangle's area is {0}", area);
    }
}


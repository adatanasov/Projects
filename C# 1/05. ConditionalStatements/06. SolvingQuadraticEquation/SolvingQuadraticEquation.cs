using System;

class SolvingQuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Please enter the coefficients \"a\", \"b\" and \"c\" of the quadratic equation" +
            " \"a*x2 + b*x + c = 0\"");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = (b * b) - 4 * a * c;
        double resultOne = 0;
        double resultTwo = 0;
        if (a == 0)
        {
            Console.WriteLine("No solution!");
        }
        else if (d < 0)
        {
            Console.WriteLine("No real roots!");
        }
        else if (d == 0)
        {
            resultOne = -(b / (2 * a));
            Console.WriteLine("There is one real root: {0}!", resultOne);
        }
        else
        {
            resultOne = (-b + Math.Sqrt(d)) / (2 * a);
            resultTwo = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("The real root are {0} and {1}", resultOne, resultTwo);
        }
    }
}


using System;

class CalculateSumOfIntegers
{
    static void Main()
    {
        Console.WriteLine("Please enter integer numbers N and X!");
        double n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double s = 1;
        double factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j > 0; j--)
            {
                factorial *= j;
            }
            s = s + (factorial / Math.Pow(x, i));
            factorial = 1;
        }
        Console.WriteLine("S = {0}", s);
    }
}


using System;

class PrintGreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter two numbers!");
        int numA = int.Parse(Console.ReadLine());
        int numB = int.Parse(Console.ReadLine());
        int result = numA > numB ? numA : numB;
        Console.WriteLine(result);
    }
}


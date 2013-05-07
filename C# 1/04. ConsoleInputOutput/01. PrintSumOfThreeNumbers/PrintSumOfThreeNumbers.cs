using System;

class PrintSumOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter three integer numbers!");
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());
        int numThree = int.Parse(Console.ReadLine());
        int sum = numOne + numTwo + numThree;
        Console.WriteLine("The sum of the three numbers is {0}", sum);
    }
}


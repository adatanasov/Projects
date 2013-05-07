using System;

class ExchangeValues
{
    static void Main()
    {
        Console.WriteLine("Please enter two integer numbers!");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = 0;
        if (firstNumber > secondNumber)
        {
            thirdNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = thirdNumber;
            Console.WriteLine("Exchanged values: first number: {0} and second number: {1}!", firstNumber, secondNumber);
        }
    }
}


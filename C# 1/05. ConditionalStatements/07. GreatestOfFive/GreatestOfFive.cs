using System;

class GreatestOfFive
{
    static void Main()
    {
        Console.WriteLine("Please enter five numbers!");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        double fourthNumber = double.Parse(Console.ReadLine());
        double fifthNumber = double.Parse(Console.ReadLine());
        double greatestNumber = 0;
        if (firstNumber >= secondNumber && firstNumber >= thirdNumber && firstNumber >= fourthNumber && 
            firstNumber >= fifthNumber)
        {
            greatestNumber = firstNumber;
        }
        else if (secondNumber >= firstNumber && secondNumber >= thirdNumber && secondNumber >= fourthNumber &&
            secondNumber >= fifthNumber)
        {
            greatestNumber = secondNumber;
        }
        else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber && thirdNumber >= fourthNumber &&
            thirdNumber >= fifthNumber)
        {
            greatestNumber = thirdNumber;
        }
        else if (fourthNumber >= firstNumber && fourthNumber >= secondNumber && fourthNumber >= thirdNumber &&
            fourthNumber >= fifthNumber)
        {
            greatestNumber = fourthNumber;
        }
        else
        {
            greatestNumber = fifthNumber;
        }
        Console.WriteLine("The greatest number is {0}", greatestNumber);
    }
}


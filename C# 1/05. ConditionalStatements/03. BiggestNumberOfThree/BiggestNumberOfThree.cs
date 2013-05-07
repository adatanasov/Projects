using System;

class BiggestNumberOfThree
{
    static void Main()
    {
        Console.WriteLine("Please enter three integer numbers!");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int biggestNumber = 0;
        if (firstNumber >= secondNumber)
        {
            if (firstNumber >= thirdNumber)
            {
                biggestNumber = firstNumber;
            }
            else
            {
                biggestNumber = thirdNumber;
            }
        }
        else if (secondNumber >= thirdNumber)
        {
            biggestNumber = secondNumber;
        }
        else
        {
            biggestNumber = thirdNumber;
        }
        Console.WriteLine("Biggest number is {0}", biggestNumber);
    }
}


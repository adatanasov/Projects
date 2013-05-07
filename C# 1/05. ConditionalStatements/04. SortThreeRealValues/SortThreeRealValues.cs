using System;

class SortThreeRealValues
{
    static void Main()
   {
        Console.WriteLine("Please enter three real numbers!");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        if (firstNumber >= secondNumber)
        {
            if (secondNumber >= thirdNumber)
            {
                Console.WriteLine("{0}, {1}, {2}...", firstNumber, secondNumber, thirdNumber);
            }
            else if (firstNumber >= thirdNumber)
            {
                Console.WriteLine("{0}, {1}, {2}...", firstNumber, thirdNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}...", thirdNumber, firstNumber, secondNumber);
            }
        }
        else if (firstNumber >= thirdNumber)
        {
            Console.WriteLine("{0}, {1}, {2}...", secondNumber, firstNumber, thirdNumber);
        }
        else if (secondNumber >= thirdNumber)
        {
            Console.WriteLine("{0}, {1}, {2}...", secondNumber, thirdNumber, firstNumber);
        }
        else
        {
            Console.WriteLine("{0}, {1}, {2}...", thirdNumber, secondNumber, firstNumber);
        }
    }
}

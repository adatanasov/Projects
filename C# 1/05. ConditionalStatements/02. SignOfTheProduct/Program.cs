using System;

class SignOfTheProduct
{
    static void Main()
    {
        Console.WriteLine("Please enter three real numbers!");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The Product is 0 - no sign!");
        }
        else if (firstNumber > 0)
        {
            if (secondNumber > 0)
            {
                if (thirdNumber > 0)
                {
                    Console.WriteLine("The sign of the product is +");
                }
                else
                {
                    Console.WriteLine("The sign of the product is -");
                }
            }
            else
            {
                if (thirdNumber > 0)
                {
                    Console.WriteLine("The sign of the product is -");
                }
                else
                {
                    Console.WriteLine("The sign of the product is +");
                }
            }
        }
        else
        {
            if (secondNumber > 0)
            {
                if (thirdNumber > 0)
                {
                    Console.WriteLine("The sign of the product is -");
                }
                else
                {
                    Console.WriteLine("The sign of the product is +");
                }
            }
            else
            {
                if (thirdNumber > 0)
                {
                    Console.WriteLine("The sign of the product is +");
                }
                else
                {
                    Console.WriteLine("The sign of the product is -");
                }
            }
        }
    }
}


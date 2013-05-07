using System;

class IfThirdDigitIsSeven
{
    static void Main()
    {
        Console.WriteLine("Please, enter at least three digit integer!");
        int number = int.Parse(Console.ReadLine());
        if ((number/100) % 10 == 7)
            Console.WriteLine("The third digit is 7!");
        else
            Console.WriteLine("The third digit is NOT 7...");
    }
}


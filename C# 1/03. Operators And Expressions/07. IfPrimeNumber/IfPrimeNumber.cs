using System;

class IfPrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter positive integer less or equal to 100!");
        int number = int.Parse(Console.ReadLine());
        bool check = ((number == 1) | (number % 2 == 0) | (number % 3 == 0) | (number % 5 == 0) | (number % 7 == 0));
        if (check)
            Console.WriteLine("{0} is not prime...", number);
        else
            Console.WriteLine("{0} is prime!", number);
    }
}


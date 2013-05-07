using System;


class DivisionByFiveAndSeven
{
    static void Main()
    {
        Console.WriteLine("Enter an integer, please!");
        int number = int.Parse(Console.ReadLine());
        bool check = ((number % 5 == 0) && (number % 7 == 0));
        Console.WriteLine("This integer can divide without remainder by 5 and 7 - {0}", check);
    }
}


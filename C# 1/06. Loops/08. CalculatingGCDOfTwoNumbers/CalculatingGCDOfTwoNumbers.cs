using System;

class CalculatingGCDOfTwoNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter two different integer numbers!");
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int biggerNumber, smallerNumber;
        if (n < m)
        {
            smallerNumber = n;
            biggerNumber = m;
        }
        else
        {
            smallerNumber = m;
            biggerNumber = n;
        }
        int difference = biggerNumber - smallerNumber;
        while (difference != smallerNumber)
        {
            if (difference < smallerNumber)
            {
                biggerNumber = difference;
                difference = smallerNumber;
                smallerNumber = biggerNumber;
            }
            difference -= smallerNumber;
        }
        Console.WriteLine("The GCD of {0} and {1} is {2}!",n ,m , difference);
    }
}


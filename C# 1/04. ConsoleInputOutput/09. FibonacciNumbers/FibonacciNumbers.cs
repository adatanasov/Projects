using System;

class FibonacciNumbers
{
    static void Main()
    {
        decimal a = 0M;
        decimal b = 1M;
        decimal c = 0M;
        Console.WriteLine("1 - {0,25}", a);
        Console.WriteLine("2 - {0,25}", b);
        for (int i = 3; i <= 100; i++)
        {
            c = a + b;
            Console.WriteLine("{0} - {1,25}", i, c);
            a = b;
            b = c;
        }
    }
}


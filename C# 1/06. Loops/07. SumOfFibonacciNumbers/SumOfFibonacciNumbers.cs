using System;

class SumOfFibonacciNumbers
{
    static void Main()
    {
        Console.Write("Please enter number of members N= ");
        int n = int.Parse(Console.ReadLine());
        decimal a = 0M;
        decimal b = 1M;
        decimal c = 0M;
        decimal sumOfMembers = 1M;
        Console.Write("{0}, ", a);
        Console.Write("{0}, ", b);
        for (int i = 3; i <= n; i++)
        {
            c = a + b;
            sumOfMembers += c;
            Console.Write("{0}, ", c);
            a = b;
            b = c;
        }
        Console.WriteLine("The sum of the first {0} members is {1}!", n, sumOfMembers);
    }
}


using System;
using System.Numerics;

class CalculateFactorialOfNDividedByFactorialOfK
{
    static void Main()
    {
        Console.WriteLine("Please enter N and K (N>K>1)!");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger result = 1;
        for (int i = n; i > k; i--)
        {
            result *= i;
        }
        Console.WriteLine("N! / K! = {0}", result);
    }
}


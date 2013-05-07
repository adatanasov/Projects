using System;
using System.Numerics;

class CalatanNumbers
{
    static void Main()
    {
        Console.Write("Please enter number n = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger lowerResult = 1;
        BigInteger upperResult = 1;
        BigInteger result = 1;
        for (int i = 2 * n; i > n + 1; i--) // We calculate (2n)! / (n+1)! = 2n * (2n -1) * ... * n + 2
        {
            upperResult *= i;
        }
        for (int j = n; j > 0; j--)
        {
            lowerResult *= j;
        }
        result = upperResult / lowerResult;
        Console.WriteLine("(2n)! / (n+1)!n! for n = {0} is {1}", n, result);
    }
}


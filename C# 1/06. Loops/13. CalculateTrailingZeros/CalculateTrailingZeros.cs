using System;
using System.Numerics;

class CalculateTrailingZeros
{
    static void Main()
    {
        Console.WriteLine("Please enter number N (N > 1)!");
        int n = int.Parse(Console.ReadLine());
        //BigInteger factorial = 1;
        int zeros = 0;
        int divider = 0;
        //for (int i = 1; i <= n; i++)
        //{
        //    factorial *= i;
        //}
        //Console.WriteLine(factorial);
        for (int i = 1; i < 10000000; i++)
        {
            divider = n / (int)Math.Pow(5, i);
            if (divider < 0)
            {
                break;
            }
            zeros += divider; 
        }
        Console.WriteLine("The number {0}! has {1} trailing zeros.", n, zeros);
    }
}


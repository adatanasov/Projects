using System;
using System.Numerics;

class CalculateFactorials
{
    static void Main()
    {
        Console.WriteLine("Please enter K and N (K>N>1)!");
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger result = 1;
        for (int i = k; i > k - n; i--)
        {
            result *= i;
        }
        for (int j = n; j > 0; j--)
        {
            result *= j;
        }
        Console.WriteLine("N! * K! / (K- N)! = {0}", result);
    }
}


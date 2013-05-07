using System;

class PrintDividendsByFive
{
    static void Main()
    {
        Console.WriteLine("Please enter two positive integers \"a\" and \"b\"! (a<b) ");
        int numA = int.Parse(Console.ReadLine());
        int numB = int.Parse(Console.ReadLine());
        int p = 0;
        for (int i = numA; i <= numB; i++)
        {
            if (i%5==0)
            {
                p++;
            }
        }
        Console.WriteLine("p({0},{1}) = {2}", numA, numB, p);
    }
}


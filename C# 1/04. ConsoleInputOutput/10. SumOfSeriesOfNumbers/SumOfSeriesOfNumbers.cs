using System;

class SumOfSeriesOfNumbers
{
    static void Main()
    {
        decimal result = 1M;
        decimal resultOld = 0M;
        for (decimal i = 2; (double)Math.Abs(result - resultOld) > 0.001; i++)
        {
            if (i % 2 == 0)
            {
                resultOld = result;
                result += (1 / i);
            }
            else
            {
                resultOld = result;
                result -= (1 / i);
            }
        }
        Console.WriteLine("The sum of all numbers is {0}", result);
    }
}


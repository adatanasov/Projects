using System;

class MinAndMaxOfSequence
{
    static void Main()
    {
        Console.Write("Please enter the number of members = ");
        int n = int.Parse(Console.ReadLine());
        int min = 2147483647;
        int max = -2147483648;
        for (int i = 0; i < n; i++)
        {
            int m = int.Parse(Console.ReadLine());
            if (m > max) 
            {
                max = m;
            }
            if (m < min)
            {
                min = m;
            }
        }
        Console.WriteLine("The minimal number is {0} and the maximum number is {1}.", min, max);
    }
}


using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter number of addends!");
        int n = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Please enter number {0} :",i);
            int j = int.Parse(Console.ReadLine());
            result += j;
        }
        Console.WriteLine("The sum of all numbers is {0}", result);
    }
}


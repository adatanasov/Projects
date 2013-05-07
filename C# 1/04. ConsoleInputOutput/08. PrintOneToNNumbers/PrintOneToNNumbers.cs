using System;

class PrintOneToNNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer number \"n\"!");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}


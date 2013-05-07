using System;

class ExtractBitValue
{
    static void Main()
    {
        Console.WriteLine("Enter integer, please!");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit number, please!");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int result = (i & mask) >> b;
        Console.WriteLine(result);
    }
}


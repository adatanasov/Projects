using System;

class ExchangeBits
{
    static void Main()
    {
        Console.WriteLine("Enter unsigned integer, please!");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter starting bit of the first group for exchange!");
        int startFirst = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter starting bit of the second group for exchange!");
        int startSecond = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number ot bits for exchange for each group!");
        int count = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        int firstMask = (int)(number) >> (startFirst);
        int mask = (int)Math.Pow(2, count) -1;
        firstMask = firstMask & mask;
        Console.WriteLine(Convert.ToString(firstMask, 2).PadLeft(32, '0'));
        int secondMask = (int)(number) >> (startSecond);
        secondMask = secondMask & mask;
        Console.WriteLine(Convert.ToString(secondMask, 2).PadLeft(32, '0'));
        mask <<= startFirst;
        number &= (uint)~mask;
        mask <<= startSecond-startFirst;
        number &= (uint)~mask;
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        number = number | (uint)(secondMask << startFirst) | (uint)(firstMask << startSecond);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}


using System;

class ExchengeThreeBits
{
    static void Main()
    {
        Console.WriteLine("Enter unsigned integer, please!");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        uint bitThree = (1 << 3) & n;
        uint bitFour = (1 << 4) & n;
        uint bitFive = (1 << 5) & n;
        uint bitTwentyFour = (1 << 24) & n;
        uint bitTwentyFive = (1 << 25) & n;
        uint bitTwentySix = (1 << 26) & n;
        if (bitThree == 0)
            n = (uint)(~(1 << 24) & n);
        else
            n = (1 << 24) | n;
        if (bitFour == 0)
            n = (uint)(~(1 << 25) & n);
        else
            n = (1 << 25) | n;
        if (bitFive == 0)
            n = (uint)(~(1 << 26) & n);
        else
            n = (1 << 26) | n;
        if (bitTwentyFour == 0)
            n = (uint)(~(1 << 3) & n);
        else
            n = (1 << 3) | n;
        if (bitTwentyFive == 0)
            n = (uint)(~(1 << 4) & n);
        else
            n = (1 << 4) | n;
        if (bitTwentySix == 0)
            n = (uint)(~(1 << 5) & n);
        else
            n = (1 << 5) | n;
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
    }
}


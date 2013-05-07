using System;

class OddOrEvenNumber
{
static void Main()
{
    Console.WriteLine("Enter an integer, please!");
    int number = int.Parse(Console.ReadLine());
    if (number % 2==0)
      Console.WriteLine("Input integer is even!");
    else
      Console.WriteLine("Input integer is odd!");
}
}




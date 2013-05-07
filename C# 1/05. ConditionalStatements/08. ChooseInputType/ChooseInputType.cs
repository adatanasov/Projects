using System;

class ChooseInputType
{
    static void Main()
    {
        Console.WriteLine("Choose input type, please! Enter \"1\" for \"int\", \"2\" for \"double\"" +
        " and \"3\" for \"string\"!");
        byte inputType = byte.Parse(Console.ReadLine());
        switch (inputType)
        {
            case 1: 
                Console.WriteLine("Enter integer value, please!");
                int inputInt = int.Parse(Console.ReadLine());
                inputInt++;
                Console.WriteLine(inputInt);
                break;
            case 2:
                Console.WriteLine("Enter double value, please!");
                double inputDouble = double.Parse(Console.ReadLine());
                inputDouble++;
                Console.WriteLine(inputDouble);
                break;
            case 3:
                Console.WriteLine("Enter string value, please!");
                string inputString = Console.ReadLine();
                inputString = inputString + "*";
                Console.WriteLine(inputString);
                break;
            default:
                Console.WriteLine("Wrong input!");
                break;
        }
    }
}


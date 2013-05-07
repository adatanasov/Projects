using System;

class NumberPronunciation
{
    static void LastDigit(int lastDigit)
    {
        switch (lastDigit)
        {
            case 9: Console.WriteLine("nine"); break;
            case 8: Console.WriteLine("eight"); break;
            case 7: Console.WriteLine("seven"); break;
            case 6: Console.WriteLine("six"); break;
            case 5: Console.WriteLine("five"); break;
            case 4: Console.WriteLine("four"); break;
            case 3: Console.WriteLine("three"); break;
            case 2: Console.WriteLine("two"); break;
            case 1: Console.WriteLine("one"); break;
            case 0: break;
        }
    }

    static void Teens(int lastDigit)
    {
        switch (lastDigit)
        {
            case 9: Console.WriteLine("nineteen"); break;
            case 8: Console.WriteLine("eighteen"); break;
            case 7: Console.WriteLine("seventeen"); break;
            case 6: Console.WriteLine("sixteen"); break;
            case 5: Console.WriteLine("fifteen"); break;
            case 4: Console.WriteLine("fourteen"); break;
            case 3: Console.WriteLine("thirteen"); break;
            case 2: Console.WriteLine("twelve"); break;
            case 1: Console.WriteLine("eleven"); break;
            case 0: Console.WriteLine("ten"); break;
        }
    }

    static void Ands(int lastDigit)
    {
        switch (lastDigit)
        {
            case 9: Console.WriteLine("and nine"); break;
            case 8: Console.WriteLine("and eight"); break;
            case 7: Console.WriteLine("and seven"); break;
            case 6: Console.WriteLine("and six"); break;
            case 5: Console.WriteLine("and five"); break;
            case 4: Console.WriteLine("and four"); break;
            case 3: Console.WriteLine("and three"); break;
            case 2: Console.WriteLine("and two"); break;
            case 1: Console.WriteLine("and one"); break;
            case 0: break;
        }
    }

    static void SecondDigit(int secondDigit, int lastDigit)
    {
        switch (secondDigit)
        {
            case 9:
                Console.Write("ninety ");
                LastDigit(lastDigit);
                break;
            case 8:
                Console.Write("eighty ");
                LastDigit(lastDigit);
                break;
            case 7:
                Console.Write("seventy ");
                LastDigit(lastDigit);
                break;
            case 6:
                Console.Write("sixty ");
                LastDigit(lastDigit);
                break;
            case 5:
                Console.Write("fifty ");
                LastDigit(lastDigit);
                break;
            case 4:
                Console.Write("forty ");
                LastDigit(lastDigit);
                break;
            case 3:
                Console.Write("thirty ");
                LastDigit(lastDigit);
                break;
            case 2:
                Console.Write("twenty ");
                LastDigit(lastDigit);
                break;
            case 1:
                Teens(lastDigit);
                break;
            case 0:
                Ands(lastDigit);
                break;
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter integer between 0 and 999!");
        int number = int.Parse(Console.ReadLine());
        int firstDigit = number / 100;
        int lastTwoDigits = number % 100;
        int secondDigit = lastTwoDigits / 10;
        int lastDigit = lastTwoDigits % 10;
        switch (firstDigit)
        {
            case 9: 
                Console.Write("Nine hundred "); 
                SecondDigit(secondDigit, lastDigit);
                break;
            case 8: 
                Console.Write("Eight hundred ");
                SecondDigit(secondDigit, lastDigit);
                break;
            case 7: 
                Console.Write("Seven hundred ");
                SecondDigit(secondDigit, lastDigit);
                break;
            case 6: 
                Console.Write("Six hundred ");
                SecondDigit(secondDigit, lastDigit);
                break;
            case 5: 
                Console.Write("Five hundred ");
                SecondDigit(secondDigit, lastDigit);
                break;
            case 4: 
                Console.Write("Four hundred ");
                SecondDigit(secondDigit, lastDigit);
                break;
            case 3: 
                Console.Write("Three hundred ");
                SecondDigit(secondDigit, lastDigit);
                break;
            case 2: 
                Console.Write("Two hundred ");
                SecondDigit(secondDigit, lastDigit);
                break;
            case 1: 
                Console.Write("One hundred ");
                SecondDigit(secondDigit, lastDigit);
                break;
            case 0: 
                switch (secondDigit)
                {
                    case 9:
                        Console.Write("ninety ");
                        LastDigit(lastDigit);
                        break;
                    case 8:
                        Console.Write("eighty ");
                        LastDigit(lastDigit);
                        break;
                    case 7:
                        Console.Write("seventy ");
                        LastDigit(lastDigit);
                        break;
                    case 6:
                        Console.Write("sixty ");
                        LastDigit(lastDigit);
                        break;
                    case 5:
                        Console.Write("fifty ");
                        LastDigit(lastDigit);
                        break;
                    case 4:
                        Console.Write("forty ");
                        LastDigit(lastDigit);
                        break;
                    case 3:
                        Console.Write("thirty ");
                        LastDigit(lastDigit);
                        break;
                    case 2:
                        Console.Write("twenty ");
                        LastDigit(lastDigit);
                        break;
                    case 1:
                        Teens(lastDigit);
                        break;
                    case 0: 
                            switch (lastDigit)
                            {
                                case 9: Console.WriteLine("Nine"); break;
                                case 8: Console.WriteLine("Eight"); break;
                                case 7: Console.WriteLine("Seven"); break;
                                case 6: Console.WriteLine("Six"); break;
                                case 5: Console.WriteLine("Five"); break;
                                case 4: Console.WriteLine("Four"); break;
                                case 3: Console.WriteLine("Three"); break;
                                case 2: Console.WriteLine("Two"); break;
                                case 1: Console.WriteLine("One"); break;
                                case 0: Console.WriteLine("Zero"); break;
                            }
                            break; 
                }
                break;
        }
    }
}


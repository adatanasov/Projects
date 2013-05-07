namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0)
            {
                throw new ArgumentOutOfRangeException("Side 'a' must be positive!");
            }

            if (b <= 0)
            {
                throw new ArgumentOutOfRangeException("Side 'b' must be positive!");
            }

            if (c <= 0)
            {
                throw new ArgumentOutOfRangeException("Side 'c' must be positive!");
            }

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            return area;
        }

        public static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "Negative or non one-digit number!";
            }            
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("Elements can't be null or empty!");
            }

            int maxValue = int.MinValue;
            for (int index = 0; index < elements.Length; index++)
            {
                if (elements[index] > maxValue)
                {
                    maxValue = elements[index];
                }
            }

            return maxValue;
        }

        public static void PrintAsNumber(object number, string format)
        {
            if (number == null)
            {
                throw new ArgumentNullException("Number can't be null!");
            }

            if (format == null || format == string.Empty)
            {
                throw new ArgumentNullException("Format can't be null or empty!");
            }

            double parsedNumber;
            bool isParsed = double.TryParse(number.ToString(), out parsedNumber);
            if (!isParsed)
            {
                throw new ArgumentException("The object is not a number");
            }

            switch (format)
            {
                case "f":
                    Console.WriteLine("{0:f2}", number);
                    break;
                case "%":
                    Console.WriteLine("{0:p0}", number);
                    break;
                case "r":
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    Console.WriteLine("Unknown format!");
                    break;
            }
        }

        public static void PrintDirection(double x1, double y1, double x2, double y2)
        {
            bool isHorizontal = y1 == y2;
            bool isVertical = x1 == x2;
            if (isHorizontal)
            {
                Console.WriteLine("The direction is horizontal!");
            }
            else if (isVertical)
            {
                Console.WriteLine("The direction is vertical!");
            }
            else
            {
                Console.WriteLine("Unknown direction!");
            }
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double differenceX = x2 - x1;
            double differenceY = y2 - y1;
            double distance = Math.Sqrt((differenceX * differenceX) + (differenceY * differenceY));
            return distance;
        }

        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToDigit(5));
            Console.WriteLine(NumberToDigit(-1));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            
            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            PrintDirection(3, -1, 3, 2.5);
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));

            Student peter = new Student() 
            { 
                FirstName = "Peter", 
                LastName = "Ivanov",
                OtherInfo = "From Sofia, born at 17.03.1992"
            };

            Student stella = new Student() 
            { 
                FirstName = "Stella", 
                LastName = "Markova",
                OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993"
            };

            Console.WriteLine(
                "{0} older than {1} -> {2}",
                peter.FirstName, 
                stella.FirstName, 
                peter.IsOlderThan(stella));
        }
    }
}

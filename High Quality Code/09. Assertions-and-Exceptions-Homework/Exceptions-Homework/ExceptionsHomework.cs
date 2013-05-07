using System;
using System.Collections.Generic;

public class ExceptionsHomework
{
    public static void Main()
    {
        var substr = AdditionalMethods.Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = AdditionalMethods.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(string.Join(" ", subarr));

        var allarr = AdditionalMethods.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(string.Join(" ", allarr));

        //// Uncomment to see the exception
        //// var emptyarr = AdditionalMethods.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        //// Console.WriteLine(string.Join(" ", emptyarr));

        Console.WriteLine(AdditionalMethods.ExtractEnding("I love C#", 2));
        Console.WriteLine(AdditionalMethods.ExtractEnding("Nakov", 4));
        Console.WriteLine(AdditionalMethods.ExtractEnding("beer", 4));
        //// Uncomment to see the exception
        //// Console.WriteLine(AdditionalMethods.ExtractEnding("Hi", 100));
        //// Console.WriteLine(AdditionalMethods.ExtractEnding("", 0));

        try
        {
            AdditionalMethods.CheckPrime(23);
            AdditionalMethods.CheckPrime(33);
            AdditionalMethods.CheckPrime(1);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Invalid number - {0}", ex);
        }
        
        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
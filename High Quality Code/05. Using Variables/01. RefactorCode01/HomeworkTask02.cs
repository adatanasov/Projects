/* 02. Refactor the following code to apply variable usage and naming best practices:
public void PrintStatistics(double[] arr, int count)
{
    double max, tmp;
    for (int i = 0; i < count; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    PrintMax(max);
    tmp = 0;
    max = 0;
    for (int i = 0; i < count; i++)
    {
        if (arr[i] < max)
        {
            max = arr[i];
        }
    }
    PrintMin(max);

    tmp = 0;
    for (int i = 0; i < count; i++)
    {
        tmp += arr[i];
    }
    PrintAvg(tmp/count);
}
*/

using System;

public class HomeworkTask02
{
    public void PrintStatisticsForSalaries(double[] employeesSalaries, int numberOfEmployees)
    {
        if (employeesSalaries == null)
        {
            throw new ArgumentNullException("The list of employees is empty!");
        }

        if (numberOfEmployees <= 0)
        {
            throw new ArgumentOutOfRangeException("The number of employees must be positive!");
        }

        double maximalSalary = this.GetMaxValue(employeesSalaries, numberOfEmployees);
        Print(maximalSalary);

        double minimalSalary = this.GetMinValue(employeesSalaries, numberOfEmployees);
        Print(maximalSalary);

        double averageSalary = this.GetAverageValue(employeesSalaries, numberOfEmployees);
        Print(averageSalary);
    }

    private double GetMaxValue(double[] employees, int limit)
    {
        double maximalSalary = double.MinValue;
        for (int index = 0; index < limit; index++)
        {
            if (employees[index] > maximalSalary)
            {
                maximalSalary = employees[index];
            }
        }

        return maximalSalary;
    }

    private double GetMinValue(double[] employees, int limit)
    {
        double minimalSalary = double.MaxValue;
        for (int index = 0; index < limit; index++)
        {
            if (employees[index] < minimalSalary)
            {
                minimalSalary = employees[index];
            }
        }

        return minimalSalary;
    }

    private double GetAverageValue(double[] employees, int numberOfEmployees)
    {
        double sumOfSalaries = 0d;
        for (int index = 0; index < numberOfEmployees; index++)
        {
            sumOfSalaries += employees[index];
        }

        double averageSalary = sumOfSalaries / numberOfEmployees;
        return averageSalary;
    }
}

using System;
using System.Diagnostics.CodeAnalysis;

namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 grades separated by new line: ");
            double firstgrade = Convert.ToDouble(Console.ReadLine());
            double secondgrade = Convert.ToDouble(Console.ReadLine());
            double thirdgrade = Convert.ToDouble(Console.ReadLine());
            double fourthgrade = Convert.ToDouble(Console.ReadLine());
            double fifthgrade = Convert.ToDouble(Console.ReadLine());
            double sum = firstgrade + secondgrade + thirdgrade + fourthgrade + fifthgrade;
            double totalgrade = sum / 5;
            double average = Math.Round(totalgrade);
            Console.WriteLine("The average is " + totalgrade + " and round off to " + average);
            
            
        }
    }
}
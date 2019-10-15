using System;

namespace NaturalLogarithm
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1.5;
            int n = 11;
            Logarithm l = new Logarithm(x, n);
            Print p = new Print();

            Console.Out.WriteLine("Naive from start:");
            p.PrintCsv("NaiveStart", l.CalculateNaiveFromStart());
            Console.Out.WriteLine("Naive from end:");
            p.PrintCsv("NaiveEnd", l.CalculateNaiveFromEnd());
            Console.Out.WriteLine("Smart from start:");
            p.PrintCsv("SmartStart", l.CalculateSmartFromStart());
            Console.Out.WriteLine("Smart from end:");
            p.PrintCsv("SmartEnd", l.CalculateSmartFromEnd());
        }
    }
}

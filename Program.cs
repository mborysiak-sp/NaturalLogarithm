using System;

namespace NaturalLogarithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Logarithm l = new Logarithm();
            Print p = new Print();

            int x = 100, n = 100;
            Console.Out.WriteLine("Naive from start:");
            p.PrintCsv("NaiveStart", l.CalculateNaiveFromStart(x, n));
            Console.Out.WriteLine("Naive from end:");
            //p.PrintCsv("NaiveEnd", l.CalculateNaiveFromEnd(x, n));
            Console.Out.WriteLine("Smart from start:");
            p.PrintCsv("SmartStart", l.CalculateSmartFromStart(x, n));
            Console.Out.WriteLine("Smart from end:");
           //p.PrintCsv("SmartEnd", l.CalculateSmartFromEnd(x, n));
        }
    }
}

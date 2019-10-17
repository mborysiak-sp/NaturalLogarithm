using System;

namespace NaturalLogarithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculations calc = new Calculations(0, 2, 1000, 100000); //  miljion*tysionc*cztyry = dlugo
            Print p = new Print();
            //Logarithm l = new Logarithm(0.000001, 1000000);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            calc.CalculateResults();
            //p.PrintCsv("jedenX", l.CalculateNaiveFromStart());
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.Out.WriteLine(elapsedMs);
            //p.PrintLastErrors("lastErrors", calc.ResultList);
            //p.PrintApproxmation(1000, calc.ResultList, "approximationFor100000");
            p.PrintPositions(calc.ResultList, "szczury2");
            //Console.Out.WriteLine("Naive from start:");
            //p.PrintCsv("NaiveStart", l.CalculateNaiveFromStart());
            //Console.Out.WriteLine("Naive from end:");
            //p.PrintCsv("NaiveEnd", l.CalculateNaiveFromEnd());
            //Console.Out.WriteLine("Smart from start:");
            //p.PrintCsv("SmartStart", l.CalculateSmartFromStart());
            //Console.Out.WriteLine("Smart from end:");
            //p.PrintCsv("SmartEnd", l.CalculateSmartFromEnd());
        }
    }
}

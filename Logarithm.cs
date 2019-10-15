using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NaturalLogarithm
{
    class Logarithm : Support
    {        
        private double CalculateError(double value, double sum)
        {
            return Math.Abs(CalculateImplementedLogarithm(value) - sum);
        }

        private double CalculateImplementedLogarithm(double value)
        {
            return Math.Log(value);
        }

        public double[,] CalculateNaiveFromStart(int x, int n)
        {
            double[,] results = new double[x, n];
            double value = 2 / x;

            for(int j = 0; j < x; j++)
            {
                for (int i = 1; i < n; i++)
                {
                    results[j, i - 1] = Power(-1, i + 1) / i * Power(value - 1, i);
                }
                value += 2 / x;
            }

            return SumResultsFromStart(x, results);
        }
        
        public double[,] CalculateNaiveFromEnd(int x, int n)
        {
            double[,] results = new double[x, n];
            double value = 2 - (2/x);
            for (int j = x - 1; j >= 0; j--)
            {
                for (int i = results.Length; i >= 1; i--)
                {
                    results[j, i - 1] = Power(-1, i + 1) / i * Power(x - 1, i);
                }
                value -= x / 2;
            }

            return SumResultsFromEnd(x, results);
        }

        public double[,] CalculateSmartFromStart(int x, int n)
        {
            return SumResultsFromStart(x, CalculateSmart(x, n));
        }

        public double[,] CalculateSmartFromEnd(int x, int n)
        {
            return SumResultsFromEnd(x, CalculateSmart(x, n));
        }

        private double[,] CalculateSmart(int x, int n)
        {
            double tempSum = x - 1;

            double[,] results = new double[x, n];
            results[0, 0] = tempSum;

            double value = 2 / x;

            for (int j = 0; j < x; j++)
            {
                for (int i = 1; i < n; i++)
                {
                    tempSum *= -(i * (value - 1) / (i + 1));
                    results[j, i] = tempSum;
                }
                value += 2 / x;
            }
            
            return results;
        }

        private double[,] SumResultsFromStart(int x, double[,] results)
        {
            double sum = 0;
            double[,] errors = new double[results.GetLength(0), results.GetLength(1)];

            for (int j = 0; j < results.GetLength(0); j++)
            {
                for (int i = 0; i < results.GetLength(1); i++)
                {
                    sum += results[j, i];
                    errors[j, i] = CalculateError(x, sum);
                }
            }
            

            return errors;
        }

        private double[,] SumResultsFromEnd(int x, double[,] results)
        {
            double sum = 0;
            double[,] errors = new double[results.GetLength(0), results.GetLength(1)];
            double[,] sums = new double[results.GetLength(0), results.GetLength(1)];

            for (int j = results.GetLength(0) - 1; j >= 0; j--)
            {
                for (int i = results.GetLength(1) - 1; i >= 0; i--)
                {
                    sum += results[j, i];
                    sums[j, i] = sum;
                }
            }

            for (int j = 0; j < results.GetLength(0); j++)
            {
                for (int i = 0; i < results.GetLength(1); i++)
                    errors[j, i] = CalculateError(x, sums[j, i]);
            }
            
            return errors;
        }
    }
}

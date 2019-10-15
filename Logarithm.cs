using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NaturalLogarithm
{
    class Logarithm : Support
    {
        private double X = new double();
        private double Log = new double();
        private int N = new int();

        public Logarithm(double x, int n)
        {
            X = x;
            Log = CalculateImplementedLogarithm(x);
            N = n;
        }

        private double CalculateError(double sum)
        {
            return Math.Abs(Log - sum);
        }

        private double CalculateImplementedLogarithm(double value)
        {
            return Math.Log(value);
        }

        public double[] CalculateNaiveFromStart()
        {
            return SumResultsFromStart(CalculateNaive());
        }

        public double[] CalculateNaiveFromEnd()
        {
            return SumResultsFromEnd(CalculateNaive());
        }

        public double[] CalculateSmartFromStart()
        {
            return SumResultsFromStart(CalculateSmart());
        }

        public double[] CalculateSmartFromEnd()
        {
            return SumResultsFromEnd(CalculateSmart());
        }

        private double[] CalculateNaive()
        {
            double[] results = new double[N];

            for (int i = 1; i <= N; i++)
            {
                results[i - 1] = Power(-1, i + 1) / i * Power(X - 1, i);
            }

            return results;
        }

        private double[] CalculateSmart()
        {
            double tempSum = X - 1;

            double[] results = new double[N];
            results[0] = tempSum;

            for (int i = 1; i < N; i++)
            {
                tempSum *= -(i * (X - 1) / (i + 1));
                results[i] = tempSum;
            }

            return results;
        }
        
        private double[] SumResultsFromStart(double[] results)
        {
            double sum = 0;
            double[] sums = new double[N];
               
            for (int i = 0; i < N; i++)
            {
                sum += results[i];
                 sums[i] = sum;
            }

            return sums;
        }

        private double[] SumResultsFromEnd(double[] results)
        {
            double[] sums = new double[N];
            double sum = 0;

            for (int i = N - 1; i >= 0; i--)
            {
                sum += results[i];
                sums[i] = sum;
            }

            //sums = Reverse(sums);

            return sums;
        }

        private double[] CalculateErrors(double[] sums)
        {
            double[] errors = new double[N];

            for (int i = 0; i < N; i++)
                errors[i] = CalculateError(sums[i]);

            return errors;
        }
    }
}


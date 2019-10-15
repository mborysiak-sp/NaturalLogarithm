using System;
using System.Collections.Generic;
using System.Text;

namespace NaturalLogarithm
{
    class Calculations
    {
        private double StartX, EndX;
        private int XCount, N;
        private Dictionary<double, double[]> ResultSet;

        public Calculations(double startX, double endX, int xCount, int n)
        {
            StartX = startX;
            EndX = endX;
            XCount = xCount;
            N = n;
        }

        public List<ResultSet> CalculateResults()
        {
            double x = StartX + (EndX / XCount);
            while (x < EndX)
            {
                Logarithm l = new Logarithm(x, N);
                l.CalculateNaiveFromEnd
            }
            
        }

    }
}

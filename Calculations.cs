using System;
using System.Collections.Generic;
using System.Text;

namespace NaturalLogarithm
{
    class Calculations : Support
    {
        private double StartX, EndX;
        private int XCount, N;
        public List<ResultSet> ResultList;

        public Calculations(double startX, double endX, int xCount, int n)
        {
            StartX = startX;
            EndX = endX;
            XCount = xCount;
            N = n;
        }

        public List<ResultSet> CalculateResults()
        {
            ResultList = new List<ResultSet>();

            double x = StartX + (EndX - StartX) / XCount;

            while (x < (EndX - (EndX - StartX) / XCount))
            {
                Logarithm l = new Logarithm(x, N);

                ResultSet rs = new ResultSet(x, l.CalculateNaiveFromStart(), l.CalculateNaiveFromEnd(), l.CalculateSmartFromStart(), l.CalculateSmartFromEnd());

                ResultList.Add(rs);

                x += (EndX - StartX) / XCount;
            }

            return ResultList;
        }
    }
}

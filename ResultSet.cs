using System;
using System.Collections.Generic;
using System.Text;

namespace NaturalLogarithm
{

    class ResultSet
    {
        public double[] NaiveFromStart;
        public double[] NaiveFromEnd;
        public double[] SmartFromEnd;
        public double[] SmartFromStart;
        public double X;

        public ResultSet(double x, double[] naiveFromStart, double[] naiveFromEnd, double[] smartFromStart, double[] smartFromEnd)
        {
            X = x;
            NaiveFromStart = naiveFromStart;
            NaiveFromEnd = naiveFromEnd;
            SmartFromEnd = smartFromEnd;
            SmartFromStart = smartFromStart;
        }
        
        public ResultSet() { }

    }
}

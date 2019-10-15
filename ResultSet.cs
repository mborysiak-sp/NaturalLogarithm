using System;
using System.Collections.Generic;
using System.Text;

namespace NaturalLogarithm
{

    class ResultSet
    {
        public double[] NaiveFromStart { get => NaiveFromStart; set => NaiveFromStart = value; }
        public double[] NaiveFromEnd { get => NaiveFromEnd; set => NaiveFromEnd = value; }
        public double[] SmartFromEnd { get => SmartFromEnd; set => SmartFromEnd = value; }
        public double[] SmartFromStart { get => SmartFromStart; set => SmartFromStart = value; }
        public double X { get => X; set => X = value; }

        public ResultSet(double x, double[] naiveFromStart, double[] naiveFromEnd, double[] smartFromEnd, double[] smartFromStart)
        {
            X = x;
            NaiveFromStart = naiveFromStart;
            NaiveFromEnd = naiveFromEnd;
            SmartFromEnd = smartFromEnd;
            SmartFromStart = smartFromStart;
        }

    }
}

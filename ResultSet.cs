using System;
using System.Collections.Generic;
using System.Text;

namespace NaturalLogarithm
{

    class ResultSet : Support
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


        private int GetPrecisionFor(string name)
        {
            int n = NaiveFromStart.Length - 1;

            switch (name)
            {
                case "NaiveFromStart":
                    for (int i = 0; i < n; i++)
                        if (NaiveFromStart[i] <= Power(10, -6))
                            return i;
                    break;
                case "SmartFromStart":
                    for (int i = 0; i < n; i++)
                        if (SmartFromStart[i] <= Power(10, -6))
                            return i;
                    break;
                case "NaiveFromEnd":
                    for (int i = 0; i < n; i++)
                        if (NaiveFromEnd[i] <= Power(10, -6))
                            return i;
                    break;
                case "SmartFromEnd":
                    for (int i = 0; i < n; i++)
                        if (SmartFromEnd[i] <= Power(10, -6))
                            return i;
                    break;
                default:
                    return -1;
            }

            return -1;
        }

        //public Tuple<int, double, double, double, double> GetPrecisionPerX()
        //{
        //    return new Tuple<>
        //}
    }
}

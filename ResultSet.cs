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

        public int GetPrecisionForNFS()
        {
            int n = NaiveFromStart.Length - 1;
            double power = Convert.ToDouble("0.000001");

            for (int i = 0; i <= n; i++)
                if (NaiveFromStart[i] <= power)
                    return i;
            return -1;    
        }

        public int GetPrecisionForSFS()
        {
            int n = NaiveFromStart.Length - 1;
            double power = Convert.ToDouble("0.000001");

            for (int i = 0; i <= n; i++)
                if (SmartFromStart[i] <= power)
                    return i;
            return -1;
        }

        //public int GetPrecisionForSFE()
        //{
        //    int n = NaiveFromStart.Length - 1;
        //    double power = Convert.ToDouble("0.000001");

        //    for (int i = 0; i <= n; i++)
        //        if (SmartFromEnd[i] <= power)
        //            return i;
        //    return -1;
        //}

        //public int GetPrecisionForNFE()
        //{
        //    int n = NaiveFromStart.Length - 1;
        //    double power = Convert.ToDouble("0.000001");

        //    for (int i = 0; i <= n; i++)
        //    {
        //        //if (SmartFromEnd[i] < 0.001)
        //        //    Console.Out.WriteLine($"i: {i} power = {power} | {SmartFromEnd[i]} = value");
        //        if (SmartFromEnd[i] <= power)
        //            return i;
        //    }

        //    return -1;
        //}
    }
}

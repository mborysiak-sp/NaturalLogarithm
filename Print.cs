using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NaturalLogarithm
{
    class Print
    {
        //public void PrintCsv(string fileName, ResultSet records)
        //{
        //    using(var writer = new StreamWriter($"{fileName}.csv"))
        //    using(var csv = new CsvWriter(writer))
        //    {
        //        //csv.WriteRecords(records);
        //    }
        //}

        public void PrintLastErrors(string name, List<ResultSet> rsList)
        {
            using (var w = new StreamWriter(name + ".csv"))
            {
                foreach (ResultSet rs in rsList)
                {
                    int n = rs.NaiveFromStart.Length - 1;
                    var line = string.Format($"{rs.X},{rs.NaiveFromStart[n]},{rs.SmartFromStart[n]},{rs.NaiveFromEnd[n]},{rs.SmartFromEnd[n]}");
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }
    }
}

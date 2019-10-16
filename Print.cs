using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NaturalLogarithm
{
    class Print
    {
        public void PrintCsv(string fileName, double[] records)
        {
            using (var writer = new StreamWriter($"{fileName}.csv"))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(records);
            }
        }

        public void PrintLastErrors(string name, List<ResultSet> rsList)
        {
            using (var w = new StreamWriter(name + ".csv"))
            {
                var line = string.Format("X, NaiveFromStart, SmartFromStart, NaiveFromEnd, SmartFromEnd");
                w.WriteLine(line);
                w.Flush();

                foreach (ResultSet rs in rsList)
                {
                    int n = rs.NaiveFromStart.Length - 1;
                    line = string.Format($"{rs.X},{rs.NaiveFromStart[n]},{rs.SmartFromStart[n]},{rs.NaiveFromEnd[n]},{rs.SmartFromEnd[n]}");
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }

        //public void PrintAllErrors(string name, List<ResultSet>)
        public void PrintApproxmation(int n, List<ResultSet> rsList, string name)
        {
            using (var w = new StreamWriter(name + ".csv"))
            {
                double start, end;
                double aStart = 0, bStart = 0, aEnd = 0, bEnd = 0; //a - naive, b - smart

                var line = string.Format("XRange, NaiveFromStart, SmartFromStart, NaiveFromEnd, SmartFromEnd");
                w.WriteLine(line);
                w.Flush();

                for (int i = 0; i < rsList.Count; i += n)
                {
                    start = i;
                    end = i + n;
                    for (int j = 0; j < n && (j + i) < rsList.Count; j++)
                    {
                        int index = rsList[i + j].NaiveFromStart.Length - 1;
                        aStart += rsList[i + j].NaiveFromStart[index];
                        bStart += rsList[i + j].SmartFromStart[index];
                        aEnd += rsList[i + j].NaiveFromEnd[index];
                        bEnd += rsList[i + j].SmartFromEnd[index];
                    }

                    aStart /= n;
                    bStart /= n;
                    aEnd /= n;
                    bEnd /= n;

                    line = string.Format($"{start} - {end}, {aStart}, {bStart}, {aEnd}, {bEnd}");
                    w.WriteLine(line);
                    w.Flush();
                }
            }

        }


    }
}

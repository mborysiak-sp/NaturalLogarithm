using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NaturalLogarithm
{
    class Print
    {
        public void PrintCsv(string fileName, double[,] records)
        {
            using(var writer = new StreamWriter($"{fileName}.csv"))
            using(var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(records);
            }
        }
    }
}

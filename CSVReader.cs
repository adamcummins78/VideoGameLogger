using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLogger
{
    public static class CSVReader 
    {
        public static void Reader(List<string> Title) 
        { 
            string CSVPath = "CSV/GameList.csv";
            String csv = String.Join(Environment.NewLine, Title.Select(g => $"{g}"));
            System.IO.File.WriteAllText(CSVPath, csv);
        }
    }
}
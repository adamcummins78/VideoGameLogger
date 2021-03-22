using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLogger
{
    public static class CSVReader 
    {
        //This methods allows user to export their list of titles to a CSV.
        public static void Reader(List<string> Title) 
        { 
            string CSVPath = "CSV/GameList.csv";
            String csv = String.Join(Environment.NewLine, Title.Select(g => $"{g}"));
            System.IO.File.WriteAllText(CSVPath, csv);
            Console.WriteLine(Environment.NewLine);
        }
    }
}
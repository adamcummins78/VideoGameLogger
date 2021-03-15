using System;
using System;
using System.Collections.Generic;
using Microsoft.Data.Analysis;
using System.Linq;
using System.IO;

namespace GameLogger
{
    class Program
    {
        static void Main(string[] args)
        {
				VideoGame.addGame();
        }
    }

    public class VideoGame
	{

		public string Title { get; set; }
		public string Rating { get; set; }
		public string ESRB { get; set; }

		public static void addGame()
		{
			List<string> Title = new List<string>();
			List<string> Rating = new List<string>();
			List<string> ESRB = new List<string>();

			Console.WriteLine("Enter a video game title: ");
			string NewTitle = Console.ReadLine();

			Console.WriteLine("Enter a rating from 1-10: ");
			string NewRating = (Console.ReadLine());

			Console.WriteLine("Enter the ERSB rating (E, T, M, etc.): ");
			string NewESRB = Console.ReadLine().ToUpper();

			Title.Add(NewTitle);
			Rating.Add(NewRating);
			ESRB.Add(NewESRB);

			string CSVPath = "CSV/GameList.csv";

			var Game = new Dictionary<string, List<string>>()
			{
				["Title: "] = Title,
				["Rating: "] = Rating,
				["ESRB: "] = ESRB

			};


			String csv = String.Join(Environment.NewLine, Game.Select(g => $"{g.Key}{g.Value}"));
			System.IO.File.WriteAllText(CSVPath, csv);
		}

		public static void ViewGameList()
		{
			foreach (string i in Title)
            {
                Console.WriteLine(i);
            }
			
		}
	}
}

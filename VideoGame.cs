using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLogger
{

public class VideoGame
	{

		public List<string> Title = new List<string>();

		public void addGame()
		{
			Console.Write("Enter a video game title: ");
						string NewTitle = Console.ReadLine();

				Title.Add(NewTitle);
				Console.WriteLine();
				Console.WriteLine($"You added {NewTitle} to the list!");
		}

		public void ViewGameList()
		{
			Title.OrderByDescending(x => x).ToList().ForEach(x => { Console.WriteLine(x); });
						Console.WriteLine();
		}
	}
	}
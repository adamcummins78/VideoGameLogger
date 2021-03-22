using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLogger
{

public class VideoGame
	{

		public List<string> Title = new List<string>();

		//This method adds a game title added by user to a list.
		public void addGame()
		{
			Console.Write("Enter a video game title: ");
						string NewTitle = Console.ReadLine();

				Title.Add(NewTitle);
				Console.WriteLine($"You added {NewTitle} to the list!");
		}
		//This method display the titles in the list in alphabetical order.
		public void ViewGameList()
		{
			Title.OrderBy(x => x).ToList().ForEach(x => { Console.WriteLine(x); });
						Console.WriteLine();
		}
	}
	}
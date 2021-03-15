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
			List<string> Title = new List<string>();

				Console.Write("Please enter your name: ");
				string name = Console.ReadLine();

			while(true)
			{
				Console.WriteLine($"Welcome to Video Game Logger, {name}!");
				
				Console.Write("Please enter a number to make a selection: \n1 - Add new game \n2 - View games in list \nAny other character - Exit program \nSelection: ");
				var choice  = (Console.ReadLine());
				Console.WriteLine();

				if(choice == "1")
					{
						Console.Write("Enter a video game title: ");
						string NewTitle = Console.ReadLine();

						Title.Add(NewTitle);
						Console.WriteLine();
					}
				else if(choice == "2")
					{
						Console.WriteLine("print list");
					}

				else
					{
						Environment.Exit(0);
					}
			}

        }
    }

    public class VideoGame
	{

		public string Title { get; set; }

		public static void addGame()
		{

			

		}

		public static void ViewGameList()
		{
			
			
		}
	}
}

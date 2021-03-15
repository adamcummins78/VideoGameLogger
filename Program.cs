using System;


namespace GameLogger
{
    class Program
    {
        static void Main(string[] args)
        {
				Console.Write("Please enter your name: ");
				string name = Console.ReadLine();
				var videoGame = new VideoGame();

			while(true)
			{
				Console.WriteLine($"Welcome to Video Game Logger, {name}!");
				
				Console.Write("Please enter a number to make a selection: \n1 - Add new game \n2 - View games in list \n3 - Export list to Excel \n4 - Exit program \nSelection: ");
				var choice  = (Console.ReadLine());
				Console.WriteLine();

				if(choice == "1")
					{
						videoGame.addGame();
					}
				else if(choice == "2")
					{
						videoGame.ViewGameList();
					}

				else if(choice == "3")
					{	
						CSVReader.Reader(videoGame.Title);
					}

				else if(choice == "4")
					{
						Environment.Exit(0);
					}

				else
					{
						Console.WriteLine("Invalid Entry");
					}
			}

        }
    }
}

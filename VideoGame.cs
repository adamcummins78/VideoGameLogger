using System;
using System.Collections.Generic;

public class VideoGame
{

	public string Title { get; set; }
	public int Rating { get; set; }
	public string ESRB { get; set; }
	
	public void addGame()
	{
		List<string> Title = new List<string>();
		List<double> Rating = new List<double>();
		List<string> ESRB = new List<string>();

		Console.WriteLine("Enter a video game title: ");
			var NewTitle = Console.ReadLine();

		Console.WriteLine("Enter a rating from 1-10 (decimals allowed): ");
			double NewRating = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Enter the ERSB rating (E, T, M, etc.): ");
			var NewESRB = Console.ReadLine().ToUpper();

		Title.Add(NewTitle);
		Rating.Add(NewRating);
		ESRB.Add(NewESRB);

	}
}

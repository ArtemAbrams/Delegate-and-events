using ConsoleApp;
Bread bread = new Bread(45, 90);
Butter butter = new Butter(60, 89);
Sandwich sandwich = bread + butter;
Console.WriteLine(sandwich.Quality+" " + sandwich.Weight);
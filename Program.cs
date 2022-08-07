using ConsoleApp;
Celcius celcius = new Celcius(39);
Fahrenheit fahrenheit = new Fahrenheit(134);
Celcius celcius_1 = fahrenheit;
Fahrenheit fahrenheit_1 = celcius;
Console.WriteLine(" " + celcius_1.Gradus+ " " + fahrenheit_1.Gradus);
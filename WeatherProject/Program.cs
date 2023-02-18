// See https://aka.ms/new-console-template for more information
using WeatherProject;

WeatherData wd = new WeatherData();

Console.Write("Input either C for Celsius or F for Fahrenheit:");
wd.Scale = Console.ReadLine().ToUpper();
Console.Write("Input temperature between -60 and 60 for Celsius and -76 and 140 for Fahrenheit:");
wd.Temperature = double.Parse(Console.ReadLine());
Console.Write("Input humidity between 0% and 100%:");
wd.Humidity = int.Parse(Console.ReadLine());

Console.WriteLine($"Scale: {wd.Scale} Temperature: {wd.Temperature + wd.Scale}° Humidity: {wd.Humidity}%");
wd.Convert();
Console.WriteLine($"Scale: {wd.Scale} Temperature: {wd.Temperature + wd.Scale}° Humidity: {wd.Humidity}%");
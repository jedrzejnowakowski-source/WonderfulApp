// See https://aka.ms/new-console-template for more information
using Database;

Console.WriteLine("Hello, World!");
Console.ReadKey();

var weather2 = new Weather();
var weather5 = new Weather();

weather5 = ChangeWeather(weather2);

Console.WriteLine($"Weather2 measured by: {weather2.MeasuredBy}");
Console.WriteLine($"Weather5 measured by: {weather5.MeasuredBy}");

weather5 = weather2;

Weather ChangeWeather(Weather weather)
{
    var objectToChange = new Weather();
    Console.WriteLine($"Weather measured by: {weather.MeasuredBy}");
    objectToChange.MeasuredBy = "Jan Kowalski";
    Console.WriteLine($"Weather measured by: {weather.MeasuredBy}");

    return objectToChange;
}
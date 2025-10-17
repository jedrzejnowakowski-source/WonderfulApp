// See https://aka.ms/new-console-template for more information
using Database;
using StacjaPogodowa;

Console.WriteLine("Hello, World!");
Console.ReadKey();

var weather2 = new Weather();
var weather5 = new Weather();

var utils = new Utils();
weather5 = utils.ChangeWeather(weather2);

Console.WriteLine($"Weather2 measured by: {weather2.MeasuredBy}");
Console.WriteLine($"Weather5 measured by: {weather5.MeasuredBy}");

weather5 = weather2;
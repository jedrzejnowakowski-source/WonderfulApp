using Database;

namespace StacjaPogodowa
{
    internal class Utils
    {
        internal Weather ChangeWeather(Weather weather)
        {
            var objectToChange = new Weather();
            Console.WriteLine($"Weather measured by: {weather.MeasuredBy}");
            objectToChange.MeasuredBy = "Jan Kowalski";
            Console.WriteLine($"Weather measured by: {weather.MeasuredBy}");

            return objectToChange;
        }
    }
}

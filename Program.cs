using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace OpenWeatherMap
{
    class Program
    {
        public static void Main(string[] args)
        {
            string key = File.ReadAllText("key.txt");

            string apiKey = JObject.Parse(key).GetValue("APIKey")!.ToString();

            Console.WriteLine("What is your zipcode?");

            var zipCode = Console.ReadLine();

            var apiCall =
                $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={apiKey}";

            Console.WriteLine();
            Console.WriteLine($"The temperature in {zipCode} is {WeatherMap.GetTemp(apiCall)} degrees Fahrenheit.");
           
        }
    }
}



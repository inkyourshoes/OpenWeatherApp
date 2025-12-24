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
            //
            // string keyFilePath = Path.Combine(AppContext.BaseDirectory, "key.txt");
            //
            // try
            // {
            //     // Check if the file exists
            //     if (!File.Exists(keyFilePath))
            //     {
            //         Console.WriteLine($"Error: Unable to locate key.txt at: {keyFilePath}");
            //         return;
            //     }
            //
            //     // Read the contents of the file
            //     string fileContent = File.ReadAllText(keyFilePath);
            //
            //     // Parse as JSON
            //     var jsonObject = JObject.Parse(fileContent);
            //
            //     // Extract the API key
            //     string apiKey = jsonObject["apiKey"]?.ToString();
            //
            //     // Validate the API key
            //     if (string.IsNullOrWhiteSpace(apiKey))
            //     {
            //         Console.WriteLine("Error: The 'apiKey' is missing or empty in the key.txt file.");
            //         return;
            //     }
            //
            //     Console.WriteLine($"API Key Found: {apiKey}");
            //
            //     // Use the API key (e.g., in an API call)
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}


//         }
//     }
// }



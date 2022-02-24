using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentTempCelsius = 0;
            currentTempCelsius = TempConverter.CelsiusToFahrenheit(currentTempCelsius);
            Console.WriteLine($"{currentTempCelsius} degrees Fahrenheit");

            Console.WriteLine("");
            Console.WriteLine("");

            double currentTempFahrenheit = 32;
            currentTempFahrenheit = TempConverter.FahrenheitToCelsius(currentTempFahrenheit);
            Console.WriteLine($"{currentTempFahrenheit} degrees Celsius");
        }
    }
}

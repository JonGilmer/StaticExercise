using System;

namespace StaticExercise
{
    public static class TempConverter
    {
        // Default constructor
        static TempConverter()
        {
        }

        // Converts a temperature in degrees Fahrenheit to a temp in degrees Celsius.
        public static double FahrenheitToCelsius(double tempFahrenheit)
        {
            double toCelsiusTemp = (tempFahrenheit - 32) / 1.8;
            return toCelsiusTemp;
        }

        // Converts a temperature in degrees Celsius to a temp in degrees Fahrenheit.
        public static double CelsiusToFahrenheit(double tempCelsius)
        {
            double toFahrenheitTemp = ((9 / 5) * tempCelsius) + 32;
            return toFahrenheitTemp;
        }
    }
}

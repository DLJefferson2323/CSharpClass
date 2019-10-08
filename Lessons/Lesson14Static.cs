using System;

/* This class goes over Lesson 14 content 
Static */
namespace CSharpClass.Lessons
{
    public static class Lesson14Static
    {
        static readonly int baseTemp;

            static Lesson14Static()
            {
                baseTemp = 32;
            }

        // static method 1
        public static void CelsiustoFahrenheit(string temperature)
        {
            double celsius = Double.Parse(temperature);
            double fahrenheit = (celsius * 9 / 5) + baseTemp;
            Console.WriteLine(fahrenheit);
        } // end method celsius to fahrenheit

        public static void FahrenheittoCelsius(string temperature)
        {
            double fahrenheit = Double.Parse(temperature);
            double celsius = (fahrenheit - baseTemp) * 5 / 9;
            Console.WriteLine(celsius);
        } // end method fahrenheit to celsius
    } // end class
} // end namespace
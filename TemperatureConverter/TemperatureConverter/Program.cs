using System;

namespace TemperatureConverter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Temperature Converter App!");
            string cont = "y";
            while (cont.Equals("y")) {
                Console.Write("Enter degrees fahrenheit: ");
                double degrees = Convert.ToDouble(Console.ReadLine());
                double celsius = (degrees - 32) * .555555555555556;
                Console.WriteLine("Degrees in celsius: "+Math.Round(celsius,2));
                Console.WriteLine();
                Console.Write("Continue? y/n: ");
                cont = Console.ReadLine();
                }
            Console.WriteLine("Peace out!");
            }
        }
    }

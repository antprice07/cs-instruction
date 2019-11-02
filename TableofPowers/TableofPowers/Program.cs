using System;

namespace TableofPowers {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Table of Powers App!");

            string cont = "y";
            while (cont.Equals("y")) {
                Console.Write("Enter an integer: ");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\nNumber\t\tSquared\t\tCubed");
                Console.WriteLine("======\t\t=======\t\t=====");
                for (int i = 1; i <= length; i++) {
                    Console.WriteLine(i + "\t\t" + i * i + "\t\t" + i * i * i);
                    }
                Console.Write("Continue? y/n: ");
                cont = Console.ReadLine();
                }
            Console.WriteLine("Goodbye.");
            }
        }
    }

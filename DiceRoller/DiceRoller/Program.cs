using System;

namespace DiceRoller {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Dice Roller");
            Console.Write("Do you want to roll the dice? y/n: ");
            string rollDice = Console.ReadLine();
            while (rollDice.Equals("y")) {
                Random rand = new Random();
                int die1 = rand.Next(1, 7);
                int die2 = rand.Next(1, 7);
                if (die1 + die2 == 12) {
                    Console.WriteLine("Die 1 = " + die1);
                    Console.WriteLine("Die 2 = " + die2);
                    Console.WriteLine("Total = " + (die1 + die2));
                    Console.WriteLine("Boxcars!");
                    }else if (die1 + die2 == 2) {
                    Console.WriteLine("Die 1 = " + die1);
                    Console.WriteLine("Die 2 = " + die2);
                    Console.WriteLine("Total = " + (die1 + die2));
                    Console.WriteLine("Snake Eyes!");
                    }
                else {
                    Console.WriteLine("Die 1 = " + die1);
                    Console.WriteLine("Die 2 = " + die2);
                    Console.WriteLine("Total = " + (die1 + die2));
                    }
                Console.Write("Roll again? y/n: ");
                rollDice = Console.ReadLine();
                }
            Console.WriteLine("See ya!");
            }
        }
    }

using System;

namespace prj02_1_StudentRegistration {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Student Registration App!");
            Console.WriteLine("Student Registration Form");

            Console.Write("Enter first name: ");
            string fname = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lname = Console.ReadLine();
            Console.Write("Enter year of birth: ");
            int byear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Welcome " + fname + " " + lname);
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is " + fname + "*" + byear);
            }
        }
    }

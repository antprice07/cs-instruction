using System;
using System.Collections;
using System.Collections.Generic;

namespace ProductManager {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Product Manager");

            int i1 = GetInt("Enter a whole number: ");
            Console.WriteLine("i1 = " + i1);

            String name = "";
            name = GetString("Enter name: ");
            Console.WriteLine("name is: " + name);


            PrintThreeNumbers(5, 6, 7);
            PrintThreeNumbers();
            PrintThreeNumbers(b: 8,c: 10);

            Product p1 = new Product("java", "Murach's Java Programming", 59.50);
            Console.WriteLine(p1);
            Book b1 = new Book { Code = "c#", Description = "Murach's C# Programming", Price = 57.50, Author = "Joel Murach" };
            Console.WriteLine(b1);
            Product p2 = new Product("and", "Murach's Android Programming", 62.50);
            Product[] products = { p1, p2, b1 };

            foreach(Product p in products) {
                Console.WriteLine(p);
                }
            ArrayList productList1 = new ArrayList();
            productList1.Add(p1);
            productList1.Add(p2);
            productList1.Add(b1);

            Product p = (Product)productList1[0];
            Console.WriteLine("Use a list...");

            List<Product> productList2 = new List<Product>(0);
            productList2.Add(p1);
            productList2.Add(p2);
            productList2.Add(b1);

            Product p3 = productList2[0];
            Dictionary<string,Product> productDict = new Dictionary<string, Product>();
            productDict.Add(p1.Code,p1);
            productDict.Add(p2.Code,p2);
            productDict.Add(b1.Code,b1);

            p = productDict["andr"];
            Console.WriteLine(p);


            Console.WriteLine("Bye.");

            }

        private static void PrintThreeNumbers(int a = 1, int b =2,int c=3) {
            Console.WriteLine(a + ", " + b + ", " + c);
            }

        private static string GetString(string prompt) {
            Console.WriteLine(prompt);
            string name = Console.ReadLine();
            return name;
            }

        /*       private static int GetInt(string prompt) {
                   int i = 0;
                   bool success = false;

                   while (!success) {
                       Console.Write(prompt);
                       string s = Console.ReadLine();
                       try {
                           i = Convert.ToInt32(s);
                           success = true;
                           }
                       catch (FormatException) {
                           Console.WriteLine("Error. Invalid entry!" + s);
                           }

                       }

                   return i;
                   }*/

        private static int GetInt(string prompt) {
            int i = 0;
            bool success = false;

            while (!success) {
                Console.Write(prompt);
                string s = Console.ReadLine();
               if (int.TryParse(s, out i)) {
                    success = true;
                    }
                else {
                    Console.WriteLine("Error - not a whole number: " + s);
                    }
                }

            return i;
            }
        }


    }

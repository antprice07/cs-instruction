using System;

namespace Day1Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Console.Write("abc");
            Console.WriteLine("xyz");

            Console.WriteLine("Enter a name: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("name = " + str1);*/

            /*Console.Write("Enter a whole number: ");
            int i1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a whole number: ");
            int i2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sum = " + (i1 + i2));*/

          /*  string choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("hey");
                Console.Write("Continue? y/n: ");
                choice = Console.ReadLine();
            }*/

         /*   if (i2 > 5)
            {
                Console.WriteLine(i2 + " is greater than 5.");
            }
            else
            {
                Console.WriteLine(i2 + " is less than 5.");
            }*/

            Random rand = new Random();
            int r1 = rand.Next();
            Console.WriteLine("Random number = " +r1);

            Console.WriteLine("Generate random numbers between 1 and 10.");
            for (int i = 0; i < 10; i++)
            {
                r1 = rand.Next(10);
                Console.WriteLine("Random number = " + r1);
            }

            double d1 = 12345.67890;
            Console.WriteLine("double = " + d1);
            d1 = Math.Round(d1,2);
            Console.WriteLine("double now = " + d1);

            double price = d1;
            Console.WriteLine("formatted price: " + price.ToString("C2"));

            double pct = .036789;
            Console.WriteLine("formatted pct: " + pct.ToString("P3"));
            int i3 = 5;
            switch (i3) {
                case 1:
                    Console.WriteLine("i3 = 1");
                    break;
                case 2:
                    Console.WriteLine("i3 = 2");
                    break;
                case 3:
                    Console.WriteLine("i3 = 3");
                    break;
                case 4:
                    Console.WriteLine("i3 = 4");
                    break;
                case 5:
                    Console.WriteLine("i3 = 5");
                    break;
                default:
                    Console.WriteLine("Not between 1 and 5.");
                    break;
                }

            Console.WriteLine("bye");

        }
    }
}

using System;
using System.Globalization;

namespace Lektion1_opg8_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var culture = (CultureInfo) CultureInfo.CurrentCulture.Clone();
            culture.NumberFormat.NumberDecimalSeparator = ".";

            Boolean continuous = true;
            double num1 = 0; double num2 = 0;

            Console.WriteLine("Console Calculator\r");
            Console.WriteLine("------------------\n");
            while (continuous)
            {
                Console.WriteLine("Type a number, and then press enter");
                num1 = Convert.ToDouble(Console.ReadLine(), culture);

                Console.WriteLine("Type another number, and then press Enter");
                num2 = Convert.ToDouble(Console.ReadLine(), culture);

                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "s":
                        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "m":
                        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "d":
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                        break;
                }

                Console.Write("Press Y for continuous usage of the calculator or N to close the application\n");
                Console.Write("y/n\n");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Y:
                        break;
                    case ConsoleKey.N:
                        continuous = false;
                        break;
                }
            }
        }
    }
}

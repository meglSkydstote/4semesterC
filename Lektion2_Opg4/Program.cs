using System;

namespace Lektion2_Opg4
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean continuous = true;
            int num = 0;
            int age;
            Console.WriteLine("Enter year of birth\r");
            Console.WriteLine("------------------\n");
            while (continuous)
            {
                Console.WriteLine("Input birth year, and then press enter (type 0 to close the application)");
                num = Convert.ToInt32(Console.ReadLine());
                if (0 == num)
                {
                    continuous = false;
                }
                else
                {
                    Console.WriteLine("You are " + CalcAge(in num, out age) + " years old or will be by the end of year " + DateTime.Now.Year);
                }
            }
        }

        static int CalcAge(in int birthYear, out int age)
        {
            age = DateTime.Now.Year - birthYear;
            return age;
        }
    }
}

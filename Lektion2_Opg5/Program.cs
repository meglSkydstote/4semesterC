using System;
using System.Collections.Generic;
using System.Text;

namespace Lektion2_Opg5
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean continuous = true;
            int num = 0;

            Console.WriteLine("Generate list of random numbers\r");
            Console.WriteLine("------------------\n");
            while (continuous)
            {
                Console.WriteLine("Type a how many numbers you'd like, and then press enter (type 0 to close the application)");
                num = Convert.ToInt32(Console.ReadLine());
                if (0 == num)
                {
                    continuous = false;
                }
                else
                {
                    Console.WriteLine(generateRandomNumbers(num));
                }
            }
        }

        static string generateRandomNumbers(int amount)
        {
            var random = new Random();
            int randomNumber;
            List<int> arr = new List<int>();

            for (int i = 0; i < amount; i++)
            {
                randomNumber = random.Next(10, 100);
                arr.Add(randomNumber);
            }


            var sb = new StringBuilder();
            foreach (int num in arr)
            {
                sb.Append(num + "  ");
            }
            return sb.ToString();
        }
    }
}

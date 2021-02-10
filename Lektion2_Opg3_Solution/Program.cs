using System;
using System.Collections.Generic;
using System.Text;

namespace Lektion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean continuous = true;
            int num = 0; 
            
            Console.WriteLine("Generate Fibunacci\r");
            Console.WriteLine("------------------\n");
            while (continuous)
            {
                Console.WriteLine("Type a number, and then press enter (type 0 to close the application)");
                num = Convert.ToInt32(Console.ReadLine());
                if(0 == num)
                {
                    continuous = false;
                } else
                {
                    Console.WriteLine(generateNaci(num));
                }
            }
        }

        static string generateNaci(int max)
        {
            int next = 1;
            int before = 1;
            int placeholder = next;
            List<int> arr = new List<int>();
            arr.Add(next);
            arr.Add(before);

            while ((next + before) < max)
            {
                placeholder = next;
                next += before;
                before = placeholder;
                arr.Add(next);
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

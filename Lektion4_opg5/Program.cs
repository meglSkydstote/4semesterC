using System;

namespace Lektion4_opg5
{
    class Program
    {
        public static double Max(double[] arr)
        {
            double max = 0;
            foreach (double num in arr)
            {
                if(num > max)
                {
                    max = num;
                }
            }

            return max;
         
        }

        static void Main(string[] args)
        {   
            double[] arr1 = new double[2]{ 28.5, 17.2};
            double[] arr2 = new double[5] { 4.0, 10.8, 34.25, 2.0, 23.6 };

            double m1 = Max(arr1);
            double m2 = Max(arr2);

            Console.WriteLine(m1 + " " + m2);
            Console.ReadLine();

        }
    }
}

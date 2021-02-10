using System;

namespace Lektion2_Opg6
{
    class Program
    {
        static void Main(string[] args) { 
            MyNormalMethod(1); 
            Console.ReadLine(); 
        }

        public static void MyNormalMethod(int num = 0) { 
            try { 
                MyMethodWithError(1); 
            } catch { 
                Console.WriteLine("Error caught."); 
            } finally { 
                Console.WriteLine("Finally reached."); 
            } 

        static void MyMethodWithError(int num = 0) { 
                throw new Exception(); 
            }
    }
}
}

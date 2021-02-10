using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication3 { 
    class Program { 
        static void Main(string[] args) {

            int a = 7; 
            IncrementValueInt(ref a); 
            Console.WriteLine(a); 

            Integer A = new Integer(7); 
            IncrementValue(A); 
            Console.WriteLine(A.value); 
            Console.ReadLine(); 
        } 
        
        private static void IncrementValue(Integer A) { 
            A.value = A.value + 1; 
        } 
        
        private static void IncrementValueInt(ref int a) {
            a += 1; 
        } 
    } 
    class Integer { 
        public int value; 
        public Integer(int val) {
            value = val; 
        } 
    } 
}
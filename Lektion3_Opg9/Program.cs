using System;

namespace Lektion3_Opg9
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Saul;60;63";
            var person = new Person(s);
            Console.WriteLine(person);
            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Weight { get; set; }

        public Person(string format)
        {
            string[] arr = format.Split(";");
            Name = arr[0];
            Age = arr[1];
            Weight = arr[2];
        }

        public override string ToString()
        {
            return String.Format("{0,-7} : {1,2} years, {2,0}kg",
            Name, Age, Weight);
        }
    }
}

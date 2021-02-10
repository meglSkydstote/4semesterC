using System;

namespace Lektion3_Opg6
{
    class Program
    {
        static void Main(string[] args)
        {
            var mc = new MyClass(56);
            Console.WriteLine(mc);
            Console.ReadLine();
        }
    }

    class MyClass
    {

        public int Arg { get; set; }
        public MyClass(int arg)
        {
            Arg = arg;
        }
        // Arguments = values to said parameters. Parameters = name of argumenets.
        public override string ToString()
        {
            return "MyClass's Arg was created with value " + Arg;
        }
    }
}

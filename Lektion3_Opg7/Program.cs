using System;

namespace Lektion3_Opg7
{
    class Program
    {
        static void Main(string[] args)
        {
            var mc = new MyClass(56);
            mc.Arg = 65;
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

        public override string ToString()
        {
            return "MyArg was set to " + Arg;
        }
    }
}

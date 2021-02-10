using System;
using System.Collections.Generic;
using System.Text;

namespace Lektion3_Opg1
{
    class Person
    {
        public String Name { get; set; }
        public String Address { get; set; }

        public Person(String name, String address)
        {
            Name = name;
            Address = address;
        }

        public virtual String toString()
        {
            return "Person wuhu";
        }

        public virtual int calcSalary()
        {
            return 0;
        }
    }
}

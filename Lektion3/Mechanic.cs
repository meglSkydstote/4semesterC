using System;
using System.Collections.Generic;
using System.Text;

namespace Lektion3_Opg1
{
    class Mechanic : Person
    {
        public int YearDone { get; set; }
        public int HourlyWage { get; set; }

        public Mechanic(String name, String address, int yearDone, int hourlyWage) : base(name, address)
        {
            YearDone = yearDone;
            HourlyWage = hourlyWage;
        }

        public Mechanic(String name, String address, int yearDone) : base(name, address)
        {
            YearDone = yearDone;
        }

        public override int calcSalary()
        {
            return HourlyWage * 37;
        }

        public override String toString()
        {
            return "Name: " + Name + " | Address: " + Address + " | Completed mechanic education year: " + YearDone + " | Hourly wage: " + HourlyWage + " | Weekly Salary: " + calcSalary();
        }
    }
}

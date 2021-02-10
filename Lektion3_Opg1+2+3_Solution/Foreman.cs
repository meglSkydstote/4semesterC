using System;
using System.Collections.Generic;
using System.Text;

namespace Lektion3_Opg1
{
    class Foreman : Mechanic
    {
        public int ForemanYear { get; set; }
        public int WeeklyBonus { get; set; }

        public Foreman(String name, String address, int yearDone, int hourlyWage, int foremanYear, int weeklyBonus) : base(name, address, yearDone, hourlyWage)
        {
            ForemanYear = foremanYear;
            WeeklyBonus = weeklyBonus;
        }

        public override int calcSalary()
        {
            return HourlyWage * 37 + WeeklyBonus;
        }

        public override String toString()
        {
            return "Name: " + Name + " | Address: " + Address + " | Completed mechanic education year: " + YearDone + " | Hourly wage: " + HourlyWage + " | Became foreman " + ForemanYear + " | Weekly bonus: " + WeeklyBonus + " | Weekly Salary: " + calcSalary();
        }
    }
}

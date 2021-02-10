using System;
using System.Collections.Generic;
using System.Text;

namespace Lektion3_Opg1
{
    class Surveyor : Mechanic
    {
        public int WeeklySalary { get; set; }
        public int Salary { get; set; }
        public int WeeklyVehicleInspection { get; set; }

        public Surveyor(String name, String address, int yearDone, int weeklyVehicleInspection) : base(name, address, yearDone)
        {
            WeeklyVehicleInspection = weeklyVehicleInspection;
            Salary = 290;
            calcWeeklySalary();
        }

        public void calcWeeklySalary()
        {
            WeeklySalary = Salary * WeeklyVehicleInspection;
        }

        public override int calcSalary()
        {
            return WeeklySalary;
        }

        public override String toString()
        {
            return "Name: " + Name + " | Address: " + Address + " | Completed mechanic education year: " + YearDone + " | Salary per inspection " + Salary + " | Weekly salary: " + WeeklySalary + " | Weekly Salary: " + calcSalary();
        }
    }
}

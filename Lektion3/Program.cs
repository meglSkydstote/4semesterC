using System;
using System.Collections.Generic;

namespace Lektion3_Opg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mechanic m1 = new Mechanic("Henri", "En Vej", 1990, 215);
            Mechanic m2 = new Mechanic("Samri", "Eton Vej", 1995, 225);
            Mechanic m3 = new Mechanic("Velkro", "Etren Vej", 2000, 210);

            Foreman f1 = new Foreman("Boss1", "Bedst Vej", 1980, 300, 1992, 1500);

            Surveyor s1 = new Surveyor("Kiggemanden", "Bedst Vej", 1989, 5);

            List<Person> arr = new List<Person>();
            arr.Add(m1);
            arr.Add(m2);
            arr.Add(m3);
            arr.Add(f1);
            arr.Add(s1);

            foreach (Person p in arr)
            {
                Console.WriteLine(p.toString());
            }

            s1.WeeklyVehicleInspection = 20;
            s1.calcWeeklySalary();
            f1.WeeklyBonus = 4000;
            m3.HourlyWage = 500;

            Console.WriteLine("");

            foreach (Person p in arr)
            {
                Console.WriteLine(p.toString());
            }

            Console.ReadLine();
        }
    }

    //class Person
    //{
    //    public String Name { get; set; }
    //    public String Address { get; set; }

    //    public Person(String name, String address)
    //    {
    //        Name = name;
    //        Address = address;
    //    }

    //    public virtual String toString()
    //    {
    //        return "Person wuhu";
    //    }
    //}

    //class Mechanic : Person
    //{
    //    public int YearDone { get; set; }
    //    public int HourlyWage { get; set; }

    //    public Mechanic(String name, String address, int yearDone, int hourlyWage) : base(name, address)
    //    {
    //        YearDone = yearDone;
    //        HourlyWage = hourlyWage;
    //    }

    //    public Mechanic(String name, String address, int yearDone) : base(name, address)
    //    {
    //        YearDone = yearDone;
    //    }

    //    public override String toString()
    //    {
    //        return "Name: " + Name + " | Address: " + Address + " | Completed mechanic education year: " + YearDone + " | Hourly wage: " + HourlyWage;
    //    }
    //}

    //class Foreman : Mechanic
    //{
    //    public int ForemanYear { get; set; }
    //    public int WeeklyBonus { get; set; }

    //    public Foreman(String name, String address, int yearDone, int hourlyWage, int foremanYear, int weeklyBonus) : base(name, address, yearDone, hourlyWage)
    //    {
    //        ForemanYear = foremanYear;
    //        WeeklyBonus = weeklyBonus;
    //    }

    //    public override String toString()
    //    {
    //        return "Name: " + Name + " | Address: " + Address + " | Completed mechanic education year: " + YearDone + " | Hourly wage: " + HourlyWage + " | Became foreman " + ForemanYear + " | Weekly bonus: " + WeeklyBonus;
    //    }
    //}

    //class Surveyor : Mechanic
    //{
    //    public int WeeklySalary { get; set; }
    //    public int Salary { get; set; }
    //    public int WeeklyVehicleInspection { get; set; }

    //    public Surveyor(String name, String address, int yearDone, int weeklyVehicleInspection ) : base(name, address, yearDone)
    //    {
    //        WeeklyVehicleInspection = weeklyVehicleInspection;
    //        Salary = 290;
    //        calcWeeklySalary();
    //    }

    //    public void calcWeeklySalary()
    //    {
    //        WeeklySalary = Salary * WeeklyVehicleInspection;
    //    }

    //    public override String toString()
    //    {
    //        return "Name: " + Name + " | Address: " + Address + " | Completed mechanic education year: " + YearDone + " | Salary per inspection " + Salary + " | Weekly salary: " + WeeklySalary;
    //    }
    //}
}

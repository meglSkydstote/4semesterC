using System;
using System.Collections.Generic;

namespace Lektion3_Opg4
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1, t2;
            t1 = new Time("08:30:00");
            t2 = t1;
            Console.WriteLine(t1.ToString());
            Console.WriteLine(t2.ToString());
            Console.ReadLine();
        }
    }

    struct Time
    {
        public int Timestamp {get; set;}
        public string Hours { get; set; }
        public string Minutes { get; set; }
        public string Seconds { get; set; }

        public Time(string timestamp)
        {
            Timestamp = 0;
            string[] arr = timestamp.Split(":");
            Hours = arr[0];
            Minutes = arr[1];
            Seconds = arr[2];
            calcTimestamp(timestamp);
        }

        public void calcTimestamp(string timestamp)
        {
            int timeInSeconds = 0;
            string[] arr = timestamp.Split(":");
            for(int i = 0; i < arr.Length; i++)
            {
                if(i == 0)
                {
                    timeInSeconds += Int32.Parse(arr[i]) * 60 * 60;
                } else if (i == 1)
                {
                    timeInSeconds += Int32.Parse(arr[i]) * 60;
                } else
                {
                    timeInSeconds += Int32.Parse(arr[i]);
                }
            }
            Timestamp = timeInSeconds;
        }

        public override string ToString()
        {
            return Hours + ":" + Minutes + ":" + Seconds;
        }
    }    
}

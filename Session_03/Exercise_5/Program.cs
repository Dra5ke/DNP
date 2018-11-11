using System;

namespace Exercise_5
{
    class Time
    {
        int hours;
        int minutes;
        public Time(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        public int Hours { get => hours; set => hours = value; }
        public int Minutes { get => minutes; set => minutes = value; }
        public String toString()
        {
            return "Hours: " + hours + ", Minutes: " + minutes;
        }
        public static Time operator +(Time t1, Time t2) => new Time(t1.Hours + t2.Hours, t1.Minutes + t2.Minutes);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time(1, 1);
            Time time2 = new Time(1, 2);

            System.Console.WriteLine((time1 + time2).toString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_3
{
    partial class Time
    {
        public int hour;
        public int min;
        public int sec;
        private readonly int ID;
        private static int countOfObject = 0;

        public int Hours
        {
            get
            {
                return hour;
            }
            set
            {
                if (value >= 0 && value <= 24)
                {
                    hour = value;
                }

            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    min = value;
                }
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    sec = value;
                }
            }
        }

        //std data
        const int stdHour = 10;
        const int stdMin = 10;
        const int stdSec = 10;

        //construktor
        public Time(int hour_, int min_, int sec_)
        {
            hour = hour_;
            min = min_;
            sec = sec_;
            ID = hour.GetHashCode() + min.GetHashCode();
            countOfObject++;
        }


        public Time(int hour_, int min_)
        {
            hour = hour_;
            min = min_;
            sec = stdSec;
            ID = hour.GetHashCode() + min.GetHashCode();
            countOfObject++;
        }

        public Time()
        {
            hour = stdHour;
            min = stdMin;
            sec = stdSec;
            ID = hour.GetHashCode() + min.GetHashCode();
            countOfObject++;
        }



        static Time()
        {
            Time One = new Time(1, 1, 1, true);
        }
        private Time(int hour_, int min_, int sec_, bool isOne)
        {
            isOne = true;
            hour = hour_;
            min = min_;
            sec = sec_;
            countOfObject++;
        }


        static public void aboutObject()
        {
            Console.WriteLine("Объектов создано");
            Console.WriteLine($"{countOfObject} штук.");
        }

        public void outputObj()
        {
            Console.WriteLine($"{hour}:{min}:{sec}");
        }

        public void ShowPeriodOfDay()
        {
            if (hour >= 0 && hour <= 6)
            {
                Console.WriteLine("Night time:");
                this.outputObj();
            }

            if (hour >= 7 && hour <= 12)
            {
                Console.WriteLine("Morning time:");
                this.outputObj();
            }

            if (hour >= 13 && hour <= 18)
            {
                Console.WriteLine("Day time:");
                this.outputObj();
            }

            if (hour >= 19 && hour <= 24)
            {
                Console.WriteLine("Evening time:");
                this.outputObj();
            }
        }

        public override string ToString()
        {
            return this.hour + " " + this.min + " " + this.sec;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Time a = obj as Time;
            if (a as Time == null)
            {
                return false;
            }
            return a.hour == hour;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

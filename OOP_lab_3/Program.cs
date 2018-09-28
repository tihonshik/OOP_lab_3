using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_3
{
    partial class Time
        {
        }
    class Program
    {
       
        static void Main(string[] args)
        {          
            Time first = new Time();
            Time second = new Time(14, 13);
            Time third = new Time(14, 30, 15);
            first.outputObj();
            second.outputObj();
            third.outputObj();

            Time[] arr = new Time[6];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = new Time(i+8, i*10, i*10);
                arr[i].ShowPeriodOfDay();
            }

            foreach (Time element in arr)
            {
                if (element.hour==1)
                {
                    element.outputObj();
                }
            }

            for (int i = 0; i < 6; i++)
            {
                if (second.Equals(arr[i]))
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("-");
                }
            }


        }
    }
}

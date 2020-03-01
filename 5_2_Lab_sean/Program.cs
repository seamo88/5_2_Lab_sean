using System;
using System.Collections.Generic;

namespace _5_2_Lab_sean
{
    class Program
    { 
         public enum WeekDays
         {

        Moday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

         }





    
        static void Main(string[] args)
        {
             //Create a list to hold tasks
            List<string> tasklist = new List<string>();

            //for each value in the Enum...let the user create a task.
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine("Enter a new task for" + day);
                string task = day + ":" + Console.ReadLine();
                tasklist.Add(task);

            }

            //print all of the tasks.
            foreach(string task in tasklist)
            {
                Console.WriteLine(task);
            }


        }
    }
}

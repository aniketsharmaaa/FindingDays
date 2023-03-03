using System;

namespace FindingDays;

class Program
{
    static void Main(string[] args)
    {
        int[] listOfInt = { 2, 4, 5 }; //Days of the week as integers
        DateTime startDate = new DateTime(2023, 1, 1); // Start Date
        DateTime endDate = new DateTime(2023, 6, 1); // End Date

        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            //Check if the day of the week is one of the days in the list
            if(Array.IndexOf(listOfInt, (int)date.DayOfWeek) != -1)
            {
                Console.WriteLine(date.ToString("yyyy-MM-dd") + " is a " + date.DayOfWeek.ToString());
            }
        }

        Console.ReadKey();
    }
}
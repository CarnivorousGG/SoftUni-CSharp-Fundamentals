using System;
using System.Globalization;

//Write a program that reads two dates in format dd-MM- yyyy and prints the number of working days between
//these two dates inclusive.Non-working days are:
// All days that are Saturday or Sunday.
// All days that are official holidays in Bulgaria:
//o New Year Eve(1 Jan)
//o Liberation Day(3 March)
//o Worker’s day(1 May)
//o Saint George’s Day(6 May)
//o Saints Cyril and Methodius Day(24 May)
//o Unification Day(6 Sept)
//o Independence Day(22 Sept)
//o National Awakening Day(1 Nov)
//o Christmas(24, 25 and 26 Dec)

namespace _01._Count_Working_Days
{
    class StartUp
    {
        static void Main()
        {
            //read two dates from user input
            DateTime startDate = DateTime.
                ParseExact(Console.ReadLine(), "dd-MM-yyyy",
                CultureInfo.InvariantCulture);
            DateTime endDate = DateTime
                .ParseExact(Console.ReadLine(), "dd-MM-yyyy",
                CultureInfo.InvariantCulture);


            //creating an array to hardcode all given holiday dates
            DateTime[] holidays =
            {
                DateTime
                .ParseExact("01-01-2016", "dd-MM-yyyy",
                CultureInfo.InvariantCulture),

                DateTime
                    .ParseExact("03-03-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),

                DateTime
                    .ParseExact("01-05-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),

                DateTime
                    .ParseExact("06-06-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),

                DateTime
                    .ParseExact("24-05-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("06-09-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("22-09-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("01-11-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),

                DateTime
                    .ParseExact("24-12-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),

                DateTime
                    .ParseExact("25-12-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),
                DateTime
                    .ParseExact("26-12-2016", "dd-MM-yyyy",
                        CultureInfo.InvariantCulture),


        };

            int countWorkingDays = 0; //create a counter for the working days

            for (DateTime currentDate = startDate;
                currentDate <= endDate;
                currentDate = currentDate.AddDays(1)) //we add 1 day to the start date each time the loop continues
            {
                if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    bool isNotHoliday = true;

                    foreach (var holiday in holidays)
                    {
                        //check the current day and month and compare to the holidays
                        if (holiday.Day == currentDate.Day && holiday.Month == currentDate.Month)
                        {
                            isNotHoliday = false;
                            break; //when we find a holiday we stop the foreach
                        }
                    }
                    if (isNotHoliday) //if the date is not a holiday we increate our count
                    {
                        countWorkingDays++;
                    }
                }
            }

            Console.WriteLine(countWorkingDays);
        }

    }
}

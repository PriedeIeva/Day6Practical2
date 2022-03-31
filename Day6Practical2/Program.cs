//practical2
using System;
namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var variableTime = 20;
            var variableTime2 = variableTime - 2;

            if (variableTime2 < 12)
            {
                Console.WriteLine("Good Morning Sunshine!");
            }
            else if (variableTime2 > 12 && variableTime2 < 19)
            {
                Console.WriteLine("Good Afternoon.Work Hard!");
            }
            else
            {
                Console.WriteLine("Good Evening.Get some rest!");
            }

            string enteredDay;
            string enteredMonth;
            string enteredYear;
            string choosenFormating;

            Console.WriteLine("\n Please write the day: ");
            enteredDay = Console.ReadLine();
            int intDay = int.Parse(enteredDay);

            if (intDay < 0)
            {
                Console.WriteLine("Day can not be zero or negative number");
                Console.WriteLine("Please write the day again");
                enteredDay = Console.ReadLine();
            }
            else if (intDay > 31)
            {
                Console.WriteLine("Day number can not be biger than 31");
                Console.WriteLine("Please write the day again");
                enteredDay = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"your entered number {intDay} number is correct");
            }


            Console.WriteLine("Please write the month");
            enteredMonth = Console.ReadLine();
            int intMonth = int.Parse(enteredMonth);
            if (intMonth <= 0)
            {
                Console.WriteLine("Month can not be zero or negative number");
                Console.WriteLine("Please write the month again");
                enteredMonth = Console.ReadLine();
            }
            else if (intMonth > 12)
            {
                Console.WriteLine("Month number can not be biger than 12");
                Console.WriteLine("Please write the month again");
                enteredMonth = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"your entered number {intMonth} number is correct");
            }

            Console.WriteLine("Please write the year");
            enteredYear = Console.ReadLine();
            int intYear = int.Parse(enteredYear);
            if (intYear <= 0)
            {
                Console.WriteLine("Year can not be zero or negative number");
                Console.WriteLine("Please write the year again");
                enteredYear = Console.ReadLine();
            }
            else if (intYear > 2023)
            {
                Console.WriteLine("We live in 2022, so year can not be bigger than that");
                Console.WriteLine("Please write the year again");
                enteredYear = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Your entered Year number {intYear} is correct");
            }


            Console.WriteLine(" Please select the date formatting. \n 1 - YYYY / MM / DD, \n 2 - YYYY.MM.DD \n your decision:");
            choosenFormating = Console.ReadLine();
            int intFormating = int.Parse(choosenFormating);

            if (intFormating == 1)
            {
                Console.WriteLine($"The entered date is {intYear} / {intMonth } / {intDay}");
            }

            else if (intFormating == 2)
            {
                Console.WriteLine($"The entered date is {intDay} / {intMonth } / {intYear}");
            }
            else
            {
                Console.WriteLine("something is wrong, lets try again");
                Console.WriteLine(" Please select the date formatting. \n 1 - YYYY / MM / DD, \n 2 - YYYY.MM.DD \n your decision:");
                choosenFormating = Console.ReadLine();

            }


        }


    }
}

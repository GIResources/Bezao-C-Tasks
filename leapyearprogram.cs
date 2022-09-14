using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearProgramme
{
/*
Console.WriteLine("The List below are Twenty Leap Years from 2022");

        for (int year = 2022; year <= 2104; year++)
        {
            if (DateTime.IsLeapYear(year))
            {
                  Console.WriteLine("{0}", year);
                    
            }
            */
  class Leap_year
    {
        static void LeapYear()
        {
            int inputtedYear;

            Console.WriteLine("Please enter the current year");

            inputtedYear = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 80; i++)
            {
                if ((inputtedYear % 4) == 0 || (inputtedYear % 4) == 0 && (inputtedYear % 100) != 0)
                {
                    Console.WriteLine("{0}", inputtedYear);
                }
                inputtedYear++;
            }
        }

        static void Main(string[] args)
        {
            LeapYear();
            Console.ReadLine();

        }
    }

}
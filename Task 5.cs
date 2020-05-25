using System;

/*Check whether the entered year is a leap.*/
namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year, please");
            int year = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Year, you have just entered is leap");
            }
            else
            {
                Console.WriteLine("Year, you have just entered is NOT leap");
            }
        }
    }
}

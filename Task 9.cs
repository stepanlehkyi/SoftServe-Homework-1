using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Ask user to enter the number of month. Read the value and write the amount of days in this month.*/
namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    while (true)
                    {
                        Console.WriteLine("Enter a month number, please: ");
                        int monthNumber = Convert.ToInt32(Console.ReadLine());
                        int daysInMonth = DateTime.DaysInMonth(2001, monthNumber);
                        Console.WriteLine(daysInMonth);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

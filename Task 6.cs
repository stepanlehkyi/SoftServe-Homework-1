using System;
/*Find the sum of digits of the entered integer number*/
namespace Task_6
{
    class Program
    {
        public static int sumOfDigit( int digit)
        {

            if (digit == 0)
                return 0;

            return (digit % 10 + sumOfDigit(digit / 10));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a digit: ");
            int number = int.Parse(Console.ReadLine());
            int sum = sumOfDigit(number);
            Console.WriteLine(sum);

        }
    }
}

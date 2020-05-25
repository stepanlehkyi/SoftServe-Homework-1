using System;

/*Input a sequence of positive integers (to the first negative). Calculate the arithmetic average of the
entered numbers.*/
namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = 0;
            int sumOfInteger = 0;
            int quantityOfInteger = 0;

            Console.WriteLine("Enter a sequence of positive integers");
            do
            {
                integer = int.Parse(Console.ReadLine());
                if (integer > 0)
                {
                    sumOfInteger += integer;
                    quantityOfInteger++;
                }

            }
            while (integer > 0);

            
            Console.WriteLine($"Arithmetic average of entered number is {sumOfInteger/quantityOfInteger}");

        }
    }
}

using System;
/*Input a and b are two integers. Calculate how many integers in the range [a..b] are divided by 3
without remainder.*/
namespace Task_1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b: ");
            int b = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} integers in the range [{a}...{b}] are divided by 3 without remainder.");

        }
    }
}

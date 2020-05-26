using System;
using System.Collections.Generic;

namespace Task_7
{
    class Program
    {
     public static int[] numberToArrayOfNumbers(int number)
        {
            char[] numberToChar = number.ToString().ToCharArray();
            int[] numbers = new int[numberToChar.Length];
            for(int i = 0; i < numberToChar.Length; i++)
            {
                numbers[i] = Convert.ToInt32(numberToChar[i]);
            }
            return numbers;

        }   
        public static bool isAllOddNumbers(int number)
        {
            int count = 0;
            int[] numbers = numberToArrayOfNumbers(number);
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
            }
            if (numbers.Length == count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(isAllOddNumbers(number));


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Input 10 integer numbers. Calculate the sum of first 5 elements if they are positive or product of last 5
element in the other case.*/
namespace Task_10
{
    class Program
    {
        public static bool isFiveElementsPositive(int[] array)
        {
            int count = 0;
            for(int i = 0; i < 5; i++)
            {
                if (array[i] > 0)
                {
                    count++;
                }
            }
            if (count == 5)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int sumOfElements = 0;
            int productOfElements = 1;
            Console.WriteLine("Enter 10 integer numbers");
            for(int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (isFiveElementsPositive(array))
            {
                for(int i = 0; i < 5; i++)
                {
                    sumOfElements += array[i];
                }
                Console.WriteLine($"Sum of elements = {sumOfElements}");
            }
            else
            {
                for(int i = 5; i < array.Length; i++)
                {
                    productOfElements *= array[i];
                }
                Console.WriteLine($"Product of elements = {productOfElements}");
            }


        }
    }
}

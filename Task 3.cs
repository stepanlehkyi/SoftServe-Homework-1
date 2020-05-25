using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Input the name of the drink (coffee, tea, juice, water). Print the name of the drink and its price.*/
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the drink (coffee, tea, juice, water)");
            string nameOfDrink = Console.ReadLine();
            switch (nameOfDrink)
            {
                case "coffee":
                    {
                        Console.WriteLine("Coffee - 4.99$ ");
                        break;
                    }
                case "tea":
                    {
                        Console.WriteLine("Tea - 3.99$");
                        break;
                    }
                case "juice":
                    {
                        Console.WriteLine("Juice - 9.99$");
                        break;
                    }
                case "water":
                    {
                        Console.WriteLine("Water- 0.99$");
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"We haven't got any {nameOfDrink}, please choose from coffee, tea, juice or water ");
                        break;
                    }
            }

        }
    }
}

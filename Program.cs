using System;


namespace Homework_task_1
{
    /*Task 2

Identify enum TestCaseStatus (Pass, Fail, Blocked, WP, Unexecuted). Assign
status “Pass” for the variable test1Status and print the value of the variable console.

Determine RGB structure that represents the color with fields red, green, blue (type
byte). Identify two variables of this type and enter their fields for white and black
colors.

Create Console Application project in VS.

In method Main() write code for solving next task:

read number of HTTP Error (400, 401,402, ...) and write the name of this error (Declare enum
HTTPError)

declare struct Dog with fields Name, Mark, Age. Declare variable myDog of Dog type and read
values for it. Output myDos into console. (Declare method ToString in struct)*/
    class Program
    {
        enum TestCaseStatus{Pass, Fail, Blocked, WP, Unexecuted};
        enum HTTPError {BadRequest=400 , Unauthorized =401, PaymentRequired=402, Forbidden =403, NotFound =404 };
       struct RGB
        {
         public   byte Red;
         public   byte Green;
          public  byte Blue;
        };
        struct Dog
        {
           public string Name;
            public string Mark;
            public string Age;
            public override string ToString()
            {
                return $"Name of dog: {this.Name},\nMark of dog: {this.Mark},\nDog age: {this.Age} years";
            }
        }
        static void Main(string[] args)
        {
            var test1Status = TestCaseStatus.Pass;
            Console.WriteLine(test1Status);
            RGB white,black;
            white.Red = 0;
            white.Green = 0;
            white.Blue = 0;
            black.Red = 1;
            black.Green = 1;
            black.Blue = 1;
            Console.WriteLine("Enter error number");
            int errorNumber = int.Parse(Console.ReadLine());
            switch (errorNumber)
            {
                case 400:
                    {
                        Console.WriteLine(HTTPError.BadRequest);
                        break;
                    }
                case 401:
                    {

                        Console.WriteLine(HTTPError.Unauthorized);
                        break;
                    }
                case 402:
                    {
                        Console.WriteLine(HTTPError.PaymentRequired);
                        break;
                    }
                case 403:
                    {
                        Console.WriteLine(HTTPError.Forbidden);

                        break;
                    }
                case 404:
                    {
                        Console.WriteLine(HTTPError.NotFound);

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a number beetwen 400 and 404");
                        break;
                    }
            }
            Dog myDog;
            myDog.Name = "Askold";
            myDog.Mark = "Dog";
            myDog.Age = "3";
            Console.WriteLine(myDog.ToString());
        }
    }
}

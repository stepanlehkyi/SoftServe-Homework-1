using System;

/*Input a character string. Print each second character*/
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence, please: ");
            string sentence = Console.ReadLine();
            char[] charArraytoPrint = sentence.ToCharArray();
            for(int i = 0; i < charArraytoPrint.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(charArraytoPrint[i]);
                }
            }
            Console.WriteLine();

        }
    }
}

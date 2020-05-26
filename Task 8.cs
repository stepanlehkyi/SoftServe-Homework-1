using System;
/*Read the text as a string value and calculate the counts of characters 'a', 'o', 'i', 'e' in this text.*/
namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Did you know ... The Japanese pygmy woodpecker(Yungipicus kizuki) is a species of woodpecker native to coniferous and deciduous forests in Russia, China, North Korea, South Korea and Japan.";
            int aCounter=0, oCounter=0, iCounter=0, eCounter =0;
     
            for(int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        {
                            aCounter++;
                            break;
                        }
                    case 'o':
                        {
                            oCounter++;
                            break;
                        }
                    case 'i':
                        {
                            iCounter++;
                            break;
                        }
                    case 'e':
                        {
                            eCounter++;
                            break;
                        }
                }

            }
            Console.WriteLine($"In this text we have {aCounter} - a, {oCounter} - o, {iCounter} - i, {eCounter} - e");

        }
    }
}

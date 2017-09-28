using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_English_NameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            
            LastDigitEnglishName(input);
            Console.WriteLine(input );
        }
        static string LastDigitEnglishName(int input)
        {
            int lastDigit = input%10;
            string lastDigitOnEnglish = "zero";
            switch (lastDigit)
            {
                case 1:
                    lastDigitOnEnglish = "one";break;
                case 2:
                    lastDigitOnEnglish = "two"; break;
                case 3:
                    lastDigitOnEnglish = "three"; break;
                case 4:
                    lastDigitOnEnglish = "four"; break;
                case 5:
                    lastDigitOnEnglish = "five"; break;
                case 6:
                    lastDigitOnEnglish = "six"; break;
                case 7:
                    lastDigitOnEnglish = "seven"; break;
                case 8:
                    lastDigitOnEnglish = "eight"; break;
                case 9:
                    lastDigitOnEnglish = "nine"; break;


                default:lastDigitOnEnglish = "zero";break;
            }
            
            return lastDigitOnEnglish;
            
                
        }
    }
}

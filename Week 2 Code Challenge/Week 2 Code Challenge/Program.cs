using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            //calll LetterCounter function
            LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down");
            LetterCounter('s', "Sally sells seashells down by the seashore. She's from sussex");

            //loop through 0 - 20, calling fizzbuzz for every number
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);   
                
            }
            
            Console.ReadKey();
            
        }



        static void LetterCounter(char letter, string inString)
        {
            //declare variables to represent number of letters
            int numOfUpperCase = 0;
            int numOfLowerCase = 0;
            int numOfTotalLetters = 0;
                
            //create a string variable to represent lower case letters
            string repLowerCase = letter.ToString();
            repLowerCase = repLowerCase.ToLower();




            //create a for loop that counts from 0 to the length of the inString parameter then adds one
            for (int i = 0; i < inString.Length; i++)
            {
                //declare a string variable called selectedLetter which is equal to the inString parameter character that it converts to a string.
                string selectedLetter = inString[i].ToString();

                //ask if the character is = to the letter
                if (inString[i] == letter)
                {
                    //if the letter is lower case
                    if (selectedLetter == repLowerCase)
                    {
                        //add to the counted number of lower case letters.
                        numOfLowerCase++;
                    }
                    else
                    {
                        //add to the number of upper case letters
                        numOfUpperCase++;
                    }
                    numOfTotalLetters++;
                }
            }
        }



        //create a fizzbuzz function
        static void FizzBuzz(int number)
        {
            //if the number is divisible by 5 write "Fizz"
            if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
                //if the number is divisible by 3 write "Buzz"
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
                //if the number is divisible by 5 & 3 then write "FizzBuzz"
            else if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
                //print the number
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}

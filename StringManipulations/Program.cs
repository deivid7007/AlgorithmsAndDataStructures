using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulations
{
    class Program
    {


        static void Main(string[] args)
        {
            try
            {
                // Variables

                string[] subStrings = new string[100];
                string firstString = Console.ReadLine(); /*"Shteigraempokerdnespokerislovepokerislive";*/
                string secondString = Console.ReadLine();/*"poker";*/
                string currentString = firstString;
                int counterOfSubstring = 0;
                string newStringForCoding = null;
                char[] codedChars = new char[20000];
                string codeString = null;
                int currentInteger = 0;
                int positionOfFirstSub;

                // Splitiing the string in poker

                for (int i = 0; i < subStrings.Length; i += 2)
                {
                    positionOfFirstSub = currentString.IndexOf(secondString);
                    if (positionOfFirstSub >= 0)
                    {
                        subStrings[i] = currentString.Substring(0, positionOfFirstSub);
                        subStrings[i + 1] = currentString.Substring(positionOfFirstSub, secondString.Length);
                        currentString = currentString.Substring(positionOfFirstSub + secondString.Length);
                        positionOfFirstSub = 0;
                    }
                    else if (positionOfFirstSub == -1)
                    {
                        subStrings[i] = currentString;
                        break;
                    }

                    else
                    {
                        break;
                    }
                }
                // Adding spaces and counting 

                for (int i = 0; i < subStrings.Length; i++)
                {

                    if (subStrings[i] == secondString)
                    {
                        subStrings[i] = " " + subStrings[i] + " ";
                        counterOfSubstring++;
                    }
                    else if (subStrings[i] == null)
                    {
                        break;
                    }
                    newStringForCoding += subStrings[i];
                    Console.Write(subStrings[i]);
                }


                Console.WriteLine();
                Console.WriteLine($"The word {secondString} is contained {counterOfSubstring} times in your string.");
                Console.WriteLine();
                Console.WriteLine($"Your new string with spaces looks like this ---> { newStringForCoding}");
                Console.WriteLine();

                // Coding the string

                newStringForCoding = newStringForCoding.ToLower();

                for (int i = 0; i < newStringForCoding.Length; i++)
                {
                    currentInteger = (int)(newStringForCoding[i]);

                    if (currentInteger >= (int)'a' && currentInteger <= (int)'y')
                    {
                        currentInteger += 1;
                        codedChars[i] = (char)currentInteger;
                    }
                    else if (currentInteger == (int)'z')
                    {
                        currentInteger = (int)'a';
                        codedChars[i] = (char)currentInteger;
                    }
                    else if (currentInteger == ' ')
                    {
                        codedChars[i] = ' ';
                    }
                    else
                    {
                        break;
                    }
                }


                for (int i = 0; i < codedChars.Length; i++)
                {
                    codeString += codedChars[i];
                    if (codedChars[i] == 0)
                    {
                        break;
                    }
                }
                Console.WriteLine($"Coded string looks like this ---> {codeString}");
            }
            catch (Exception)
            {
                Console.WriteLine();
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Something went wrong please try again later :)");
                Console.WriteLine();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithOutsideFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> someStrings = new List<string>();
            string currentString;
            string filePath = @"E:\C# UnI Plovdiv 2017\AlgorithmsAndDataStructures\WorkingWithOutsideFiles\files\Strings.txt";
            StreamWriter writer = new StreamWriter(filePath);
            //StreamReader reader = new StreamReader(filePath);

            while (true)
            {
                Console.WriteLine("Enter your string: ");
                currentString = Console.ReadLine();
                currentString = currentString.ToUpper();

                if (currentString == "")
                {
                    break;
                }
                someStrings.Add(currentString);
            }

            foreach (var currentStrting in someStrings)
            {
                if ((int)currentStrting[0] >= 65 && (int)currentStrting[0] <=90)
                {
                    writer.WriteLine(currentStrting);
                }
            }
            writer.Close();

            Console.WriteLine();
            Console.WriteLine("Here we start reading the file: ");
            Console.WriteLine();

            StreamReader reader = new StreamReader(filePath);
            int counter = -1;
            string line = " ";

            while (line != null)
            {
               line = reader.ReadLine();
                counter++;
                Console.WriteLine(line);
            }
            Console.WriteLine($"There are {counter} elemnts in the document !");
            reader.Close();

        }
    }
}

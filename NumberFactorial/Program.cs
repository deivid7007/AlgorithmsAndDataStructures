using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> factorials = new Stack<int>();

            int fact = 1;
            Console.WriteLine("Enter the number which factorial you want to see: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = number; i > 0; i--)
            {
                fact = fact * i;
                factorials.Push(fact);
                Console.WriteLine(factorials.Pop());
            }

            
        }


    }
}

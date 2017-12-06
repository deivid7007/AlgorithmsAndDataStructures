using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_H1
{
    class Program
    {
        static int F(int x)
        {
            if (x < 1)
            {
               return 7 * x + 3;
            }
            else if (1 <= x && x < 10)
            {
                return 0;
            }
            

            else if (x >= 10)
            {
               return 2 * x * F(x - 5);
            }

            else
            {
                return 0;
            }
           
        }



        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Enter value for x in F(x): ");

            x = int.Parse(Console.ReadLine());

            Console.WriteLine($"F(x) = {F(x)}");
            


        }
    }
}

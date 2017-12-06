using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PointsAndCordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            int pointsNeeded = 0;
            List<Point> points = new List<Point>();

            Console.WriteLine("Enter how much random points you need: ");
            pointsNeeded = int.Parse(Console.ReadLine());

            int[] arrayX = new int[pointsNeeded];
            int[] arrayY = new int[pointsNeeded];

            for (int i = 0; i < pointsNeeded; i++)
            {
                int x = RandomPointGenerator();
                int y = RandomPointGenerator();
                Point randomPoint = new Point(x,y);
                points.Add(randomPoint);
            }

            Console.WriteLine("X array");
            arrayX = XYInArray(points,arrayX);
            PrintingArray(arrayX);
            Console.WriteLine("Y array");
            arrayY = XYInArray(points, arrayY);
            PrintingArray(arrayY);
            Console.WriteLine($"Minimal elem {arrayY.Min()}");

        }

        static int RandomPointGenerator()
        {
            Thread.Sleep(50);
            Random rand = new Random();
            int randomNumber = rand.Next(0, 15);
            return randomNumber;
        }

        static int[] XYInArray(List<Point> points, int[] arrayXY)
        {
            int currentElement = 0;
            foreach (var point in points)
            {
                arrayXY[currentElement] = point.x;
                currentElement++;
            }
            return arrayXY;
        }

        static void PrintingArray(int[] xy)
        {
            for (int i = 0; i < xy.Length; i++)
            {
                Console.Write($"{xy[i]}, ");
            }
            Console.WriteLine();
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankQueueSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Q1 = new Queue();
            Queue Q2 = new Queue();
            List<Client> Clients = new List<Client>();
            int minutesNeeded;
            string name;
            int counter = 0;
            int timeForQ1 = 0;
            int timeForQ2 = 0;
            int valueFromMin = 0;


            Console.WriteLine("Enter how much clients are there in the bank: ");
            int numberOfClients = int.Parse(Console.ReadLine());

            // Initializing clients

            for (int i = 0; i < numberOfClients; i++)
            {
                Console.WriteLine("Enter client name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter client needed minutes for the operation: ");
                minutesNeeded = int.Parse(Console.ReadLine());

                Client client = new Client(name, minutesNeeded);
                Clients.Add(client);
            }

            // Login into queues

            foreach (var client in Clients)
            {
                counter++;
                if (counter % 2 == 1)
                {
                    Q1.Enqueue(client);
                    timeForQ1 += client.MinutesNeeded;
                }

                else if (counter % 2 == 0)
                {
                    Q2.Enqueue(client);
                    timeForQ2 += client.MinutesNeeded;
                }
            }

            // Time needed for each queue to finish

            Console.WriteLine("***************************");
            Console.WriteLine($"Time needed for Q1 = {timeForQ1} minutes.");
            Console.WriteLine($"Time needed for Q2 = {timeForQ2} minutes.");
            Console.WriteLine("***************************");

            // Average time for each queue

            Console.WriteLine($"The average time for 1 operation in Q1 = {timeForQ1 / Q1.Count} minutes.");
            Console.WriteLine($"The average time for 1 operation in Q2 = {timeForQ2 / Q2.Count} minutes.");
            Console.WriteLine("***************************");
            // Minimum time for queue

            valueFromMin = Math.Min(timeForQ1,timeForQ2);

            if (valueFromMin == timeForQ1)
            {
                Console.WriteLine($"The queue with minimum time is Q1");
            }
            else if (valueFromMin == timeForQ2)
            {
                Console.WriteLine($"The queue with minimum time is Q2");
            }
            Console.WriteLine("***************************");
        }
    }
}
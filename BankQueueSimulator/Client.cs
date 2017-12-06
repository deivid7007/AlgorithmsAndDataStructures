using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankQueueSimulator
{
    class Client
    {
        public Client(string Name, int MinutesNeeded)
        {
            this.Name = Name;
            this.MinutesNeeded = MinutesNeeded;
        }

        public string Name { get; set; }
        public int MinutesNeeded { get; set; }

    }
}

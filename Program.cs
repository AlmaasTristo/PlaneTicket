using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PlaneTicket ticket1 = new PlaneTicket();
            PlaneTicket ticket2 = new PlaneTicket();

            ticket1.origin = "JOGJA";
            ticket1.destination = "PKU";
            ticket1.cost = 100;
            ticket1.currency = "USD";

            ticket2.origin = "JKT";
            ticket2.destination = "PKU";
            ticket2.cost = 750000;
            ticket2.currency = "IDR";

            ticket1.Printsummary();
            Console.WriteLine();
            ticket2.Printsummary();
        }
    }
}

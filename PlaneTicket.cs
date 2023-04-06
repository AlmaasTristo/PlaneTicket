﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class PlaneTicket
    {
        public string origin { get; set; }
        public string destination { get; set; }
        public int cost { get; set; }
        public string currency { get; set; }

        public void Printsummary()
        {
            Console.WriteLine("origin: {0}", origin);
            Console.WriteLine("Destination: {0}", destination);
            Console.WriteLine("Cost: {0} ({1})", cost, currency);
            if (currency == "IDR")
            {
                cost = cost / 15000;
                Console.WriteLine("Convert to Dolar: {0}", cost);
            }
            else if (currency == "USD")
            {
                cost = cost * 15000;
                Console.WriteLine("Convert to Rupiah: {0}", cost);
            }
        }
    }

   
}

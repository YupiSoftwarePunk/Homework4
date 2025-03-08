using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howemork4
{
    public struct Scooter : ITransport
    {
        private static readonly string _transportType = "Самокат";
        public string Type => _transportType;


        private static readonly double _rentPrice = 8;
        public double RentPrice => _rentPrice;


        public string Model { get; set; }
        public int Year { get; set; }
    }
}

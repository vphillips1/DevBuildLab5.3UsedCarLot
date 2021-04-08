using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._3UsedCarLot
{
    class Car
    {
        public string _make { get; set; }
        public string _model { get; set; }
        public int _year { get; set; }
        public double _price { get; set; }

        public Car()
        {
            _make = "";
            _model = "";
            _year = 0;
            _price = 0;

        }

        public Car(string make, string model, int year, double price )
        {
            _make = make;
            _model = model;
            _year = year;
            _price = price;
        }

        public override string ToString()
        {
           return _make +   "\t"   + _model + "\t"   + _year + "\t"   + "$" + _price + "\n";
        }
    }
}

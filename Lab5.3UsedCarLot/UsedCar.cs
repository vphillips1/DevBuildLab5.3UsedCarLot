using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._3UsedCarLot
{
    class UsedCar : Car
    {
        public double _mileage { get; set; }

            
        public UsedCar(string make, string model, int year, double price, double mileage) : base (make, model, year, price)
        {
         
            _mileage = mileage;

        }


      
       
        public override string ToString()
        {
            return _make +  "\t"  + _model +  "\t"   + _year +   "\t"  + "$" +_price +   "\t"  + "(Used)" +   "\t"   + _mileage  + "\t" + "miles"  + "\n";
        }
    }
}

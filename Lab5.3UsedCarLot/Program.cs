using System;
using System.Collections.Generic;

namespace Lab5._3UsedCarLot
{
    class Program
    {
        static void Main(string[] args)
        {       
          
            CarLot.carType.Add(new Car("Nikolai", "Model S", 2017, 54999.90));
            CarLot.carType.Add(new Car("Ford", "Escape", 2017, 31999.90));
            CarLot.carType.Add(new Car("Chewie", "Vette", 2017, 44989.95));
            CarLot.carType.Add(new UsedCar("Hyonda", "Prior", 2015, 14795.90, 35987.6));
            CarLot.carType.Add(new UsedCar("GC", "Chirpus", 2013, 8500.00, 12345));
            CarLot.carType.Add(new UsedCar("GC", "Witherall", 2016, 14450.00, 3500.3));



            Console.WriteLine("Welcome to Grant Chirpus' Used Car Emporium! \n");

            

            bool again = true;

            while( again )
            {              
                again = CarLot.ListofCars();             
            }






          

        }
    }
}

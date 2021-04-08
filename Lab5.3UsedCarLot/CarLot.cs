using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._3UsedCarLot
{
    class CarLot
    {
      public static  List<Car> carType = new List<Car>();

         static public void AddCar(Car car)
         {

            carType.Add(car);
         }
       public static void UserAddedCar()
       {
            Console.WriteLine("Enter the make:");
            var makeofCar = Console.ReadLine();

            Console.WriteLine("Enter the model:");
            var modelofCar = Console.ReadLine();

            Console.WriteLine("Enter the year:");
            int.TryParse(Console.ReadLine(), out int yearofCar);


            Console.WriteLine("What is the price?");
            double.TryParse(Console.ReadLine(), out double priceofCar);

            Console.WriteLine("How many miles ?");
            double.TryParse(Console.ReadLine(), out double milesofCar);

           CarLot.AddCar(new UsedCar(makeofCar, modelofCar, yearofCar, priceofCar, milesofCar));
         
       }
    
        public static bool ListofCars()
        {
          
            for (int i = 0; i < carType.Count; i++)
            {

                Console.WriteLine($"{i + 1 } \t {carType[i]} \t");
                //  Console.WriteLine(carType[i]);

            }
            Console.WriteLine($"{carType.Count + 1} \t Add a car");
            Console.WriteLine("");
            Console.WriteLine($"{carType.Count + 2} \t quit");
            Console.WriteLine("");
            Console.WriteLine("Which car would you like to buy ? ");
            int choice = Int32.Parse(Console.ReadLine());

            if(choice > 0 && choice < carType.Count + 1)
            {

                Console.WriteLine($" You've selected: {carType[choice - 1]}");
               
                Console.WriteLine("Would you like to buy this car?");
                string userResponse = Console.ReadLine().ToLower();
                if(userResponse == "y" || userResponse == "yes")
                {
                   
                    Console.WriteLine("Excellent! Our finance department will be in touch shortly.\n");
                    CarLot.RemoveCar(choice, carType);
                    Console.WriteLine("");
                }
                else if( userResponse == "n" || userResponse == "no")
                {
                    Console.WriteLine("Please choose a different option \n");
                    return true;
                   
                }


                return true;
              
            }
            else if(choice == carType.Count + 1)
            {
                Console.WriteLine($"Add a Car");
                CarLot.UserAddedCar();
                return true;
            }
            else if(choice == carType.Count + 2)

            {

                Console.WriteLine("Have a nice day!");
                return false;
            }
            else
            {

                return false;
            }

           

        }

        public static void RemoveCar(int choice, List<Car> carType )
        {

            carType.Remove(carType[choice-1]);
        }

        

    }
}

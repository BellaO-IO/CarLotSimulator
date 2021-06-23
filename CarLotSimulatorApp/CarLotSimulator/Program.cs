using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Car Mycar = new Car("chevy", 200);
           // var Mycara = new Car();
           // var Mycarb = new Car();
            
            
           // Console.WriteLine($"{Mycar.Model} {Mycar.Make} {Mycar.Year}");

            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            Car Mycar1 = new Car("Chevy", 2060, "ChevyModel", "vroom", "beep", true);
            Car Mycar2 = new Car() { Make = "toyota", Year = 2070, Model = "toyotacar", EngineNoise = "silence", HonkNoise = "bonk", Isdrivable = false };
            Car Mycar3 = new Car();
            Mycar3.Make = "Lambo";
            Mycar3.Year = 2090;
            Mycar3.Model = "Lambomodel";

            //*************BONUS X 2*************//
            Carlot carLot = new Carlot();
            carLot.ParkingLot.Add(Mycar1);
            carLot.ParkingLot.Add(Mycar2);
            carLot.ParkingLot.Add(Mycar3);
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach(var car in carLot.ParkingLot)
            {
                Console.WriteLine(car.EngineNoise);
                Console.WriteLine(car.HonkNoise);
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
                Console.WriteLine(car.Year);
                Console.WriteLine(car.Isdrivable);
                
            }
        }
    }
}

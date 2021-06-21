using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car(string Make, int year, string Model, string engineNoise, string honkNoise, bool isDrivable)
        {
            Year = year;
            Make = Make;
            Model = Model;
            engineNoise = engineNoise;
            honkNoise = honkNoise;
            Isdrivable = Isdrivable;




        }

        public carLot()
        {

        }
         

       
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public string engineNoise { get; set; }
        public string honkNoise { get; set; }
        public bool Isdrivable { get; set; }
        public void CarInfo()
        {
            Console.WriteLine($"{ Model}{ Make}{ Year}");


        }
        public void MakeEngineNoise()
        {
            Console.WriteLine(engineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine();
        }

    



    }
}

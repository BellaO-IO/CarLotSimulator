using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            
        }

        
        public Car(string Make, int year, string Model, string engineNoise, string honkNoise, bool isDrivable)
        {
            this.Year = year;
            this.Make = Make;
            this.Model = Model;
            this.EngineNoise = engineNoise;
            this.HonkNoise = honkNoise;
            this.Isdrivable = isDrivable;




        }
         

       
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool Isdrivable { get; set; }
        public void CarInfo()
        {
            Console.WriteLine($"{ Model}{ Make}{ Year}");


        }
        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine();
        }

    



    }
}

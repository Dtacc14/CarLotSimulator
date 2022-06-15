using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Modle { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public string MakeEngineNoise()
        {
            return EngineNoise;
        }
        public string MakeHonkNoise()
        {
            return HonkNoise;
        }

        public Car(int YearMade, string MakeType, string ModleType, string NoiseFromEngine, string HornSound, bool CanDrive)
        {
            Year = YearMade;
            Make = MakeType;
            Modle = ModleType;
            EngineNoise = NoiseFromEngine;
            HonkNoise = HornSound;
            IsDriveable = CanDrive;
            Console.WriteLine($"The last type of car is a {Year} {Make} {Modle} that sounds like {EngineNoise} when you drive it, and sounds like {HonkNoise} when you honk it. I like this car: {IsDriveable}");
            CarLot.numberOfCars++;
        }

    }
}

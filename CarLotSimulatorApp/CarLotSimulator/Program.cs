using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO - Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            var parkingLot = new CarLot();

            var car1 = new Car() { Year = 2021, Make = "Kia", Modle = "Rio", IsDriveable = true, EngineNoise = "Vrooom", HonkNoise = "BEEEE" };                 //Now that the Car class is created we can instanciate 3 new cars
            var car2 = new Car() { Year = 2017, Make = "Volkswagen", Modle = "Jetta", IsDriveable = false, EngineNoise = "*moving sound*", HonkNoise = "EHH" }; //Set the properties for each of the cars
            var car3 = new Car() { Year = 2003, Make = "Toyota", Modle = "Solara", IsDriveable = true, EngineNoise = "hummmm", HonkNoise = "BUUUU" };            //Call each of the methods for each car
            Console.WriteLine($"My first car was a {car3.Year} {car3.Make} {car3.Modle} that would make a {car3.EngineNoise} sound when I drove it, and a {car3.HonkNoise} sound when I honked the horn. I really loved that car: {car3.IsDriveable}");
            Console.WriteLine();
            Console.WriteLine($"After that I drove a {car2.Year} {car2.Make} {car2.Modle} that would make a {car2.EngineNoise} sound when I drove it, and a {car2.HonkNoise} sound when I honked the horn. I really loved that car: {car2.IsDriveable}");
            Console.WriteLine();
            Console.WriteLine($"Now I drive a {car1.Year} {car1.Make} {car1.Modle} that makes a {car1.EngineNoise} sound when I drive it, and a {car1.HonkNoise} sound when I honk the horn. I really love this car: {car1.IsDriveable}");
            parkingLot.CarType.Add(car1);
            parkingLot.CarType.Add(car2);
            parkingLot.CarType.Add(car3);

            //*************BONUS*************//

            var car4 = new Car();
            car4.Year = 2008;
            car4.Make = "Toyota";
            car4.Modle = "Tacoma";
            car4.IsDriveable = true;
            car4.EngineNoise = "shhhhhh";          // Set the properties utilizing the 3 different ways we learned about, one way for each car
            car4.HonkNoise = "honk";
            Console.WriteLine($"Another type of car is the {car4.Year} {car4.Make} {car4.Modle} that makes a {car4.EngineNoise} sound when you drive it, and a {car4.HonkNoise} sound when you honk the horn. I really love these types of car: {car3.IsDriveable}");
            Console.WriteLine();
            var Car5 = new Car(2007, "Ford", "F150", "zoom", "beep", true);
            Console.WriteLine(Car5);
            Console.WriteLine();
            parkingLot.CarType.Add(car4);
            parkingLot.CarType.Add(Car5);

            //*************BONUS X 2*************//

            foreach (var Car in parkingLot.CarType)                                       //Create a CarLot class
            {                                                                             //It should have at least one property: a List of cars
                Console.WriteLine($"This car is a {Car.Year} {Car.Make} {Car.Modle}.");   //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
                Console.WriteLine();                                                      //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            }
            
            Console.WriteLine($"There are {CarLot.numberOfCars} in the parking lot.");
        }
    }
}

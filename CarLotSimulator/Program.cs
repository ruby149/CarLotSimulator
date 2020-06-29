using System;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();

            //TODO
            //dot notation
            var rubysCar = new Car();
            rubysCar.Make = "Toyota";
            rubysCar.Model = "Tundra";
            rubysCar.Year = 2020;
            rubysCar.EngineNoise = "room";
            rubysCar.HonkNoise = "beep";
            rubysCar.IsDrivable = true;

            lot.Cars.Add(rubysCar);

            //Object initializer syntax
            var RichsCar = new Car();
            {
                RichsCar.Make = "Jeep";
                RichsCar.Model = "Cherokee";
                RichsCar.Year = 2018;
                RichsCar.EngineNoise = "vroom";
                RichsCar.HonkNoise = "beep beep";
                RichsCar.IsDrivable = true;
                lot.Cars.Add(RichsCar);
            };
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars

            //using the constructor to allow paramater values to be placed inside properties
            var CindysCar = new Car(2014, "Toyota", "Tacoma", "vroooooom", "beeeeeeep", false);
            lot.Cars.Add(CindysCar);
            //Call each of the methods for each car

            rubysCar.MakeEngineNoise(rubysCar.EngineNoise);
            RichsCar.MakeEngineNoise(RichsCar.EngineNoise);
            CindysCar.MakeEngineNoise(CindysCar.EngineNoise);

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year:{car.Year},Make:{car.Make},Model:{car.Model}");
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//
           

          

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}

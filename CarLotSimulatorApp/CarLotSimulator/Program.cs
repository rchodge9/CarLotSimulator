using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
            

            var oneFord = new Car();
            oneFord.Make = "Ford";
            oneFord.Model = " Explorer";
            oneFord.Year = 2020;
            oneFord.EngineNoise = "vroom";
            oneFord.HonkNoise = "beep";
            oneFord.IsDrivable = true;
            lot.Cars.Add(oneFord);

            var twoKia = new Car();
            twoKia.Make = "Kia";
            twoKia.Model = "Sportage";
            twoKia.Year = 2000;
            twoKia.EngineNoise = "sputter";
            twoKia.HonkNoise = "none";
            twoKia.IsDrivable = false;
            lot.Cars.Add(twoKia);

            var threeChevy = new Car()
            {
                Make = "Chevy",
                Model = "Blazer",
                Year = 2012,
                EngineNoise = "vroom",
                HonkNoise = "honk honk",
                IsDrivable = true,
            };
            lot.Cars.Add(threeChevy);

            var fourMazda = new Car("Mazda", "Miata", 2018, "vroom", "beep", true);
            lot.Cars.Add(fourMazda);
            //Call Methods
            oneFord.MakeEngineNoise(oneFord.EngineNoise);
            twoKia.MakeEngineNoise(twoKia.EngineNoise);
            threeChevy.MakeEngineNoise(threeChevy.EngineNoise);
            fourMazda.MakeEngineNoise(fourMazda.EngineNoise);

            Console.WriteLine($"Number of cars: {CarLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($" Year:{car.Year} Make:{car.Make} Model:{car.Model}");
            }

        }

    }  
         



            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        
    
}

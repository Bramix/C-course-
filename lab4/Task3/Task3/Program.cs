using System;
using System.Collections.Generic;

namespace Task3
{
    
    class Aircraft : TransportShip
    {
        public Aircraft(string name, string appointment, Double power, string typeOfFuel) : base(name, appointment, power, typeOfFuel)
        {}
        
    }

    class Rocketcraft : TransportShip
    {
        public Rocketcraft(string name, string appointment, Double power, string typeOfFuel) : base(name, appointment, power, typeOfFuel)
        {}
        
    }

    public class Program
    {
        private static void PrintDictionary (Dictionary <String, int> dictionary)
        {
            foreach (var keyValuePair in dictionary)
            {
                Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
            }
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Creating a new Aircraft");
            TransportShip aircraft = new Aircraft("N-1002", "to carry aircrafts", 1000, "95");
            Console.WriteLine(aircraft.ToString());
            Console.WriteLine("Filling the dictionary of the AirCraft:");
            aircraft.AddTypeOfPlaneAndCount("Plane1", 40);
            aircraft.AddTypeOfPlaneAndCount("Plane2", 30);
            PrintDictionary(aircraft.GetCountAndTypeOfGoodToDelivery);
            
            Console.WriteLine();
            
            Console.WriteLine("Creating a new Rocketcraft");
            TransportShip rocketCraft = new Aircraft("N-1005", "to carry rockets", 2000, "4b");
            Console.WriteLine(rocketCraft.ToString());
            Console.WriteLine("Filling the dictionary of the Rocketcraft:");
            rocketCraft.AddTypeOfPlaneAndCount("Rocket1", 100);
            rocketCraft.AddTypeOfPlaneAndCount("Rocket2", 200);
            PrintDictionary(rocketCraft.GetCountAndTypeOfGoodToDelivery);
            
        }
    }
}
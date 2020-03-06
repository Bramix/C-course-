using System;
using System.Collections.Generic;

namespace Task3
{
    abstract public class TransportShip : Ship
    {
        protected Dictionary<String, int> CountAndTypeOfGoodToDelivery = new Dictionary<string, int>();

        public Dictionary<string, int> GetCountAndTypeOfGoodToDelivery => CountAndTypeOfGoodToDelivery;

        public void AddTypeOfPlaneAndCount(String nameOfPlane, int count)
        {
            CountAndTypeOfGoodToDelivery.Add(nameOfPlane, count);
        }
        
        protected TransportShip(string name, string appointment, double power, string typeOfFuel) : base(name, appointment, power, typeOfFuel)
        {}
    }
}
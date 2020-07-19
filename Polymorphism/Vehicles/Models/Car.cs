using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double DefaultAirConditionerFuelConsumption = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, bool hasAirConditioner = true) 
            : base(fuelQuantity, fuelConsumption, hasAirConditioner)
        {
        }

        public override double AirConditionerFuelConsumption => DefaultAirConditionerFuelConsumption;
    }
}

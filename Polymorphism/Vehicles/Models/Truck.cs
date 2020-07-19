using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double DefaultAirConditionerFuelConsumption = 1.6;
        private const double RefuelPercentage = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption, bool hasAirConditioner = true) 
            : base(fuelQuantity, fuelConsumption, hasAirConditioner)
        {
        }

        public override double AirConditionerFuelConsumption => DefaultAirConditionerFuelConsumption;

        public override void Refuel(double liters)
        {
            base.Refuel(liters * RefuelPercentage);
        }
    }
}

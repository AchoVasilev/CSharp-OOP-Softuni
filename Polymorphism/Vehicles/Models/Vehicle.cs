using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption, bool hasAirConditioner = true)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.HasAirConditioner = hasAirConditioner;
        }
        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; }

        public bool HasAirConditioner { get; }

        public abstract double AirConditionerFuelConsumption { get; }

        public bool Drive(double distance)
        {
            double spentFuel = distance * this.FuelConsumption;

            if (HasAirConditioner)
            {
                spentFuel += AirConditionerFuelConsumption * distance;
            }

            if (this.FuelQuantity < spentFuel)
            {
                return false;
            }

            this.FuelQuantity -= spentFuel;
            return true;
        }

        public virtual void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}

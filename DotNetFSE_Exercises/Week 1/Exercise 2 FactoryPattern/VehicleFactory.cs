using System;

namespace Exercise_02_FactoryPattern
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            if (vehicleType.Equals("Car", StringComparison.OrdinalIgnoreCase))
            {
                return new Car();
            }
            else if (vehicleType.Equals("Bike", StringComparison.OrdinalIgnoreCase))
            {
                return new Bike();
            }
            else
            {
                throw new ArgumentException("Invalid Vehicle Type");
            }
        }
    }
}



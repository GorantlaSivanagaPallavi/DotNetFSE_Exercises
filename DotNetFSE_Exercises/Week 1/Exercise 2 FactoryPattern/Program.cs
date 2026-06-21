using Exercise_02_FactoryPattern;

Console.WriteLine("=== Factory Pattern Example ===");

// Ask the factory to create a Car object
IVehicle vehicle1 = VehicleFactory.GetVehicle("Car");
vehicle1.Drive();

// Ask the factory to create a Bike object
IVehicle vehicle2 = VehicleFactory.GetVehicle("Bike");
vehicle2.Drive();

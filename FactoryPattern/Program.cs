
using FactoryPattern;

Console.WriteLine("Enter the amount of tires you want.");
int numOfWheels;


    var input = int.TryParse(Console.ReadLine(), out numOfWheels);

    var vehicle = VehicleFactory.GetVehicle(numOfWheels);

    //Console.WriteLine(input);
    //Console.WriteLine();
    vehicle.Drive();


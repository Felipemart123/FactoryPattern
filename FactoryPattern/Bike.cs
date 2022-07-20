using System;
namespace FactoryPattern
{
    public class Bike : IVehicle
    {
        public Bike()
        {
        }

        public void Drive()
        {
            Console.WriteLine("the car is in motion");
        }
    }
}


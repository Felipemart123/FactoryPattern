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
            Console.WriteLine("this bike is in motion");
        }
    }
}


﻿using System;
namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int Wheels)
        {
            switch (Wheels)
            {
                case 2:
                    return new Bike();
                    break;
                case 3:
                    return new Car();
                    break;
                case 4:
                    return new Truck();
                    break;
                default:
                    return new Car();
                    break;
            }

        }
    }
}


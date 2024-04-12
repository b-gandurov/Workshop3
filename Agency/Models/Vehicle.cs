using Agency.Models.Contracts;
using Agency.Validators;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Models
{
    public abstract class Vehicle: IVehicle
    {
        public int _id;
        public int _passengerCapacity;
        public double _pricePerKilometer;

        public Vehicle(int id, int passengerCapacity,double pricePerKilometer)
        {
            
            _id = id;
            _passengerCapacity = passengerCapacity;
            _pricePerKilometer = pricePerKilometer;

            
        }

        public int PassengerCapacity => _passengerCapacity;

        public double PricePerKilometer => _pricePerKilometer;

        public int Id => _id;

        public override string ToString()
        {
            //Passenger capacity: VALUE
            //Price per kilometer: VALUE
            StringBuilder vehicleInfo = new StringBuilder();
            vehicleInfo.AppendLine($"Passenger capacity: {PassengerCapacity}");
            vehicleInfo.AppendLine($"Price per kilometer: {PricePerKilometer:F2}");
            return vehicleInfo.ToString();
        }
    }
}

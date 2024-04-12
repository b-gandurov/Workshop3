using Agency.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
